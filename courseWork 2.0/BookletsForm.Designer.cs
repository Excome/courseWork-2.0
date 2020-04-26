namespace courseWork_2._0
{
    partial class BookletsForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.costAddTB = new System.Windows.Forms.TextBox();
            this.priceAddTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.advertisersAddCombobox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.countAddTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameAddTB = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.bookletsUpdateComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.costUpdateTB = new System.Windows.Forms.TextBox();
            this.priceUpdateTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.advertisersUpdateComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.countUpdateTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nameUpdateTB = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.bookletsDeleteComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advertiser_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceAddLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.totalPriceUpdateLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Список буклетов";
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
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 361);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список буклетов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.advertiser_name,
            this.count,
            this.unit_price,
            this.unit_cost,
            this.total_price});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.totalPriceAddLabel);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.costAddTB);
            this.tabPage2.Controls.Add(this.priceAddTB);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.advertisersAddCombobox);
            this.tabPage2.Controls.Add(this.addButton);
            this.tabPage2.Controls.Add(this.countAddTB);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.nameAddTB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(111, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "Стоимость 1 шт.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(111, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Цена 1 шт.:";
            // 
            // costAddTB
            // 
            this.costAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costAddTB.Location = new System.Drawing.Point(294, 154);
            this.costAddTB.Name = "costAddTB";
            this.costAddTB.Size = new System.Drawing.Size(269, 30);
            this.costAddTB.TabIndex = 33;
            this.costAddTB.Text = "0";
            this.costAddTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costAddTB_KeyPress);
            // 
            // priceAddTB
            // 
            this.priceAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceAddTB.Location = new System.Drawing.Point(294, 118);
            this.priceAddTB.Name = "priceAddTB";
            this.priceAddTB.Size = new System.Drawing.Size(269, 30);
            this.priceAddTB.TabIndex = 32;
            this.priceAddTB.Text = "0";
            this.priceAddTB.TextChanged += new System.EventHandler(this.priceAddTB_TextChanged);
            this.priceAddTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceAddTB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(111, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Рекламодатель:";
            // 
            // advertisersAddCombobox
            // 
            this.advertisersAddCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advertisersAddCombobox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.advertisersAddCombobox.FormattingEnabled = true;
            this.advertisersAddCombobox.Location = new System.Drawing.Point(294, 49);
            this.advertisersAddCombobox.Name = "advertisersAddCombobox";
            this.advertisersAddCombobox.Size = new System.Drawing.Size(269, 27);
            this.advertisersAddCombobox.TabIndex = 30;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(242, 221);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(197, 44);
            this.addButton.TabIndex = 29;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // countAddTB
            // 
            this.countAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countAddTB.Location = new System.Drawing.Point(294, 82);
            this.countAddTB.Name = "countAddTB";
            this.countAddTB.Size = new System.Drawing.Size(269, 30);
            this.countAddTB.TabIndex = 28;
            this.countAddTB.Text = "0";
            this.countAddTB.TextChanged += new System.EventHandler(this.countAddTB_TextChanged);
            this.countAddTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countAddTB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(111, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Тираж:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(111, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Название:";
            // 
            // nameAddTB
            // 
            this.nameAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAddTB.Location = new System.Drawing.Point(294, 13);
            this.nameAddTB.Name = "nameAddTB";
            this.nameAddTB.Size = new System.Drawing.Size(269, 30);
            this.nameAddTB.TabIndex = 25;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.totalPriceUpdateLabel);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.bookletsUpdateComboBox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.costUpdateTB);
            this.tabPage3.Controls.Add(this.priceUpdateTB);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.advertisersUpdateComboBox);
            this.tabPage3.Controls.Add(this.updateButton);
            this.tabPage3.Controls.Add(this.countUpdateTB);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.nameUpdateTB);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(749, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Изменить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(113, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 23);
            this.label12.TabIndex = 49;
            this.label12.Text = "Буклет:";
            // 
            // bookletsUpdateComboBox
            // 
            this.bookletsUpdateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookletsUpdateComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookletsUpdateComboBox.FormattingEnabled = true;
            this.bookletsUpdateComboBox.Location = new System.Drawing.Point(296, 11);
            this.bookletsUpdateComboBox.Name = "bookletsUpdateComboBox";
            this.bookletsUpdateComboBox.Size = new System.Drawing.Size(269, 27);
            this.bookletsUpdateComboBox.TabIndex = 48;
            this.bookletsUpdateComboBox.SelectionChangeCommitted += new System.EventHandler(this.bookletsUpdateComboBox_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(113, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Стоимость 1 шт.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(113, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "Цена 1 шт.:";
            // 
            // costUpdateTB
            // 
            this.costUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costUpdateTB.Location = new System.Drawing.Point(296, 185);
            this.costUpdateTB.Name = "costUpdateTB";
            this.costUpdateTB.Size = new System.Drawing.Size(269, 30);
            this.costUpdateTB.TabIndex = 45;
            this.costUpdateTB.Text = "0";
            this.costUpdateTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costUpdateTB_KeyPress);
            // 
            // priceUpdateTB
            // 
            this.priceUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceUpdateTB.Location = new System.Drawing.Point(296, 149);
            this.priceUpdateTB.Name = "priceUpdateTB";
            this.priceUpdateTB.Size = new System.Drawing.Size(269, 30);
            this.priceUpdateTB.TabIndex = 44;
            this.priceUpdateTB.Text = "0";
            this.priceUpdateTB.TextChanged += new System.EventHandler(this.priceUpdateTB_TextChanged);
            this.priceUpdateTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceUpdateTB_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(113, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 23);
            this.label9.TabIndex = 43;
            this.label9.Text = "Рекламодатель:";
            // 
            // advertisersUpdateComboBox
            // 
            this.advertisersUpdateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advertisersUpdateComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.advertisersUpdateComboBox.FormattingEnabled = true;
            this.advertisersUpdateComboBox.Location = new System.Drawing.Point(296, 80);
            this.advertisersUpdateComboBox.Name = "advertisersUpdateComboBox";
            this.advertisersUpdateComboBox.Size = new System.Drawing.Size(269, 27);
            this.advertisersUpdateComboBox.TabIndex = 42;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightBlue;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(240, 252);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(197, 44);
            this.updateButton.TabIndex = 41;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // countUpdateTB
            // 
            this.countUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countUpdateTB.Location = new System.Drawing.Point(296, 113);
            this.countUpdateTB.Name = "countUpdateTB";
            this.countUpdateTB.Size = new System.Drawing.Size(269, 30);
            this.countUpdateTB.TabIndex = 40;
            this.countUpdateTB.Text = "0";
            this.countUpdateTB.TextChanged += new System.EventHandler(this.countUpdateTB_TextChanged);
            this.countUpdateTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countUpdateTB_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(113, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 23);
            this.label10.TabIndex = 39;
            this.label10.Text = "Тираж:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(113, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 23);
            this.label11.TabIndex = 38;
            this.label11.Text = "Название:";
            // 
            // nameUpdateTB
            // 
            this.nameUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameUpdateTB.Location = new System.Drawing.Point(296, 44);
            this.nameUpdateTB.Name = "nameUpdateTB";
            this.nameUpdateTB.Size = new System.Drawing.Size(269, 30);
            this.nameUpdateTB.TabIndex = 37;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.bookletsDeleteComboBox);
            this.tabPage4.Controls.Add(this.deleteButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(749, 335);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удалить";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(154, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 23);
            this.label13.TabIndex = 51;
            this.label13.Text = "Буклет:";
            // 
            // bookletsDeleteComboBox
            // 
            this.bookletsDeleteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookletsDeleteComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookletsDeleteComboBox.FormattingEnabled = true;
            this.bookletsDeleteComboBox.Location = new System.Drawing.Point(245, 10);
            this.bookletsDeleteComboBox.Name = "bookletsDeleteComboBox";
            this.bookletsDeleteComboBox.Size = new System.Drawing.Size(269, 27);
            this.bookletsDeleteComboBox.TabIndex = 50;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightBlue;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(231, 43);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(197, 44);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Название буклета";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 180;
            // 
            // advertiser_name
            // 
            this.advertiser_name.HeaderText = "Рекламодатель";
            this.advertiser_name.Name = "advertiser_name";
            this.advertiser_name.ReadOnly = true;
            this.advertiser_name.Width = 160;
            // 
            // count
            // 
            this.count.HeaderText = "Тираж";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 80;
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "Цена 1шт.";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            this.unit_price.Width = 80;
            // 
            // unit_cost
            // 
            this.unit_cost.HeaderText = "Стоимость 1шт.";
            this.unit_cost.Name = "unit_cost";
            this.unit_cost.ReadOnly = true;
            this.unit_cost.Width = 80;
            // 
            // total_price
            // 
            this.total_price.HeaderText = "Итоговая цена";
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            this.total_price.Width = 70;
            // 
            // totalPriceAddLabel
            // 
            this.totalPriceAddLabel.AutoSize = true;
            this.totalPriceAddLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPriceAddLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPriceAddLabel.Location = new System.Drawing.Point(351, 187);
            this.totalPriceAddLabel.Name = "totalPriceAddLabel";
            this.totalPriceAddLabel.Padding = new System.Windows.Forms.Padding(3);
            this.totalPriceAddLabel.Size = new System.Drawing.Size(30, 31);
            this.totalPriceAddLabel.TabIndex = 38;
            this.totalPriceAddLabel.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(111, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(227, 23);
            this.label16.TabIndex = 37;
            this.label16.Text = "Итоговая цена (руб.):";
            // 
            // totalPriceUpdateLabel
            // 
            this.totalPriceUpdateLabel.AutoSize = true;
            this.totalPriceUpdateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPriceUpdateLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPriceUpdateLabel.Location = new System.Drawing.Point(346, 218);
            this.totalPriceUpdateLabel.Name = "totalPriceUpdateLabel";
            this.totalPriceUpdateLabel.Padding = new System.Windows.Forms.Padding(3);
            this.totalPriceUpdateLabel.Size = new System.Drawing.Size(30, 31);
            this.totalPriceUpdateLabel.TabIndex = 51;
            this.totalPriceUpdateLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(113, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(227, 23);
            this.label15.TabIndex = 50;
            this.label15.Text = "Итоговая цена (руб.):";
            // 
            // BookletsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BookletsForm";
            this.Text = "Список буклетов";
            this.Load += new System.EventHandler(this.BookletsForm_Load);
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox costAddTB;
        private System.Windows.Forms.TextBox priceAddTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox advertisersAddCombobox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox countAddTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameAddTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox bookletsUpdateComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox costUpdateTB;
        private System.Windows.Forms.TextBox priceUpdateTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox advertisersUpdateComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox countUpdateTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nameUpdateTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox bookletsDeleteComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn advertiser_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.Label totalPriceAddLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label totalPriceUpdateLabel;
        private System.Windows.Forms.Label label15;
    }
}