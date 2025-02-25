using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class GradesForm : Form
    {
        private SchoolContext db;

        public GradesForm()
        {
            InitializeComponent();
            db = new SchoolContext();
            LoadGrades();
            buttonAdd.Click += buttonAdd_Click;
            buttonSave.Click += buttonSave_Click;
        }

        private void LoadGrades()
        {
            dataGridViewGrades.DataSource = db.Grades.ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            var grade = new Grade
            {
                UserId = 1,
                Subject = "Математика",
                Value = 5,
                Date = DateTime.Now
            };
            db.Grades.Add(grade);
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