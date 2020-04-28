namespace courseWork_2._0
{
    partial class AdvertReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvertReportForm));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.printButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportButton1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeCheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.advertisersComboBox = new System.Windows.Forms.ComboBox();
            this.rowsTB1 = new System.Windows.Forms.TextBox();
            this.allCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.printButton);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(806, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчет";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.LightBlue;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printButton.Location = new System.Drawing.Point(724, 393);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(74, 31);
            this.printButton.TabIndex = 43;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 384);
            this.dataGridView1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Тип издания";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Периодические издания",
            "Буклеты"});
            this.typeComboBox.Location = new System.Drawing.Point(11, 24);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(168, 24);
            this.typeComboBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Рекламодатель";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 450);
            this.tabControl1.TabIndex = 44;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.typeComboBox);
            this.tabPage1.Controls.Add(this.reportButton1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.typeCheckedListBox1);
            this.tabPage1.Controls.Add(this.hScrollBar1);
            this.tabPage1.Controls.Add(this.advertisersComboBox);
            this.tabPage1.Controls.Add(this.rowsTB1);
            this.tabPage1.Controls.Add(this.allCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(806, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Парметры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportButton1
            // 
            this.reportButton1.BackColor = System.Drawing.Color.LightBlue;
            this.reportButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportButton1.Location = new System.Drawing.Point(11, 238);
            this.reportButton1.Name = "reportButton1";
            this.reportButton1.Size = new System.Drawing.Size(168, 31);
            this.reportButton1.TabIndex = 41;
            this.reportButton1.Text = "Сформировать отчет";
            this.reportButton1.UseVisualStyleBackColor = false;
            this.reportButton1.Click += new System.EventHandler(this.reportButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Сортировка отчета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Количество строк";
            // 
            // typeCheckedListBox1
            // 
            this.typeCheckedListBox1.CheckOnClick = true;
            this.typeCheckedListBox1.FormattingEnabled = true;
            this.typeCheckedListBox1.Items.AddRange(new object[] {
            "По убиванию",
            "По возрастанию"});
            this.typeCheckedListBox1.Location = new System.Drawing.Point(11, 198);
            this.typeCheckedListBox1.Name = "typeCheckedListBox1";
            this.typeCheckedListBox1.Size = new System.Drawing.Size(111, 34);
            this.typeCheckedListBox1.TabIndex = 39;
            this.typeCheckedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.typeCheckedListBox1_ItemCheck);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(11, 150);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(168, 20);
            this.hScrollBar1.TabIndex = 35;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // advertisersComboBox
            // 
            this.advertisersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advertisersComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.advertisersComboBox.FormattingEnabled = true;
            this.advertisersComboBox.Items.AddRange(new object[] {
            "Книги",
            "Периодические издания"});
            this.advertisersComboBox.Location = new System.Drawing.Point(59, 73);
            this.advertisersComboBox.Name = "advertisersComboBox";
            this.advertisersComboBox.Size = new System.Drawing.Size(120, 24);
            this.advertisersComboBox.TabIndex = 32;
            this.advertisersComboBox.SelectedIndexChanged += new System.EventHandler(this.advertisersComboBox_SelectedIndexChanged);
            // 
            // rowsTB1
            // 
            this.rowsTB1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowsTB1.Location = new System.Drawing.Point(11, 122);
            this.rowsTB1.Name = "rowsTB1";
            this.rowsTB1.ReadOnly = true;
            this.rowsTB1.Size = new System.Drawing.Size(168, 23);
            this.rowsTB1.TabIndex = 36;
            // 
            // allCheckBox
            // 
            this.allCheckBox.AutoSize = true;
            this.allCheckBox.Location = new System.Drawing.Point(11, 79);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(45, 17);
            this.allCheckBox.TabIndex = 38;
            this.allCheckBox.Text = "Все";
            this.allCheckBox.UseVisualStyleBackColor = true;
            this.allCheckBox.CheckedChanged += new System.EventHandler(this.allCheckBox_CheckedChanged);
            // 
            // AdvertReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdvertReportForm";
            this.Text = "Отчет по купленным рекламным интеграциям";
            this.Load += new System.EventHandler(this.AdvertReportForm_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button reportButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox typeCheckedListBox1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ComboBox advertisersComboBox;
        private System.Windows.Forms.TextBox rowsTB1;
        private System.Windows.Forms.CheckBox allCheckBox;
    }
}