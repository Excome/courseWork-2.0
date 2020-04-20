namespace courseWork_2._0
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.typeCheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.rowsTB1 = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.periodicalsComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.allCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 451);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.allCheckBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.reportButton1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.typeCheckedListBox1);
            this.tabPage1.Controls.Add(this.rowsTB1);
            this.tabPage1.Controls.Add(this.hScrollBar1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.periodicalsComboBox);
            this.tabPage1.Controls.Add(this.typeComboBox);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Рейтинг продаж";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportButton1
            // 
            this.reportButton1.BackColor = System.Drawing.Color.LightBlue;
            this.reportButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportButton1.Location = new System.Drawing.Point(51, 164);
            this.reportButton1.Name = "reportButton1";
            this.reportButton1.Size = new System.Drawing.Size(137, 31);
            this.reportButton1.TabIndex = 24;
            this.reportButton1.Text = "Сформировать";
            this.reportButton1.UseVisualStyleBackColor = false;
            this.reportButton1.Click += new System.EventHandler(this.reportButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Издание:";
            // 
            // typeCheckedListBox1
            // 
            this.typeCheckedListBox1.CheckOnClick = true;
            this.typeCheckedListBox1.FormattingEnabled = true;
            this.typeCheckedListBox1.Items.AddRange(new object[] {
            "По убиванию",
            "По возрастанию"});
            this.typeCheckedListBox1.Location = new System.Drawing.Point(62, 124);
            this.typeCheckedListBox1.Name = "typeCheckedListBox1";
            this.typeCheckedListBox1.Size = new System.Drawing.Size(111, 34);
            this.typeCheckedListBox1.TabIndex = 22;
            this.typeCheckedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.typeCheckedListBox1_ItemCheck);
            // 
            // rowsTB1
            // 
            this.rowsTB1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowsTB1.Location = new System.Drawing.Point(116, 75);
            this.rowsTB1.Name = "rowsTB1";
            this.rowsTB1.ReadOnly = true;
            this.rowsTB1.Size = new System.Drawing.Size(115, 23);
            this.rowsTB1.TabIndex = 19;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(11, 101);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(223, 20);
            this.hScrollBar1.TabIndex = 18;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Тип:";
            // 
            // periodicalsComboBox
            // 
            this.periodicalsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodicalsComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.periodicalsComboBox.FormattingEnabled = true;
            this.periodicalsComboBox.Location = new System.Drawing.Point(82, 47);
            this.periodicalsComboBox.Name = "periodicalsComboBox";
            this.periodicalsComboBox.Size = new System.Drawing.Size(123, 24);
            this.periodicalsComboBox.TabIndex = 16;
            this.periodicalsComboBox.SelectionChangeCommitted += new System.EventHandler(this.periodicalsComboBox_SelectionChangeCommitted);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Книги",
            "Периодические издания"});
            this.typeComboBox.Location = new System.Drawing.Point(82, 17);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(149, 24);
            this.typeComboBox.TabIndex = 14;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(262, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(589, 419);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(854, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(854, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Изменить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(854, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удалить";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Кол-во строк:";
            // 
            // allCheckBox
            // 
            this.allCheckBox.AutoSize = true;
            this.allCheckBox.Location = new System.Drawing.Point(211, 51);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(45, 17);
            this.allCheckBox.TabIndex = 26;
            this.allCheckBox.Text = "Все";
            this.allCheckBox.UseVisualStyleBackColor = true;
            this.allCheckBox.CheckedChanged += new System.EventHandler(this.allCheckBox_CheckedChanged);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 451);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.Text = "Выборка отчетов";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox periodicalsComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox rowsTB1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.CheckedListBox typeCheckedListBox1;
        private System.Windows.Forms.Button reportButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox allCheckBox;
    }
}