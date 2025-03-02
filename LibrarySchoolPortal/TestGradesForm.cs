using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class TestGradesForm : Form
    {
        private SchoolContext db;

        public TestGradesForm()
        {
            InitializeComponent();
            db = new SchoolContext();
            LoadTestGrades();
            buttonAdd.Click += buttonAdd_Click;
            buttonSave.Click += buttonSave_Click;
        }

        private void LoadTestGrades()
        {
            dataGridViewTestGrades.DataSource = db.TestGrades
                .Select(g => new
                {
                    g.Id,
                    StudentName = g.Student != null ? g.Student.Name ?? "Без имени" : "Нет ученика",
                    TestType = g.TestSchedule != null ? g.TestSchedule.TestType ?? "Без типа" : "Нет теста",
                    SubjectName = g.TestSchedule != null && g.TestSchedule.Subject != null ? g.TestSchedule.Subject.Name ?? "Без имени" : "Нет предмета",
                    g.Value,
                    g.Date
                })
                .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            var student = db.Students.FirstOrDefault() ?? new Student { Name = "Иван Иванов" };
            var testSchedule = db.TestSchedules.FirstOrDefault() ?? new TestSchedule
            {
                ClassId = db.Classes.FirstOrDefault()?.Id ?? 1,
                SubjectId = db.Subjects.FirstOrDefault()?.Id ?? 1,
                Date = DateTime.Now,
                TestType = "Контрольная"
            };
            if (!db.Students.Any()) db.Students.Add(student);
            if (!db.TestSchedules.Any()) db.TestSchedules.Add(testSchedule);
            db.SaveChanges();

            var testGrade = new TestGrade
            {
                StudentId = student.Id,
                TestScheduleId = testSchedule.Id,
                Value = 4,
                Date = testSchedule.Date
            };
            db.TestGrades.Add(testGrade);
            db.SaveChanges();
            LoadTestGrades();
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            db.SaveChanges();
            LoadTestGrades();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}