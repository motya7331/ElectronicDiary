using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class TestsScheduleForm : Form
    {
        private SchoolContext db;

        public TestsScheduleForm()
        {
            InitializeComponent();
            db = new SchoolContext();
            LoadTests();
            buttonAdd.Click += buttonAdd_Click;
            buttonSave.Click += buttonSave_Click;
        }

        private void LoadTests()
        {
            dataGridViewTests.DataSource = db.TestSchedules
                .Select(t => new
                {
                    t.Id,
                    ClassName = t.Class != null ? t.Class.Name ?? "Без имени" : "Нет класса",
                    SubjectName = t.Subject != null ? t.Subject.Name ?? "Без имени" : "Нет предмета",
                    t.Date,
                    t.TestType
                })
                .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            var classEntity = db.Classes.FirstOrDefault() ?? new Class { Name = "5А" };
            var subject = db.Subjects.FirstOrDefault() ?? new Subject { Name = "Математика" };

            if (!db.Classes.Any()) db.Classes.Add(classEntity);
            if (!db.Subjects.Any()) db.Subjects.Add(subject);
            db.SaveChanges();

            var test = new TestSchedule
            {
                ClassId = classEntity.Id,
                SubjectId = subject.Id,
                Date = DateTime.Now.AddDays(1),
                TestType = "Самостоятельная"
            };
            db.TestSchedules.Add(test);
            db.SaveChanges();
            LoadTests();
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            db.SaveChanges();
            LoadTests();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}