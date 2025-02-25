using System;
using System.Windows.Forms;

namespace LibrarySchoolPortal
{
    public partial class LoginForm : Form
    {
        public string UserName { get; private set; }
        public string UserRole { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserName = textBoxName.Text;
            UserRole = comboBoxRole.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(UserRole))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Введите имя и выберите роль!");
            }
        }
    }
}