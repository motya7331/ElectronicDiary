using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class ScheduleForm : Form
    {
        private SchoolContext db;

        public ScheduleForm()
        {
            InitializeComponent();
            db = new SchoolContext();
            LoadSchedule();
            buttonAdd.Click += buttonAdd_Click;
            buttonSave.Click += buttonSave_Click;
        }

        private void LoadSchedule()
        {
            dataGridViewSchedule.DataSource = db.Schedules
                .Select(s => new
                {
                    s.Id,
                    ClassName = s.Class != null ? s.Class.Name ?? "Без имени" : "Нет класса",
                    TeacherName = s.Teacher != null ? s.Teacher.Name ?? "Без имени" : "Нет учителя",
                    SubjectName = s.Subject != null ? s.Subject.Name ?? "Без имени" : "Нет предмета",
                    s.Date,
                    s.LessonTime
                })
                .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            var classEntity = db.Classes.FirstOrDefault() ?? new Class { Name = "5А" };
            var teacher = db.Teachers.FirstOrDefault() ?? new Teacher { Name = "Анна Петровна" };
            var subject = db.Subjects.FirstOrDefault() ?? new Subject { Name = "Математика" };

            if (!db.Classes.Any()) db.Classes.Add(classEntity);
            if (!db.Teachers.Any()) db.Teachers.Add(teacher);
            if (!db.Subjects.Any()) db.Subjects.Add(subject);
            db.SaveChanges();

            var schedule = new Schedule
            {
                ClassId = classEntity.Id,
                TeacherId = teacher.Id,
                SubjectId = subject.Id,
                Date = DateTime.Now,
                LessonTime = "10:00-10:45"
            };
            db.Schedules.Add(schedule);
            db.SaveChanges();
            LoadSchedule();
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            db.SaveChanges();
            LoadSchedule();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}