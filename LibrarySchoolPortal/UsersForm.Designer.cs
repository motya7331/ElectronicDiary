namespace LibrarySchoolPortal
{
    partial class UsersForm
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonSaveUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(560, 300);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(12, 325);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(120, 23);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Добавить пользователя";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonSaveUsers
            // 
            this.buttonSaveUsers.Location = new System.Drawing.Point(150, 325);
            this.buttonSaveUsers.Name = "buttonSaveUsers";
            this.buttonSaveUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveUsers.TabIndex = 2;
            this.buttonSaveUsers.Text = "Сохранить";
            this.buttonSaveUsers.UseVisualStyleBackColor = true;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.buttonSaveUsers);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "UsersForm";
            this.Text = "Управление пользователями";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonSaveUsers;
    }
}