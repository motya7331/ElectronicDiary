namespace LibrarySchoolPortal
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem войтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ученикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьОценкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ввестиОценкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem планированиеУроковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеКадрамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аналитикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem системаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem архивированиеToolStripMenuItem;

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
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.войтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ученикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьОценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввестиОценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.планированиеУроковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеКадрамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналитикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.системаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.архивированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.mainMenu.SuspendLayout();
            this.SuspendLayout();

            
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.пользовательToolStripMenuItem,
                this.ученикToolStripMenuItem,
                this.учительToolStripMenuItem,
                this.администрацияToolStripMenuItem,
                this.системаToolStripMenuItem
            });
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";

            
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.войтиToolStripMenuItem,
                this.выйтиToolStripMenuItem
            });
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Text = "Пользователь";

           
            this.войтиToolStripMenuItem.Name = "войтиToolStripMenuItem";
            this.войтиToolStripMenuItem.Text = "Войти";
            this.войтиToolStripMenuItem.Click += new System.EventHandler(this.войтиToolStripMenuItem_Click);

            
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);

            
            this.ученикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.посмотретьОценкиToolStripMenuItem,
                this.расписаниеToolStripMenuItem
            });
            this.ученикToolStripMenuItem.Name = "ученикToolStripMenuItem";
            this.ученикToolStripMenuItem.Text = "Ученик";

           
            this.посмотретьОценкиToolStripMenuItem.Name = "посмотретьОценкиToolStripMenuItem";
            this.посмотретьОценкиToolStripMenuItem.Text = "Посмотреть оценки";
            this.посмотретьОценкиToolStripMenuItem.Click += new System.EventHandler(this.посмотретьОценкиToolStripMenuItem_Click);

            
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);

            
            this.учительToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.ввестиОценкиToolStripMenuItem,
                this.планированиеУроковToolStripMenuItem
            });
            this.учительToolStripMenuItem.Name = "учительToolStripMenuItem";
            this.учительToolStripMenuItem.Text = "Учитель";

            
            this.ввестиОценкиToolStripMenuItem.Name = "ввестиОценкиToolStripMenuItem";
            this.ввестиОценкиToolStripMenuItem.Text = "Ввести оценки";
            this.ввестиОценкиToolStripMenuItem.Click += new System.EventHandler(this.ввестиОценкиToolStripMenuItem_Click);

            
            this.планированиеУроковToolStripMenuItem.Name = "планированиеУроковToolStripMenuItem";
            this.планированиеУроковToolStripMenuItem.Text = "Планирование уроков";
            this.планированиеУроковToolStripMenuItem.Click += new System.EventHandler(this.планированиеУроковToolStripMenuItem_Click);

            
            this.администрацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.управлениеКадрамиToolStripMenuItem,
                this.аналитикаToolStripMenuItem
            });
            this.администрацияToolStripMenuItem.Name = "администрацияToolStripMenuItem";
            this.администрацияToolStripMenuItem.Text = "Администрация";

            
            this.управлениеКадрамиToolStripMenuItem.Name = "управлениеКадрамиToolStripMenuItem";
            this.управлениеКадрамиToolStripMenuItem.Text = "Управление кадрами";
            this.управлениеКадрамиToolStripMenuItem.Click += new System.EventHandler(this.управлениеКадрамиToolStripMenuItem_Click);

            
            this.аналитикаToolStripMenuItem.Name = "аналитикаToolStripMenuItem";
            this.аналитикаToolStripMenuItem.Text = "Аналитика";
            this.аналитикаToolStripMenuItem.Click += new System.EventHandler(this.аналитикаToolStripMenuItem_Click);

            
            this.системаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.архивированиеToolStripMenuItem
            });
            this.системаToolStripMenuItem.Name = "системаToolStripMenuItem";
            this.системаToolStripMenuItem.Text = "Система";

            
            this.архивированиеToolStripMenuItem.Name = "архивированиеToolStripMenuItem";
            this.архивированиеToolStripMenuItem.Text = "Архивирование";
            this.архивированиеToolStripMenuItem.Click += new System.EventHandler(this.архивированиеToolStripMenuItem_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Электронный дневник школьника";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}