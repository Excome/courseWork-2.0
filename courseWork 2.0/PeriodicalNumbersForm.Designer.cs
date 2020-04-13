namespace courseWork_2._0
{
    partial class PeriodicalNumbersForm
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_periodical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_periodical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advertising_cm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.advertAddTB = new System.Windows.Forms.TextBox();
            this.costAddTB = new System.Windows.Forms.TextBox();
            this.priceAddTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addCombobox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.countAddTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberAddTB = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.advertUpdateTB = new System.Windows.Forms.TextBox();
            this.costUpdateTB = new System.Windows.Forms.TextBox();
            this.priceUpdateTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.updateCombobox1 = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.countUpdateTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.updateCombobox2 = new System.Windows.Forms.ComboBox();
            this.deleteComboBox2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.deleteComboBox1 = new System.Windows.Forms.ComboBox();
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
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номера изданий";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 380);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список изданий";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(3, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(551, 27);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name_periodical,
            this.id_periodical,
            this.number,
            this.count,
            this.unit_price,
            this.unit_cost,
            this.advertising_cm});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(548, 319);
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
            // name_periodical
            // 
            this.name_periodical.Frozen = true;
            this.name_periodical.HeaderText = "Название";
            this.name_periodical.Name = "name_periodical";
            this.name_periodical.ReadOnly = true;
            this.name_periodical.Width = 150;
            // 
            // id_periodical
            // 
            this.id_periodical.Frozen = true;
            this.id_periodical.HeaderText = "ID Изд.";
            this.id_periodical.Name = "id_periodical";
            this.id_periodical.ReadOnly = true;
            this.id_periodical.Width = 50;
            // 
            // number
            // 
            this.number.HeaderText = "Номер";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 50;
            // 
            // count
            // 
            this.count.HeaderText = "Тираж";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 70;
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "Цена 1 экз.";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            this.unit_price.Width = 70;
            // 
            // unit_cost
            // 
            this.unit_cost.HeaderText = "Стоимость 1 экз.";
            this.unit_cost.Name = "unit_cost";
            this.unit_cost.ReadOnly = true;
            this.unit_cost.Width = 70;
            // 
            // advertising_cm
            // 
            this.advertising_cm.HeaderText = "Реклама 1см^2";
            this.advertising_cm.Name = "advertising_cm";
            this.advertising_cm.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.advertAddTB);
            this.tabPage2.Controls.Add(this.costAddTB);
            this.tabPage2.Controls.Add(this.priceAddTB);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.addCombobox);
            this.tabPage2.Controls.Add(this.addButton);
            this.tabPage2.Controls.Add(this.countAddTB);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numberAddTB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(49, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Реклама 1см^2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(49, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Стоимость 1 шт.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(49, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Цена 1 шт.:";
            // 
            // advertAddTB
            // 
            this.advertAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.advertAddTB.Location = new System.Drawing.Point(232, 195);
            this.advertAddTB.Name = "advertAddTB";
            this.advertAddTB.Size = new System.Drawing.Size(269, 30);
            this.advertAddTB.TabIndex = 19;
            this.advertAddTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.advertAddTB_KeyPress);
            // 
            // costAddTB
            // 
            this.costAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costAddTB.Location = new System.Drawing.Point(232, 159);
            this.costAddTB.Name = "costAddTB";
            this.costAddTB.Size = new System.Drawing.Size(269, 30);
            this.costAddTB.TabIndex = 18;
            this.costAddTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costAddTB_KeyPress);
            // 
            // priceAddTB
            // 
            this.priceAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceAddTB.Location = new System.Drawing.Point(232, 123);
            this.priceAddTB.Name = "priceAddTB";
            this.priceAddTB.Size = new System.Drawing.Size(269, 30);
            this.priceAddTB.TabIndex = 17;
            this.priceAddTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceAddTB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(49, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Номер:";
            // 
            // addCombobox
            // 
            this.addCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCombobox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCombobox.FormattingEnabled = true;
            this.addCombobox.Location = new System.Drawing.Point(232, 18);
            this.addCombobox.Name = "addCombobox";
            this.addCombobox.Size = new System.Drawing.Size(269, 27);
            this.addCombobox.TabIndex = 15;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(164, 240);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(197, 44);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // countAddTB
            // 
            this.countAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countAddTB.Location = new System.Drawing.Point(232, 87);
            this.countAddTB.Name = "countAddTB";
            this.countAddTB.Size = new System.Drawing.Size(269, 30);
            this.countAddTB.TabIndex = 3;
            this.countAddTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countAddTB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тираж:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Издание:";
            // 
            // numberAddTB
            // 
            this.numberAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberAddTB.Location = new System.Drawing.Point(232, 51);
            this.numberAddTB.Name = "numberAddTB";
            this.numberAddTB.Size = new System.Drawing.Size(269, 30);
            this.numberAddTB.TabIndex = 0;
            this.numberAddTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberAddTB_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.updateCombobox2);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.advertUpdateTB);
            this.tabPage3.Controls.Add(this.costUpdateTB);
            this.tabPage3.Controls.Add(this.priceUpdateTB);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.updateCombobox1);
            this.tabPage3.Controls.Add(this.updateButton);
            this.tabPage3.Controls.Add(this.countUpdateTB);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(554, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Изменить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.deleteComboBox2);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.deleteComboBox1);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.deleteButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(554, 354);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удалить";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightBlue;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(175, 83);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(197, 44);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(51, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Реклама 1см^2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(51, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Стоимость 1 шт.:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(51, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "Цена 1 шт.:";
            // 
            // advertUpdateTB
            // 
            this.advertUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.advertUpdateTB.Location = new System.Drawing.Point(234, 200);
            this.advertUpdateTB.Name = "advertUpdateTB";
            this.advertUpdateTB.Size = new System.Drawing.Size(269, 30);
            this.advertUpdateTB.TabIndex = 32;
            this.advertUpdateTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.advertUpdateTB_KeyPress);
            // 
            // costUpdateTB
            // 
            this.costUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costUpdateTB.Location = new System.Drawing.Point(234, 164);
            this.costUpdateTB.Name = "costUpdateTB";
            this.costUpdateTB.Size = new System.Drawing.Size(269, 30);
            this.costUpdateTB.TabIndex = 31;
            this.costUpdateTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costUpdateTB_KeyPress);
            // 
            // priceUpdateTB
            // 
            this.priceUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceUpdateTB.Location = new System.Drawing.Point(234, 128);
            this.priceUpdateTB.Name = "priceUpdateTB";
            this.priceUpdateTB.Size = new System.Drawing.Size(269, 30);
            this.priceUpdateTB.TabIndex = 30;
            this.priceUpdateTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceUpdateTB_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(51, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Номер:";
            // 
            // updateCombobox1
            // 
            this.updateCombobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateCombobox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateCombobox1.FormattingEnabled = true;
            this.updateCombobox1.Location = new System.Drawing.Point(234, 23);
            this.updateCombobox1.Name = "updateCombobox1";
            this.updateCombobox1.Size = new System.Drawing.Size(269, 27);
            this.updateCombobox1.TabIndex = 28;
            this.updateCombobox1.SelectionChangeCommitted += new System.EventHandler(this.updateCombobox1_SelectionChangeCommitted);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightBlue;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(166, 245);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(197, 44);
            this.updateButton.TabIndex = 27;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // countUpdateTB
            // 
            this.countUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countUpdateTB.Location = new System.Drawing.Point(234, 92);
            this.countUpdateTB.Name = "countUpdateTB";
            this.countUpdateTB.Size = new System.Drawing.Size(269, 30);
            this.countUpdateTB.TabIndex = 26;
            this.countUpdateTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countUpdateTB_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(51, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 23);
            this.label12.TabIndex = 25;
            this.label12.Text = "Тираж:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(51, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "Издание:";
            // 
            // updateCombobox2
            // 
            this.updateCombobox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateCombobox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateCombobox2.FormattingEnabled = true;
            this.updateCombobox2.Location = new System.Drawing.Point(234, 59);
            this.updateCombobox2.Name = "updateCombobox2";
            this.updateCombobox2.Size = new System.Drawing.Size(269, 27);
            this.updateCombobox2.TabIndex = 36;
            this.updateCombobox2.SelectionChangeCommitted += new System.EventHandler(this.updateCombobox2_SelectionChangeCommitted);
            // 
            // deleteComboBox2
            // 
            this.deleteComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteComboBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteComboBox2.FormattingEnabled = true;
            this.deleteComboBox2.Location = new System.Drawing.Point(199, 50);
            this.deleteComboBox2.Name = "deleteComboBox2";
            this.deleteComboBox2.Size = new System.Drawing.Size(269, 27);
            this.deleteComboBox2.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(80, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 23);
            this.label14.TabIndex = 39;
            this.label14.Text = "Номер:";
            // 
            // deleteComboBox1
            // 
            this.deleteComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteComboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteComboBox1.FormattingEnabled = true;
            this.deleteComboBox1.Location = new System.Drawing.Point(199, 14);
            this.deleteComboBox1.Name = "deleteComboBox1";
            this.deleteComboBox1.Size = new System.Drawing.Size(269, 27);
            this.deleteComboBox1.TabIndex = 38;
            this.deleteComboBox1.SelectionChangeCommitted += new System.EventHandler(this.deleteComboBox1_SelectionChangeCommitted);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(80, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 37;
            this.label15.Text = "Издание:";
            // 
            // PeriodicalNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "PeriodicalNumbersForm";
            this.Text = "Номера издания";
            this.Load += new System.EventHandler(this.PeriodicalNumbersForm_Load);
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
        private System.Windows.Forms.TextBox countAddTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberAddTB;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_periodical;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_periodical;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn advertising_cm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox advertAddTB;
        private System.Windows.Forms.TextBox costAddTB;
        private System.Windows.Forms.TextBox priceAddTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addCombobox;
        private System.Windows.Forms.ComboBox updateCombobox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox advertUpdateTB;
        private System.Windows.Forms.TextBox costUpdateTB;
        private System.Windows.Forms.TextBox priceUpdateTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox updateCombobox1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox countUpdateTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox deleteComboBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox deleteComboBox1;
        private System.Windows.Forms.Label label15;
    }
}