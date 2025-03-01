using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class StudentsForm : Form
    {
        private SchoolContext db;

        public StudentsForm()
        {
            InitializeComponent();
            db = new SchoolContext();
            LoadStudents();
            buttonAddUser.Click += buttonAddStudent_Click;
            buttonSaveUsers.Click += buttonSaveStudents_Click;
        }

        private void LoadStudents()
        {
            dataGridViewUsers.DataSource = db.Students
                .Select(s => new
                {
                    s.Id,
                    StudentName = s.Name ?? "Без имени",
                    ClassName = s.Class != null ? s.Class.Name ?? "Без класса" : "Нет класса"
                })
                .ToList();
        }

        private void buttonAddStudent_Click(object? sender, EventArgs e)
        {
            var classEntity = db.Classes.FirstOrDefault() ?? new Class { Name = "5А" };
            if (!db.Classes.Any()) db.Classes.Add(classEntity);
            db.SaveChanges();

            var student = new Student
            {
                Name = "Новый ученик",
                ClassId = classEntity.Id
            };
            db.Students.Add(student);
            db.SaveChanges();
            LoadStudents();
        }

        private void buttonSaveStudents_Click(object? sender, EventArgs e)
        {
            db.SaveChanges();
            LoadStudents();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}