using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class LoginForm : Form 
    {
        private SchoolContext db;

        public string UserName { get; private set; }
        public string UserRole { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            db = new SchoolContext();
            comboBoxRole.Items.AddRange(new[] { "Student", "Parent", "Teacher", "Admin" });
            comboBoxRole.SelectedIndex = 0;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string role = comboBoxRole.SelectedItem.ToString();

            var user = db.Users
                .FirstOrDefault(u => u.Login == login && u.Password == password && u.Role == role);

            if (user != null)
            {
                UserName = login;
                UserRole = role;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин, пароль или роль.");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}