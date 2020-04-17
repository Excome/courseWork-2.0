namespace courseWork_2._0
{
    partial class ContractsForm
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
            this.name_periodical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_number_periodical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_first_page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_normal_page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_last_page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_advertiser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.totalPriceAddLabel = new System.Windows.Forms.Label();
            this.advertiserAddCombobox = new System.Windows.Forms.ComboBox();
            this.numberAddCombobox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vLastPageAddTB = new System.Windows.Forms.TextBox();
            this.vNormalPageAddTB = new System.Windows.Forms.TextBox();
            this.vFirstPageAddTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameAddCombobox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.advertiserUpdateTB = new System.Windows.Forms.TextBox();
            this.numberUpdateTB = new System.Windows.Forms.TextBox();
            this.nameUpdateTB = new System.Windows.Forms.TextBox();
            this.contractsUpdateCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPriceUpdateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.vLastPageUpdateTB = new System.Windows.Forms.TextBox();
            this.vNormalPageUpdateTB = new System.Windows.Forms.TextBox();
            this.vFirstPageUpdateTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.deleteCombobox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список контрактов";
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
            this.tabControl1.Size = new System.Drawing.Size(888, 413);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список контрактов";
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
            this.name_periodical,
            this.id_number_periodical,
            this.v_first_page,
            this.v_normal_page,
            this.v_last_page,
            this.id_advertiser,
            this.total_price});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(874, 381);
            this.dataGridView1.TabIndex = 0;
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
            // name_periodical
            // 
            this.name_periodical.HeaderText = "Название издания";
            this.name_periodical.Name = "name_periodical";
            this.name_periodical.ReadOnly = true;
            this.name_periodical.Width = 150;
            // 
            // id_number_periodical
            // 
            this.id_number_periodical.HeaderText = "Номер издания";
            this.id_number_periodical.Name = "id_number_periodical";
            this.id_number_periodical.ReadOnly = true;
            this.id_number_periodical.Width = 70;
            // 
            // v_first_page
            // 
            this.v_first_page.HeaderText = "Объем первой стр.";
            this.v_first_page.Name = "v_first_page";
            this.v_first_page.ReadOnly = true;
            // 
            // v_normal_page
            // 
            this.v_normal_page.HeaderText = "Объем обычных стр.";
            this.v_normal_page.Name = "v_normal_page";
            this.v_normal_page.ReadOnly = true;
            // 
            // v_last_page
            // 
            this.v_last_page.HeaderText = "Объем последней стр.";
            this.v_last_page.Name = "v_last_page";
            this.v_last_page.ReadOnly = true;
            this.v_last_page.Width = 110;
            // 
            // id_advertiser
            // 
            this.id_advertiser.HeaderText = "Рекламодатель";
            this.id_advertiser.Name = "id_advertiser";
            this.id_advertiser.ReadOnly = true;
            this.id_advertiser.Width = 150;
            // 
            // total_price
            // 
            this.total_price.HeaderText = "Итоговая цена";
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.totalPriceAddLabel);
            this.tabPage2.Controls.Add(this.advertiserAddCombobox);
            this.tabPage2.Controls.Add(this.numberAddCombobox);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.vLastPageAddTB);
            this.tabPage2.Controls.Add(this.vNormalPageAddTB);
            this.tabPage2.Controls.Add(this.vFirstPageAddTB);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.nameAddCombobox);
            this.tabPage2.Controls.Add(this.addButton);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // totalPriceAddLabel
            // 
            this.totalPriceAddLabel.AutoSize = true;
            this.totalPriceAddLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPriceAddLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPriceAddLabel.Location = new System.Drawing.Point(524, 224);
            this.totalPriceAddLabel.Name = "totalPriceAddLabel";
            this.totalPriceAddLabel.Padding = new System.Windows.Forms.Padding(3);
            this.totalPriceAddLabel.Size = new System.Drawing.Size(30, 31);
            this.totalPriceAddLabel.TabIndex = 27;
            this.totalPriceAddLabel.Text = "0";
            // 
            // advertiserAddCombobox
            // 
            this.advertiserAddCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advertiserAddCombobox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.advertiserAddCombobox.FormattingEnabled = true;
            this.advertiserAddCombobox.Location = new System.Drawing.Point(387, 80);
            this.advertiserAddCombobox.Name = "advertiserAddCombobox";
            this.advertiserAddCombobox.Size = new System.Drawing.Size(269, 31);
            this.advertiserAddCombobox.TabIndex = 26;
            // 
            // numberAddCombobox
            // 
            this.numberAddCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberAddCombobox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberAddCombobox.FormattingEnabled = true;
            this.numberAddCombobox.Location = new System.Drawing.Point(387, 43);
            this.numberAddCombobox.Name = "numberAddCombobox";
            this.numberAddCombobox.Size = new System.Drawing.Size(269, 31);
            this.numberAddCombobox.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(205, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(227, 23);
            this.label16.TabIndex = 24;
            this.label16.Text = "Итоговая цена (руб.):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(206, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Объём последней стр. (см^2):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(206, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Объём обычной стр. (см^2):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(204, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Объём первой стр. (см^2):";
            // 
            // vLastPageAddTB
            // 
            this.vLastPageAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vLastPageAddTB.Location = new System.Drawing.Point(524, 189);
            this.vLastPageAddTB.Name = "vLastPageAddTB";
            this.vLastPageAddTB.Size = new System.Drawing.Size(132, 30);
            this.vLastPageAddTB.TabIndex = 19;
            this.vLastPageAddTB.Text = "0";
            this.vLastPageAddTB.TextChanged += new System.EventHandler(this.vLastPageAddTB_TextChanged);
            this.vLastPageAddTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vLastPageAddTB_KeyPress);
            // 
            // vNormalPageAddTB
            // 
            this.vNormalPageAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vNormalPageAddTB.Location = new System.Drawing.Point(524, 153);
            this.vNormalPageAddTB.Name = "vNormalPageAddTB";
            this.vNormalPageAddTB.Size = new System.Drawing.Size(132, 30);
            this.vNormalPageAddTB.TabIndex = 18;
            this.vNormalPageAddTB.Text = "0";
            this.vNormalPageAddTB.TextChanged += new System.EventHandler(this.vNormalPageAddTB_TextChanged);
            this.vNormalPageAddTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vNormalPageAddTB_KeyPress);
            // 
            // vFirstPageAddTB
            // 
            this.vFirstPageAddTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vFirstPageAddTB.Location = new System.Drawing.Point(524, 117);
            this.vFirstPageAddTB.Name = "vFirstPageAddTB";
            this.vFirstPageAddTB.Size = new System.Drawing.Size(132, 30);
            this.vFirstPageAddTB.TabIndex = 17;
            this.vFirstPageAddTB.Text = "0";
            this.vFirstPageAddTB.TextChanged += new System.EventHandler(this.vFristPageAddTB_TextChanged);
            this.vFirstPageAddTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vFristPageAddTB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(206, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Номер:";
            // 
            // nameAddCombobox
            // 
            this.nameAddCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameAddCombobox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAddCombobox.FormattingEnabled = true;
            this.nameAddCombobox.Location = new System.Drawing.Point(387, 6);
            this.nameAddCombobox.Name = "nameAddCombobox";
            this.nameAddCombobox.Size = new System.Drawing.Size(269, 31);
            this.nameAddCombobox.TabIndex = 15;
            this.nameAddCombobox.SelectionChangeCommitted += new System.EventHandler(this.nameAddCombobox_SelectionChangeCommitted);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(324, 269);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(197, 44);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(206, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Рекламодатель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(206, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Издание:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.advertiserUpdateTB);
            this.tabPage3.Controls.Add(this.numberUpdateTB);
            this.tabPage3.Controls.Add(this.nameUpdateTB);
            this.tabPage3.Controls.Add(this.contractsUpdateCombobox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.totalPriceUpdateLabel);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.vLastPageUpdateTB);
            this.tabPage3.Controls.Add(this.vNormalPageUpdateTB);
            this.tabPage3.Controls.Add(this.vFirstPageUpdateTB);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.updateButton);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(880, 387);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Изменить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // advertiserUpdateTB
            // 
            this.advertiserUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.advertiserUpdateTB.Location = new System.Drawing.Point(399, 115);
            this.advertiserUpdateTB.Name = "advertiserUpdateTB";
            this.advertiserUpdateTB.ReadOnly = true;
            this.advertiserUpdateTB.Size = new System.Drawing.Size(257, 30);
            this.advertiserUpdateTB.TabIndex = 47;
            // 
            // numberUpdateTB
            // 
            this.numberUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberUpdateTB.Location = new System.Drawing.Point(399, 79);
            this.numberUpdateTB.Name = "numberUpdateTB";
            this.numberUpdateTB.ReadOnly = true;
            this.numberUpdateTB.Size = new System.Drawing.Size(257, 30);
            this.numberUpdateTB.TabIndex = 46;
            // 
            // nameUpdateTB
            // 
            this.nameUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameUpdateTB.Location = new System.Drawing.Point(399, 43);
            this.nameUpdateTB.Name = "nameUpdateTB";
            this.nameUpdateTB.ReadOnly = true;
            this.nameUpdateTB.Size = new System.Drawing.Size(257, 30);
            this.nameUpdateTB.TabIndex = 45;
            // 
            // contractsUpdateCombobox
            // 
            this.contractsUpdateCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contractsUpdateCombobox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractsUpdateCombobox.FormattingEnabled = true;
            this.contractsUpdateCombobox.Location = new System.Drawing.Point(399, 6);
            this.contractsUpdateCombobox.Name = "contractsUpdateCombobox";
            this.contractsUpdateCombobox.Size = new System.Drawing.Size(257, 31);
            this.contractsUpdateCombobox.TabIndex = 44;
            this.contractsUpdateCombobox.SelectionChangeCommitted += new System.EventHandler(this.contractsUpdateCombobox_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(206, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Номер контракта:";
            // 
            // totalPriceUpdateLabel
            // 
            this.totalPriceUpdateLabel.AutoSize = true;
            this.totalPriceUpdateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPriceUpdateLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPriceUpdateLabel.Location = new System.Drawing.Point(524, 256);
            this.totalPriceUpdateLabel.Name = "totalPriceUpdateLabel";
            this.totalPriceUpdateLabel.Padding = new System.Windows.Forms.Padding(3);
            this.totalPriceUpdateLabel.Size = new System.Drawing.Size(30, 31);
            this.totalPriceUpdateLabel.TabIndex = 42;
            this.totalPriceUpdateLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(206, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Итоговая цена (руб.):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(206, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(312, 23);
            this.label10.TabIndex = 38;
            this.label10.Text = "Объём последней стр. (см^2):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(206, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(296, 23);
            this.label11.TabIndex = 37;
            this.label11.Text = "Объём обычной стр. (см^2):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(206, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(279, 23);
            this.label12.TabIndex = 36;
            this.label12.Text = "Объём первой стр. (см^2):";
            // 
            // vLastPageUpdateTB
            // 
            this.vLastPageUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vLastPageUpdateTB.Location = new System.Drawing.Point(524, 223);
            this.vLastPageUpdateTB.Name = "vLastPageUpdateTB";
            this.vLastPageUpdateTB.Size = new System.Drawing.Size(132, 30);
            this.vLastPageUpdateTB.TabIndex = 35;
            this.vLastPageUpdateTB.Text = "0";
            this.vLastPageUpdateTB.TextChanged += new System.EventHandler(this.vLastPageUpdateTB_TextChanged);
            this.vLastPageUpdateTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vLastPageUpdateTB_KeyPress);
            // 
            // vNormalPageUpdateTB
            // 
            this.vNormalPageUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vNormalPageUpdateTB.Location = new System.Drawing.Point(524, 187);
            this.vNormalPageUpdateTB.Name = "vNormalPageUpdateTB";
            this.vNormalPageUpdateTB.Size = new System.Drawing.Size(132, 30);
            this.vNormalPageUpdateTB.TabIndex = 34;
            this.vNormalPageUpdateTB.Text = "0";
            this.vNormalPageUpdateTB.TextChanged += new System.EventHandler(this.vNormalPageUpdateTB_TextChanged);
            this.vNormalPageUpdateTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vNormalPageUpdateTB_KeyPress);
            // 
            // vFirstPageUpdateTB
            // 
            this.vFirstPageUpdateTB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vFirstPageUpdateTB.Location = new System.Drawing.Point(524, 151);
            this.vFirstPageUpdateTB.Name = "vFirstPageUpdateTB";
            this.vFirstPageUpdateTB.Size = new System.Drawing.Size(132, 30);
            this.vFirstPageUpdateTB.TabIndex = 33;
            this.vFirstPageUpdateTB.Text = "0";
            this.vFirstPageUpdateTB.TextChanged += new System.EventHandler(this.vFirstPageUpdateTB_TextChanged);
            this.vFirstPageUpdateTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vFirstUpdateAddTB_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(206, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 23);
            this.label13.TabIndex = 32;
            this.label13.Text = "Номер:";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightBlue;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(321, 301);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(197, 44);
            this.updateButton.TabIndex = 30;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(206, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 23);
            this.label17.TabIndex = 29;
            this.label17.Text = "Рекламодатель:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(206, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 28;
            this.label18.Text = "Издание:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.deleteCombobox);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.deleteButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(880, 387);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удалить";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // deleteCombobox
            // 
            this.deleteCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteCombobox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteCombobox.FormattingEnabled = true;
            this.deleteCombobox.Location = new System.Drawing.Point(435, 16);
            this.deleteCombobox.Name = "deleteCombobox";
            this.deleteCombobox.Size = new System.Drawing.Size(200, 27);
            this.deleteCombobox.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(236, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(193, 23);
            this.label15.TabIndex = 37;
            this.label15.Text = "Номер контракта: ";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightBlue;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(325, 49);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(197, 44);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ContractsForm";
            this.Text = "Список контрактов";
            this.Load += new System.EventHandler(this.ContractsForm_Load);
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vLastPageAddTB;
        private System.Windows.Forms.TextBox vNormalPageAddTB;
        private System.Windows.Forms.TextBox vFirstPageAddTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox nameAddCombobox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox deleteCombobox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox advertiserAddCombobox;
        private System.Windows.Forms.ComboBox numberAddCombobox;
        private System.Windows.Forms.Label totalPriceAddLabel;
        private System.Windows.Forms.Label totalPriceUpdateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox vLastPageUpdateTB;
        private System.Windows.Forms.TextBox vNormalPageUpdateTB;
        private System.Windows.Forms.TextBox vFirstPageUpdateTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox contractsUpdateCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_periodical;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_number_periodical;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_first_page;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_normal_page;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_last_page;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_advertiser;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.TextBox advertiserUpdateTB;
        private System.Windows.Forms.TextBox numberUpdateTB;
        private System.Windows.Forms.TextBox nameUpdateTB;
    }
}