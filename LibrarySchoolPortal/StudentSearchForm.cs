using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class StudentSearchForm : Form
    {
        private SchoolContext db;

        public StudentSearchForm()
        {
            InitializeComponent();
            db = new SchoolContext();
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            comboBoxSubject.DataSource = db.Subjects.ToList();
            comboBoxSubject.DisplayMember = "Name";
            comboBoxSubject.ValueMember = "Id";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(textBoxMinGrade.Text, out float minGrade) ||
                !float.TryParse(textBoxMaxGrade.Text, out float maxGrade))
            {
                MessageBox.Show("Введите корректные числовые значения для оценок.");
                return;
            }

            if (minGrade > maxGrade)
            {
                MessageBox.Show("Минимальная оценка не может быть больше максимальной.");
                return;
            }

            int selectedSubjectId = (int)comboBoxSubject.SelectedValue;

            var results = db.CurrentGrades
                .Where(g => g.SubjectId == selectedSubjectId)
                .GroupBy(g => g.Student)
                .Select(g => new
                {
                    StudentName = g.Key.Name ?? "Без имени",
                    AverageGrade = g.Average(x => x.Value),
                    ClassName = g.Key.Class != null ? g.Key.Class.Name ?? "Без класса" : "Нет класса"
                })
                .Where(g => g.AverageGrade >= minGrade && g.AverageGrade <= maxGrade)
                .ToList();

            dataGridViewResults.DataSource = results;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}