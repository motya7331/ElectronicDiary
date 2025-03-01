using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class TeachersForm : Form
    {
        private SchoolContext db;

        public TeachersForm()
        {
            InitializeComponent();
            db = new SchoolContext();
            LoadTeachers();
            buttonAdd.Click += buttonAdd_Click;
            buttonSave.Click += buttonSave_Click;
        }

        private void LoadTeachers()
        {
            dataGridViewTeachers.DataSource = db.Teachers
                .Select(t => new { t.Id, TeacherName = t.Name ?? "Без имени" })
                .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            var teacher = new Teacher { Name = "Новый учитель" };
            db.Teachers.Add(teacher);
            db.SaveChanges();
            LoadTeachers();
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            db.SaveChanges();
            LoadTeachers();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}