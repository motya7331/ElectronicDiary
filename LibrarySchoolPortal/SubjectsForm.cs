using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class SubjectsForm : Form
    {
        private SchoolContext db;

        public SubjectsForm()
        {
            InitializeComponent();
            db = new SchoolContext();
            LoadSubjects();
            buttonAdd.Click += buttonAdd_Click;
            buttonSave.Click += buttonSave_Click;
        }

        private void LoadSubjects()
        {
            dataGridViewSubjects.DataSource = db.Subjects
                .Select(s => new { s.Id, SubjectName = s.Name ?? "Без имени" })
                .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            var subject = new Subject { Name = "Новый предмет" };
            db.Subjects.Add(subject);
            db.SaveChanges();
            LoadSubjects();
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            db.SaveChanges();
            LoadSubjects();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}