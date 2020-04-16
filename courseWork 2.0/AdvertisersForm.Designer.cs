namespace courseWork_2._0
{
    partial class AdvertisersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameAddTB = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.nameUpdateTB = new System.Windows.Forms.TextBox();
            this.updateComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.deleteComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Рекламодатели";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 380);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список изданий";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(373, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Рекламодатель";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 280;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.nameAddTB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(379, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(83, 67);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(197, 44);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Рекламодатель:";
            // 
            // nameAddTB
            // 
            this.nameAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAddTB.Location = new System.Drawing.Point(174, 19);
            this.nameAddTB.Name = "nameAddTB";
            this.nameAddTB.Size = new System.Drawing.Size(195, 30);
            this.nameAddTB.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.nameUpdateTB);
            this.tabPage3.Controls.Add(this.updateComboBox);
            this.tabPage3.Controls.Add(this.updateButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(379, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Изменить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Рекламодатель:";
            // 
            // nameUpdateTB
            // 
            this.nameUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameUpdateTB.Location = new System.Drawing.Point(176, 53);
            this.nameUpdateTB.Name = "nameUpdateTB";
            this.nameUpdateTB.Size = new System.Drawing.Size(195, 30);
            this.nameUpdateTB.TabIndex = 30;
            // 
            // updateComboBox
            // 
            this.updateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateComboBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateComboBox.FormattingEnabled = true;
            this.updateComboBox.Location = new System.Drawing.Point(15, 16);
            this.updateComboBox.Name = "updateComboBox";
            this.updateComboBox.Size = new System.Drawing.Size(356, 31);
            this.updateComboBox.TabIndex = 29;
            this.updateComboBox.SelectionChangeCommitted += new System.EventHandler(this.updateComboBox_SelectionChangeCommitted);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightBlue;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(88, 101);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(197, 44);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.deleteComboBox);
            this.tabPage4.Controls.Add(this.deleteButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(379, 354);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удалить";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(8, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 23);
            this.label15.TabIndex = 32;
            this.label15.Text = "Рекламодатель:";
            // 
            // deleteComboBox
            // 
            this.deleteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteComboBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteComboBox.FormattingEnabled = true;
            this.deleteComboBox.Location = new System.Drawing.Point(174, 18);
            this.deleteComboBox.Name = "deleteComboBox";
            this.deleteComboBox.Size = new System.Drawing.Size(197, 31);
            this.deleteComboBox.TabIndex = 31;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightBlue;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(81, 64);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(197, 44);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AdvertisersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdvertisersForm";
            this.Text = "Рекламодатели";
            this.Load += new System.EventHandler(this.AdvertisersForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameAddTB;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox updateComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox deleteComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameUpdateTB;
    }
}