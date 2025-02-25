using System;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var db = new SchoolContext())
            {
                db.Database.EnsureCreated(); 
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
            Form scheduleForm = new Form { Text = "Расписание" };
            scheduleForm.Show();
        }

        private void ввестиОценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form enterGradesForm = new Form { Text = "Ввод оценок" };
            enterGradesForm.Show();
        }

        private void планированиеУроковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form planLessonsForm = new Form { Text = "Планирование" };
            planLessonsForm.Show();
        }

        private void управлениеКадрамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void аналитикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form analyticsForm = new Form { Text = "Аналитика" };
            analyticsForm.Show();
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