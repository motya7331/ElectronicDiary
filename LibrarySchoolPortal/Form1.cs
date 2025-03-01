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
                        var class5A = new Class { Name = "5А" };
                        var class6B = new Class { Name = "6Б" };
                        db.Classes.AddRange(class5A, class6B);
                        db.SaveChanges();

                        var teacher1 = new Teacher { Name = "Анна Петровна" };
                        var teacher2 = new Teacher { Name = "Игорь Васильевич" };
                        teacher1.Classes.Add(class5A);
                        teacher2.Classes.Add(class6B);
                        db.Teachers.AddRange(teacher1, teacher2);
                        db.SaveChanges();

                        var student1 = new Student { Name = "Иван Иванов", ClassId = class5A.Id };
                        var student2 = new Student { Name = "Мария Сидорова", ClassId = class6B.Id };
                        db.Students.AddRange(student1, student2);
                        db.SaveChanges();

                        var parent1 = new Parent { Name = "Ольга Иванова", StudentId = student1.Id };
                        var parent2 = new Parent { Name = "Пётр Сидоров", StudentId = student2.Id };
                        db.Parents.AddRange(parent1, parent2);
                        db.SaveChanges();

                        var subject1 = new Subject { Name = "Математика" };
                        var subject2 = new Subject { Name = "Русский язык" };
                        db.Subjects.AddRange(subject1, subject2);
                        db.SaveChanges();

                        var grade1 = new Grade
                        {
                            StudentId = student1.Id,
                            SubjectId = subject1.Id,
                            Value = 5,
                            Date = DateTime.Now
                        };
                        var grade2 = new Grade
                        {
                            StudentId = student2.Id,
                            SubjectId = subject2.Id,
                            Value = 4,
                            Date = DateTime.Now
                        };
                        db.Grades.AddRange(grade1, grade2);
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
            GradesForm gradesForm = new GradesForm();
            gradesForm.Show();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassesForm classesForm = new ClassesForm();
            classesForm.Show();
        }

        private void ввестиОценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachersForm teachersForm = new TeachersForm();
            teachersForm.Show();
        }

        private void планированиеУроковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectsForm subjectsForm = new SubjectsForm();
            subjectsForm.Show();
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
            MessageBox.Show("Архивирование запущено");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}