namespace LibrarySchoolPortal
{
    partial class StudentSearchForm
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
            this.labelMinGrade = new System.Windows.Forms.Label();
            this.textBoxMinGrade = new System.Windows.Forms.TextBox();
            this.labelMaxGrade = new System.Windows.Forms.Label();
            this.textBoxMaxGrade = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMinGrade
            // 
            this.labelMinGrade.AutoSize = true;
            this.labelMinGrade.Location = new System.Drawing.Point(12, 13);
            this.labelMinGrade.Name = "labelMinGrade";
            this.labelMinGrade.Size = new System.Drawing.Size(175, 15);
            this.labelMinGrade.TabIndex = 0;
            this.labelMinGrade.Text = "Минимальная средняя оценка:";
            // 
            // textBoxMinGrade
            // 
            this.textBoxMinGrade.Location = new System.Drawing.Point(193, 10);
            this.textBoxMinGrade.Name = "textBoxMinGrade";
            this.textBoxMinGrade.Size = new System.Drawing.Size(100, 23);
            this.textBoxMinGrade.TabIndex = 1;
            // 
            // labelMaxGrade
            // 
            this.labelMaxGrade.AutoSize = true;
            this.labelMaxGrade.Location = new System.Drawing.Point(12, 39);
            this.labelMaxGrade.Name = "labelMaxGrade";
            this.labelMaxGrade.Size = new System.Drawing.Size(179, 15);
            this.labelMaxGrade.TabIndex = 2;
            this.labelMaxGrade.Text = "Максимальная средняя оценка:";
            // 
            // textBoxMaxGrade
            // 
            this.textBoxMaxGrade.Location = new System.Drawing.Point(193, 36);
            this.textBoxMaxGrade.Name = "textBoxMaxGrade";
            this.textBoxMaxGrade.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaxGrade.TabIndex = 3;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(12, 65);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(54, 15);
            this.labelSubject.TabIndex = 4;
            this.labelSubject.Text = "Предмет:";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(193, 62);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(200, 23);
            this.comboBoxSubject.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(399, 62);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(12, 91);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(560, 258);
            this.dataGridViewResults.TabIndex = 7;
            // 
            // StudentSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.textBoxMaxGrade);
            this.Controls.Add(this.labelMaxGrade);
            this.Controls.Add(this.textBoxMinGrade);
            this.Controls.Add(this.labelMinGrade);
            this.Name = "StudentSearchForm";
            this.Text = "Поиск учеников по средней оценке";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelMinGrade;
        private System.Windows.Forms.TextBox textBoxMinGrade;
        private System.Windows.Forms.Label labelMaxGrade;
        private System.Windows.Forms.TextBox textBoxMaxGrade;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewResults;
    }
}