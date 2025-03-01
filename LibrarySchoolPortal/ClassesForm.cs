using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class ClassesForm : Form
    {
        private SchoolContext db;

        public ClassesForm()
        {
            InitializeComponent();
            db = new SchoolContext();
            LoadClasses();
            buttonAdd.Click += buttonAdd_Click;
            buttonSave.Click += buttonSave_Click;
        }

        private void LoadClasses()
        {
            dataGridViewClasses.DataSource = db.Classes
                .Select(c => new { c.Id, ClassName = c.Name ?? "Без имени" })
                .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            var classEntity = new Class { Name = "Новый класс" };
            db.Classes.Add(classEntity);
            db.SaveChanges();
            LoadClasses();
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            db.SaveChanges();
            LoadClasses();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}