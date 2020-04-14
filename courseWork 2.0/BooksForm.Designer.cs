namespace courseWork_2._0
{
    partial class BooksForm
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addButton = new System.Windows.Forms.Button();
            this.numberOfYearAddTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameAddTB = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.numberOfYearUpdateTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameUpdateTB = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(245, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список книг";
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
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 380);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(751, 354);
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
            this.name,
            this.author,
            this.count,
            this.unit_price,
            this.unit_cost,
            this.total_sale});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addButton);
            this.tabPage2.Controls.Add(this.numberOfYearAddTB);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.nameAddTB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(751, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(157, 88);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(197, 44);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // numberOfYearAddTB
            // 
            this.numberOfYearAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfYearAddTB.Location = new System.Drawing.Point(341, 52);
            this.numberOfYearAddTB.Name = "numberOfYearAddTB";
            this.numberOfYearAddTB.Size = new System.Drawing.Size(145, 30);
            this.numberOfYearAddTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(54, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество номеров в год:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название:";
            // 
            // nameAddTB
            // 
            this.nameAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAddTB.Location = new System.Drawing.Point(217, 15);
            this.nameAddTB.Name = "nameAddTB";
            this.nameAddTB.Size = new System.Drawing.Size(269, 30);
            this.nameAddTB.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.updateButton);
            this.tabPage3.Controls.Add(this.numberOfYearUpdateTB);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.nameUpdateTB);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(751, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Изменить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(428, 31);
            this.comboBox1.TabIndex = 13;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightBlue;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(163, 123);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(197, 44);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // numberOfYearUpdateTB
            // 
            this.numberOfYearUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfYearUpdateTB.Location = new System.Drawing.Point(347, 87);
            this.numberOfYearUpdateTB.Name = "numberOfYearUpdateTB";
            this.numberOfYearUpdateTB.Size = new System.Drawing.Size(145, 30);
            this.numberOfYearUpdateTB.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(60, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Количество номеров в год:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(60, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Название:";
            // 
            // nameUpdateTB
            // 
            this.nameUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameUpdateTB.Location = new System.Drawing.Point(223, 50);
            this.nameUpdateTB.Name = "nameUpdateTB";
            this.nameUpdateTB.Size = new System.Drawing.Size(269, 30);
            this.nameUpdateTB.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBox2);
            this.tabPage4.Controls.Add(this.deleteButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(751, 354);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удалить";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(60, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(428, 31);
            this.comboBox2.TabIndex = 15;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightBlue;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(160, 54);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(197, 44);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
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
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // author
            // 
            this.author.HeaderText = "Автор";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // count
            // 
            this.count.HeaderText = "Тираж";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "Цена 1 шт.";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            // 
            // unit_cost
            // 
            this.unit_cost.HeaderText = "Стоимость 1шт.";
            this.unit_cost.Name = "unit_cost";
            this.unit_cost.ReadOnly = true;
            // 
            // total_sale
            // 
            this.total_sale.HeaderText = "Кол-во продаж";
            this.total_sale.Name = "total_sale";
            this.total_sale.ReadOnly = true;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BooksForm";
            this.Text = "Список книг";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox numberOfYearAddTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameAddTB;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox numberOfYearUpdateTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameUpdateTB;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_sale;
    }
}