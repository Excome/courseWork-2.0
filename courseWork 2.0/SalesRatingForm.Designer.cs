namespace courseWork_2._0
{
    partial class SalesRatingForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.periodicalsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rowsTB1 = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.allCheckBox = new System.Windows.Forms.CheckBox();
            this.typeCheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reportButton1 = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(589, 450);
            this.dataGridView1.TabIndex = 28;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Книги",
            "Периодические издания"});
            this.typeComboBox.Location = new System.Drawing.Point(595, 30);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(168, 25);
            this.typeComboBox.TabIndex = 29;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(592, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Тип издания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(592, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Название журнала";
            // 
            // periodicalsComboBox
            // 
            this.periodicalsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodicalsComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.periodicalsComboBox.FormattingEnabled = true;
            this.periodicalsComboBox.Items.AddRange(new object[] {
            "Книги",
            "Периодические издания"});
            this.periodicalsComboBox.Location = new System.Drawing.Point(643, 79);
            this.periodicalsComboBox.Name = "periodicalsComboBox";
            this.periodicalsComboBox.Size = new System.Drawing.Size(120, 25);
            this.periodicalsComboBox.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(592, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Количество строк";
            // 
            // rowsTB1
            // 
            this.rowsTB1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowsTB1.Location = new System.Drawing.Point(595, 128);
            this.rowsTB1.Name = "rowsTB1";
            this.rowsTB1.ReadOnly = true;
            this.rowsTB1.Size = new System.Drawing.Size(168, 25);
            this.rowsTB1.TabIndex = 36;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(595, 156);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(168, 20);
            this.hScrollBar1.TabIndex = 35;
            // 
            // allCheckBox
            // 
            this.allCheckBox.AutoSize = true;
            this.allCheckBox.Location = new System.Drawing.Point(595, 85);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(47, 19);
            this.allCheckBox.TabIndex = 38;
            this.allCheckBox.Text = "Все";
            this.allCheckBox.UseVisualStyleBackColor = true;
            // 
            // typeCheckedListBox1
            // 
            this.typeCheckedListBox1.CheckOnClick = true;
            this.typeCheckedListBox1.FormattingEnabled = true;
            this.typeCheckedListBox1.Items.AddRange(new object[] {
            "По убиванию",
            "По возрастанию"});
            this.typeCheckedListBox1.Location = new System.Drawing.Point(595, 204);
            this.typeCheckedListBox1.Name = "typeCheckedListBox1";
            this.typeCheckedListBox1.Size = new System.Drawing.Size(111, 34);
            this.typeCheckedListBox1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(592, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Сортировка отчета";
            // 
            // reportButton1
            // 
            this.reportButton1.BackColor = System.Drawing.Color.LightBlue;
            this.reportButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportButton1.Location = new System.Drawing.Point(595, 244);
            this.reportButton1.Name = "reportButton1";
            this.reportButton1.Size = new System.Drawing.Size(98, 31);
            this.reportButton1.TabIndex = 41;
            this.reportButton1.Text = "Отчет";
            this.reportButton1.UseVisualStyleBackColor = false;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.LightBlue;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printButton.Location = new System.Drawing.Point(699, 244);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(74, 31);
            this.printButton.TabIndex = 42;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // SalesRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.reportButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeCheckedListBox1);
            this.Controls.Add(this.periodicalsComboBox);
            this.Controls.Add(this.allCheckBox);
            this.Controls.Add(this.rowsTB1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SalesRating";
            this.Text = "Отчет рейтинга продаж типографии";
            this.Load += new System.EventHandler(this.SalesRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox periodicalsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rowsTB1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.CheckBox allCheckBox;
        private System.Windows.Forms.CheckedListBox typeCheckedListBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reportButton1;
        private System.Windows.Forms.Button printButton;
    }
}