using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                using (var db = new SchoolContext())
                {
                    db.Database.EnsureCreated();
                    if (!db.Classes.Any())
                    {
                        // Классы
                        var class5A = new Class { Name = "5А" };
                        var class5B = new Class { Name = "5Б" };
                        var class6A = new Class { Name = "6А" };
                        var class6B = new Class { Name = "6Б" };
                        db.Classes.AddRange(class5A, class5B, class6A, class6B);
                        db.SaveChanges();

                        // Учителя
                        var teacher1 = new Teacher { Name = "Анна Петровна" };
                        var teacher2 = new Teacher { Name = "Игорь Васильевич" };
                        var teacher3 = new Teacher { Name = "Елена Сергеевна" };
                        teacher1.Classes.Add(class5A);
                        teacher1.Classes.Add(class5B);
                        teacher2.Classes.Add(class6A);
                        teacher2.Classes.Add(class6B);
                        teacher3.Classes.Add(class5A);
                        db.Teachers.AddRange(teacher1, teacher2, teacher3);
                        db.SaveChanges();

                        // Ученики
                        var student1 = new Student { Name = "Иван Иванов", ClassId = class5A.Id };
                        var student2 = new Student { Name = "Мария Сидорова", ClassId = class6B.Id };
                        var student3 = new Student { Name = "Алексей Петров", ClassId = class5B.Id };
                        var student4 = new Student { Name = "Ольга Кузнецова", ClassId = class6A.Id };
                        var student5 = new Student { Name = "Дмитрий Соколов", ClassId = class5A.Id };
                        db.Students.AddRange(student1, student2, student3, student4, student5);
                        db.SaveChanges();

                        // Родители
                        var parent1 = new Parent { Name = "Ольга Иванова", StudentId = student1.Id };
                        var parent2 = new Parent { Name = "Пётр Сидоров", StudentId = student2.Id };
                        var parent3 = new Parent { Name = "Наталья Петрова", StudentId = student3.Id };
                        var parent4 = new Parent { Name = "Сергей Кузнецов", StudentId = student4.Id };
                        var parent5 = new Parent { Name = "Анна Соколова", StudentId = student5.Id };
                        db.Parents.AddRange(parent1, parent2, parent3, parent4, parent5);
                        db.SaveChanges();

                        // Предметы
                        var subject1 = new Subject { Name = "Математика" };
                        var subject2 = new Subject { Name = "Русский язык" };
                        var subject3 = new Subject { Name = "Физика" };
                        var subject4 = new Subject { Name = "Литература" };
                        db.Subjects.AddRange(subject1, subject2, subject3, subject4);
                        db.SaveChanges();

                        // Расписание уроков
                        var schedule1 = new Schedule
                        {
                            ClassId = class5A.Id,
                            TeacherId = teacher1.Id,
                            SubjectId = subject1.Id,
                            Date = DateTime.Now,
                            LessonTime = "08:00-08:45"
                        };
                        var schedule2 = new Schedule
                        {
                            ClassId = class6B.Id,
                            TeacherId = teacher2.Id,
                            SubjectId = subject2.Id,
                            Date = DateTime.Now.AddDays(1),
                            LessonTime = "09:00-09:45"
                        };
                        var schedule3 = new Schedule
                        {
                            ClassId = class5B.Id,
                            TeacherId = teacher3.Id,
                            SubjectId = subject3.Id,
                            Date = DateTime.Now.AddDays(2),
                            LessonTime = "10:00-10:45"
                        };
                        var schedule4 = new Schedule
                        {
                            ClassId = class6A.Id,
                            TeacherId = teacher2.Id,
                            SubjectId = subject4.Id,
                            Date = DateTime.Now.AddDays(3),
                            LessonTime = "11:00-11:45"
                        };
                        db.Schedules.AddRange(schedule1, schedule2, schedule3, schedule4);
                        db.SaveChanges();

                        // Расписание тестов
                        var test1 = new TestSchedule
                        {
                            ClassId = class5A.Id,
                            SubjectId = subject1.Id,
                            Date = DateTime.Now.AddDays(2),
                            TestType = "Контрольная"
                        };
                        var test2 = new TestSchedule
                        {
                            ClassId = class6B.Id,
                            SubjectId = subject2.Id,
                            Date = DateTime.Now.AddDays(3),
                            TestType = "Самостоятельная"
                        };
                        var test3 = new TestSchedule
                        {
                            ClassId = class5B.Id,
                            SubjectId = subject3.Id,
                            Date = DateTime.Now.AddDays(4),
                            TestType = "Контрольная"
                        };
                        var test4 = new TestSchedule
                        {
                            ClassId = class6A.Id,
                            SubjectId = subject4.Id,
                            Date = DateTime.Now.AddDays(5),
                            TestType = "Самостоятельная"
                        };
                        db.TestSchedules.AddRange(test1, test2, test3, test4);
                        db.SaveChanges();

                        // Текущие оценки
                        var currentGrade1 = new CurrentGrade
                        {
                            StudentId = student1.Id,
                            SubjectId = subject1.Id,
                            Value = 5,
                            Date = DateTime.Now,
                            Topic = "Алгебра"
                        };
                        var currentGrade2 = new CurrentGrade
                        {
                            StudentId = student2.Id,
                            SubjectId = subject2.Id,
                            Value = 4,
                            Date = DateTime.Now.AddDays(-1),
                            Topic = "Грамматика"
                        };
                        var currentGrade3 = new CurrentGrade
                        {
                            StudentId = student3.Id,
                            SubjectId = subject3.Id,
                            Value = 3,
                            Date = DateTime.Now.AddDays(-2),
                            Topic = "Механика"
                        };
                        var currentGrade4 = new CurrentGrade
                        {
                            StudentId = student4.Id,
                            SubjectId = subject4.Id,
                            Value = 5,
                            Date = DateTime.Now.AddDays(-3),
                            Topic = "Пушкин"
                        };
                        var currentGrade5 = new CurrentGrade
                        {
                            StudentId = student5.Id,
                            SubjectId = subject1.Id,
                            Value = 4,
                            Date = DateTime.Now.AddDays(-4),
                            Topic = "Геометрия"
                        };
                        db.CurrentGrades.AddRange(currentGrade1, currentGrade2, currentGrade3, currentGrade4, currentGrade5);
                        db.SaveChanges();

                        // Оценки за тесты
                        var testGrade1 = new TestGrade
                        {
                            StudentId = student1.Id,
                            TestScheduleId = test1.Id,
                            Value = 5,
                            Date = test1.Date
                        };
                        var testGrade2 = new TestGrade
                        {
                            StudentId = student2.Id,
                            TestScheduleId = test2.Id,
                            Value = 3,
                            Date = test2.Date
                        };
                        var testGrade3 = new TestGrade
                        {
                            StudentId = student3.Id,
                            TestScheduleId = test3.Id,
                            Value = 4,
                            Date = test3.Date
                        };
                        var testGrade4 = new TestGrade
                        {
                            StudentId = student4.Id,
                            TestScheduleId = test4.Id,
                            Value = 5,
                            Date = test4.Date
                        };
                        var testGrade5 = new TestGrade
                        {
                            StudentId = student5.Id,
                            TestScheduleId = test1.Id,
                            Value = 4,
                            Date = test1.Date
                        };
                        db.TestGrades.AddRange(testGrade1, testGrade2, testGrade3, testGrade4, testGrade5);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании базы: {ex.Message}");
            }
        }

        private void войтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Добро пожаловать, {loginForm.UserName} ({loginForm.UserRole})!");
            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void посмотретьОценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentGradesForm currentGradesForm = new CurrentGradesForm();
            currentGradesForm.Show();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm();
            scheduleForm.Show();
        }

        private void ввестиОценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachersForm teachersForm = new TeachersForm();
            teachersForm.Show();
        }

        private void планированиеУроковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestsScheduleForm testsScheduleForm = new TestsScheduleForm();
            testsScheduleForm.Show();
        }

        private void управлениеКадрамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Show();
        }

        private void аналитикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParentsForm parentsForm = new ParentsForm();
            parentsForm.Show();
        }

        private void архивированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestGradesForm testGradesForm = new TestGradesForm();
            testGradesForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}