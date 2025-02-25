namespace LibrarySchoolPortal
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(31, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(82, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(24, 67);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(34, 15);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Роль";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] { "Ученик", "Родитель", "Учитель", "Администратор" });
            this.comboBoxRole.Location = new System.Drawing.Point(82, 64);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRole.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(100, 93);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "LoginForm";
            this.Text = "Вход в систему";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonLogin;
    }
}