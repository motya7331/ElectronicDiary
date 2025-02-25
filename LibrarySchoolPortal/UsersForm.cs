using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class UsersForm : Form
    {
        private SchoolContext db;

        public UsersForm()
        {
            InitializeComponent();
            db = new SchoolContext();
            LoadUsers();
            buttonAddUser.Click += buttonAddUser_Click;
            buttonSaveUsers.Click += buttonSaveUsers_Click;
        }

        private void LoadUsers()
        {
            dataGridViewUsers.DataSource = db.Users.ToList();
        }

        private void buttonAddUser_Click(object? sender, EventArgs e)
        {
            var user = new User
            {
                Name = "Новый пользователь",
                Role = "Ученик"
            };
            db.Users.Add(user);
            db.SaveChanges();
            LoadUsers();
        }

        private void buttonSaveUsers_Click(object? sender, EventArgs e)
        {
            db.SaveChanges();
            LoadUsers();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}