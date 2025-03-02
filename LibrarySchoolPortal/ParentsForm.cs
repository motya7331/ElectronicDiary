using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class ParentsForm : Form
    {
        private SchoolContext db;

        public ParentsForm()
        {
            InitializeComponent();
            db = new SchoolContext();
            LoadParents();
            buttonAdd.Click += buttonAdd_Click;
            buttonSave.Click += buttonSave_Click;
        }

        private void LoadParents()
        {
            dataGridViewParents.DataSource = db.Parents
                .Select(p => new
                {
                    p.Id,
                    ParentName = p.Name ?? "Без имени",
                    StudentName = p.Student != null ? p.Student.Name ?? "Без имени" : "Нет ученика"
                })
                .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            var student = db.Students.FirstOrDefault() ?? new Student { Name = "Иван Иванов" };
            if (!db.Students.Any()) db.Students.Add(student);
            db.SaveChanges();

            var parent = new Parent
            {
                Name = "Новый родитель",
                StudentId = student.Id
            };
            db.Parents.Add(parent);
            db.SaveChanges();
            LoadParents();
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            db.SaveChanges();
            LoadParents();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}