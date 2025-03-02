using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class CurrentGradesForm : Form
    {
        private SchoolContext db;

        public CurrentGradesForm()
        {
            InitializeComponent();
            db = new SchoolContext();
            LoadGrades();
            buttonAdd.Click += buttonAdd_Click;
            buttonSave.Click += buttonSave_Click;
        }

        private void LoadGrades()
        {
            dataGridViewCurrentGrades.DataSource = db.CurrentGrades
                .Select(g => new
                {
                    g.Id,
                    StudentName = g.Student != null ? g.Student.Name ?? "Без имени" : "Нет ученика",
                    SubjectName = g.Subject != null ? g.Subject.Name ?? "Без имени" : "Нет предмета",
                    g.Value,
                    g.Date,
                    g.Topic
                })
                .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            var student = db.Students.FirstOrDefault() ?? new Student { Name = "Иван Иванов" };
            var subject = db.Subjects.FirstOrDefault() ?? new Subject { Name = "Математика" };
            if (!db.Students.Any()) db.Students.Add(student);
            if (!db.Subjects.Any()) db.Subjects.Add(subject);
            db.SaveChanges();

            var grade = new CurrentGrade
            {
                StudentId = student.Id,
                SubjectId = subject.Id,
                Value = 4,
                Date = DateTime.Now,
                Topic = "Новая тема"
            };
            db.CurrentGrades.Add(grade);
            db.SaveChanges();
            LoadGrades();
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            db.SaveChanges();
            LoadGrades();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}