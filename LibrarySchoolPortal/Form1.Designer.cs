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
            mainMenu = new MenuStrip();
            пользовательToolStripMenuItem = new ToolStripMenuItem();
            войтиToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            ученикToolStripMenuItem = new ToolStripMenuItem();
            посмотретьОценкиToolStripMenuItem = new ToolStripMenuItem();
            расписаниеToolStripMenuItem = new ToolStripMenuItem();
            учительToolStripMenuItem = new ToolStripMenuItem();
            ввестиОценкиToolStripMenuItem = new ToolStripMenuItem();
            планированиеУроковToolStripMenuItem = new ToolStripMenuItem();
            администрацияToolStripMenuItem = new ToolStripMenuItem();
            управлениеКадрамиToolStripMenuItem = new ToolStripMenuItem();
            аналитикаToolStripMenuItem = new ToolStripMenuItem();
            системаToolStripMenuItem = new ToolStripMenuItem();
            архивированиеToolStripMenuItem = new ToolStripMenuItem();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { пользовательToolStripMenuItem, ученикToolStripMenuItem, учительToolStripMenuItem, администрацияToolStripMenuItem, системаToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new Padding(7, 2, 0, 2);
            mainMenu.Size = new Size(933, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "mainMenu";
            // 
            // пользовательToolStripMenuItem
            // 
            пользовательToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { войтиToolStripMenuItem, выйтиToolStripMenuItem });
            пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            пользовательToolStripMenuItem.Size = new Size(96, 20);
            пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // войтиToolStripMenuItem
            // 
            войтиToolStripMenuItem.Name = "войтиToolStripMenuItem";
            войтиToolStripMenuItem.Size = new Size(109, 22);
            войтиToolStripMenuItem.Text = "Войти";
            войтиToolStripMenuItem.Click += войтиToolStripMenuItem_Click;
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(109, 22);
            выйтиToolStripMenuItem.Text = "Выйти";
            выйтиToolStripMenuItem.Click += выйтиToolStripMenuItem_Click;
            // 
            // ученикToolStripMenuItem
            // 
            ученикToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { посмотретьОценкиToolStripMenuItem, расписаниеToolStripMenuItem });
            ученикToolStripMenuItem.Name = "ученикToolStripMenuItem";
            ученикToolStripMenuItem.Size = new Size(59, 20);
            ученикToolStripMenuItem.Text = "Ученик";
            // 
            // посмотретьОценкиToolStripMenuItem
            // 
            посмотретьОценкиToolStripMenuItem.Name = "посмотретьОценкиToolStripMenuItem";
            посмотретьОценкиToolStripMenuItem.Size = new Size(184, 22);
            посмотретьОценкиToolStripMenuItem.Text = "Посмотреть оценки";
            посмотретьОценкиToolStripMenuItem.Click += посмотретьОценкиToolStripMenuItem_Click;
            // 
            // расписаниеToolStripMenuItem
            // 
            расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            расписаниеToolStripMenuItem.Size = new Size(184, 22);
            расписаниеToolStripMenuItem.Text = "Расписание";
            расписаниеToolStripMenuItem.Click += расписаниеToolStripMenuItem_Click;
            // 
            // учительToolStripMenuItem
            // 
            учительToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ввестиОценкиToolStripMenuItem, планированиеУроковToolStripMenuItem });
            учительToolStripMenuItem.Name = "учительToolStripMenuItem";
            учительToolStripMenuItem.Size = new Size(64, 20);
            учительToolStripMenuItem.Text = "Учитель";
            // 
            // ввестиОценкиToolStripMenuItem
            // 
            ввестиОценкиToolStripMenuItem.Name = "ввестиОценкиToolStripMenuItem";
            ввестиОценкиToolStripMenuItem.Size = new Size(198, 22);
            ввестиОценкиToolStripMenuItem.Text = "Ввести оценки";
            ввестиОценкиToolStripMenuItem.Click += ввестиОценкиToolStripMenuItem_Click;
            // 
            // планированиеУроковToolStripMenuItem
            // 
            планированиеУроковToolStripMenuItem.Name = "планированиеУроковToolStripMenuItem";
            планированиеУроковToolStripMenuItem.Size = new Size(198, 22);
            планированиеУроковToolStripMenuItem.Text = "Планирование уроков";
            планированиеУроковToolStripMenuItem.Click += планированиеУроковToolStripMenuItem_Click;
            // 
            // администрацияToolStripMenuItem
            // 
            администрацияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { управлениеКадрамиToolStripMenuItem, аналитикаToolStripMenuItem });
            администрацияToolStripMenuItem.Name = "администрацияToolStripMenuItem";
            администрацияToolStripMenuItem.Size = new Size(107, 20);
            администрацияToolStripMenuItem.Text = "Администрация";
            // 
            // управлениеКадрамиToolStripMenuItem
            // 
            управлениеКадрамиToolStripMenuItem.Name = "управлениеКадрамиToolStripMenuItem";
            управлениеКадрамиToolStripMenuItem.Size = new Size(190, 22);
            управлениеКадрамиToolStripMenuItem.Text = "Управление кадрами";
            управлениеКадрамиToolStripMenuItem.Click += управлениеКадрамиToolStripMenuItem_Click;
            // 
            // аналитикаToolStripMenuItem
            // 
            аналитикаToolStripMenuItem.Name = "аналитикаToolStripMenuItem";
            аналитикаToolStripMenuItem.Size = new Size(190, 22);
            аналитикаToolStripMenuItem.Text = "Аналитика";
            аналитикаToolStripMenuItem.Click += аналитикаToolStripMenuItem_Click;
            // 
            // системаToolStripMenuItem
            // 
            системаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { архивированиеToolStripMenuItem });
            системаToolStripMenuItem.Name = "системаToolStripMenuItem";
            системаToolStripMenuItem.Size = new Size(66, 20);
            системаToolStripMenuItem.Text = "Система";
            // 
            // архивированиеToolStripMenuItem
            // 
            архивированиеToolStripMenuItem.Name = "архивированиеToolStripMenuItem";
            архивированиеToolStripMenuItem.Size = new Size(161, 22);
            архивированиеToolStripMenuItem.Text = "Архивирование";
            архивированиеToolStripMenuItem.Click += архивированиеToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Электронный дневник школьника";
            Load += Form1_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}