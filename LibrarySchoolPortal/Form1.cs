namespace LibrarySchoolPortal
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void войтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form loginForm = new Form { Text = "Вход в систему" };
            loginForm.ShowDialog();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void посмотретьОценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gradesForm = new Form { Text = "Оценки" };
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
            Form staffForm = new Form { Text = "Кадры" };
            staffForm.Show();
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
    }
}