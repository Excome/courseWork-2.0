using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseWork_2._0
{
    public partial class ContractsForm : Form
    {
        MainForm MainForm;

        public ContractsForm(MainForm MainForm)
        {
            this.MainForm = MainForm;
            InitializeComponent();
        }

        SqlConnection sqlConnection;

        private void ContractsForm_Load(object sender, EventArgs e)
        {
            sqlConnection = MainForm.sqlConnection;
            LoadDataTable();
        }

        private void LoadDataTable()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand command = new SqlCommand("USE typography; " +
                "SELECT " +
                "Contracts.id, Periodical_Numbers.name_periodical, " +
                "Periodical_Numbers.number, Contracts.v_first_page, Contracts.v_normal_page, Contracts.v_last_page, " +
                "Advertisers.name, Contracts.total_price " +
                "FROM Contracts " +
                "JOIN Periodical_Numbers ON Contracts.id_number_periodical = Periodical_Numbers.id " +
                "JOIN Advertisers ON Contracts.id_advertiser = Advertisers.id " +
                "ORDER BY Contracts.id", sqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (dataReader.Read())
            {
                data.Add(new string[8]);
                data[data.Count - 1][0] = dataReader[0].ToString();
                data[data.Count - 1][1] = dataReader[1].ToString();
                data[data.Count - 1][2] = dataReader[2].ToString();
                data[data.Count - 1][3] = dataReader[3].ToString();
                data[data.Count - 1][4] = dataReader[4].ToString();
                data[data.Count - 1][5] = dataReader[5].ToString();
                data[data.Count - 1][6] = dataReader[6].ToString();
                data[data.Count - 1][7] = dataReader[7].ToString();
            }
            dataReader.Close();
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            foreach (string[] dataElement in data)
            {
                dataGridView1.Rows.Add(dataElement);
            }
        }

        private void LoadPeriodicalNameComboBox(ComboBox cb)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Periodicals ORDER BY[id]", sqlConnection);
            DataSet comboboxDataSet = new DataSet();
            sqlAdapter.Fill(comboboxDataSet);
            DataTable comboboxDataTable = comboboxDataSet.Tables[0];
            cb.DataSource = comboboxDataTable;
            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        private void LoadPeriodicalNumbersComboBox(ComboBox cb1, ComboBox cb2)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand command = new SqlCommand("SELECT * FROM Periodical_Numbers WHERE [id_periodical]=@id_periodical", sqlConnection);
            command.Parameters.AddWithValue("id_periodical", cb1.SelectedValue);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            DataSet comboboxDataSet = new DataSet();
            sqlAdapter.Fill(comboboxDataSet);
            DataTable comboboxDataTable = comboboxDataSet.Tables[0];
            cb2.DataSource = comboboxDataTable;
            cb2.DisplayMember = "number";
            cb2.ValueMember = "id";
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        private void LoadAdvertisersComboBox(ComboBox cb)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Advertisers ORDER BY[id]", sqlConnection);
            DataSet comboboxDataSet = new DataSet();
            sqlAdapter.Fill(comboboxDataSet);
            DataTable comboboxDataTable = comboboxDataSet.Tables[0];
            cb.DataSource = comboboxDataTable;
            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        private void LoadContractsNumberComboBox(ComboBox cb)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Contracts ORDER BY[id]", sqlConnection);
            DataSet comboboxDataSet = new DataSet();
            sqlAdapter.Fill(comboboxDataSet);
            DataTable comboboxDataTable = comboboxDataSet.Tables[0];
            cb.DataSource = comboboxDataTable;
            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                dataGridView1.Rows.Clear();
                LoadDataTable();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                LoadPeriodicalNameComboBox(nameAddCombobox);
                LoadAdvertisersComboBox(advertiserAddCombobox);
            }
            if (tabControl1.SelectedIndex == 2)
            {
                LoadContractsNumberComboBox(contractsUpdateCombobox);
            }
            if(tabControl1.SelectedIndex == 3)
            {
                LoadContractsNumberComboBox(deleteCombobox);
            }
        }

        private void vFristPageAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void vNormalPageAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void vLastPageAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private double CountTotalPrice(TextBox tb1, TextBox tb2, TextBox tb3)
        {
            int vFirst = Convert.ToInt32(tb1.Text);
            int vNormal = Convert.ToInt32(tb2.Text);
            int vLast = Convert.ToInt32(tb3.Text);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT [advertising_cm] FROM Periodical_Numbers WHERE [id]=@id", sqlConnection);
            cmd.Parameters.AddWithValue("id", numberAddCombobox.SelectedValue);
            int price = (Int32)cmd.ExecuteScalar();
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            double totalPrice = (double)(2.5 * vFirst * price) + (vNormal * price) + (1.8 * vLast * price);
            return totalPrice;
        }

        private void vFristPageAddTB_TextChanged(object sender, EventArgs e)
        {
            if (vFirstPageAddTB.Text == "" || vFirstPageAddTB.Text == null)
            {
                vFirstPageAddTB.Text = "0";
            }
            totalPriceAddLabel.Text = Convert.ToString(CountTotalPrice(vFirstPageAddTB, vNormalPageAddTB, vLastPageAddTB));
        }

        private void vNormalPageAddTB_TextChanged(object sender, EventArgs e)
        {
            if (vNormalPageAddTB.Text == "" || vNormalPageAddTB.Text == null)
            {
                vNormalPageAddTB.Text = "0";
            }
            totalPriceAddLabel.Text = Convert.ToString(CountTotalPrice(vFirstPageAddTB, vNormalPageAddTB, vLastPageAddTB));
        }

        private void vLastPageAddTB_TextChanged(object sender, EventArgs e)
        {
            if (vLastPageAddTB.Text == "" || vLastPageAddTB.Text == null)
            {
                vLastPageAddTB.Text = "0";
            }
            totalPriceAddLabel.Text = Convert.ToString(CountTotalPrice(vFirstPageAddTB, vNormalPageAddTB, vLastPageAddTB));
        }

        private void nameAddCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadPeriodicalNumbersComboBox(nameAddCombobox, numberAddCombobox);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand command = new SqlCommand("INSERT INTO [Contracts] (id_number_periodical, v_first_page, v_normal_page, v_last_page, " +
                    "total_price, id_advertiser)VALUES(@id_number_periodical, @v_first_page, @v_normal_page, @v_last_page, @total_price, " +
                    "@id_advertiser)", sqlConnection);
                command.Parameters.AddWithValue("id_number_periodical", Convert.ToInt32(numberAddCombobox.SelectedValue));
                command.Parameters.AddWithValue("v_first_page", Convert.ToInt32(vFirstPageAddTB.Text));
                command.Parameters.AddWithValue("v_normal_page", Convert.ToInt32(vNormalPageAddTB.Text));
                command.Parameters.AddWithValue("v_last_page", Convert.ToInt32(vLastPageAddTB.Text));
                command.Parameters.AddWithValue("total_price", Convert.ToInt32(totalPriceAddLabel.Text));
                command.Parameters.AddWithValue("id_advertiser", Convert.ToInt32(advertiserAddCombobox.SelectedValue));
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void vFirstUpdateAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void vNormalPageUpdateTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void vLastPageUpdateTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        int advertising_cm;

        private void contractsUpdateCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM [Contracts] " +
                    "JOIN Periodical_Numbers ON Contracts.id_number_periodical = Periodical_Numbers.id " +
                    "JOIN Advertisers ON Contracts.id_advertiser = Advertisers.id " +
                    "WHERE Contracts.id=@id", sqlConnection);
                command.Parameters.AddWithValue("id", contractsUpdateCombobox.SelectedValue);
                SqlDataReader sqlReader = command.ExecuteReader();
                sqlReader.Read();
                nameUpdateTB.Text = Convert.ToString(sqlReader["name_periodical"]);
                numberUpdateTB.Text = Convert.ToString(sqlReader["number"]);
                advertiserUpdateTB.Text = Convert.ToString(sqlReader["name"]);
                vFirstPageUpdateTB.Text = Convert.ToString(sqlReader["v_first_page"]);
                vNormalPageUpdateTB.Text = Convert.ToString(sqlReader["v_normal_page"]);
                vLastPageUpdateTB.Text = Convert.ToString(sqlReader["v_last_page"]);
                totalPriceUpdateLabel.Text = Convert.ToString(sqlReader["total_price"]);
                advertising_cm = (int)sqlReader["advertising_cm"];
                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) 
                { 
                    sqlConnection.Close(); 
                }
            }
        }
        private double CountPriceUpdate(TextBox tb1, TextBox tb2, TextBox tb3)
        {
            int vFirst = Convert.ToInt32(tb1.Text);
            int vNormal = Convert.ToInt32(tb2.Text);
            int vLast = Convert.ToInt32(tb3.Text);
            double totalPrice = (double)(2.5 * vFirst * advertising_cm) + (vNormal * advertising_cm) + (1.8 * vLast * advertising_cm);
            return totalPrice;
        }

        private void vFirstPageUpdateTB_TextChanged(object sender, EventArgs e)
         {
             if (vFirstPageUpdateTB.Text == "" || vFirstPageUpdateTB.Text == null)
             {
                 vFirstPageUpdateTB.Text = "0";
             }
             totalPriceUpdateLabel.Text = Convert.ToString(CountPriceUpdate(vFirstPageUpdateTB, vNormalPageUpdateTB, vLastPageUpdateTB));
         }

         private void vNormalPageUpdateTB_TextChanged(object sender, EventArgs e)
         {
             if (vNormalPageUpdateTB.Text == "" || vNormalPageUpdateTB.Text == null)
             {
                 vNormalPageUpdateTB.Text = "0";
             }
             totalPriceUpdateLabel.Text = Convert.ToString(CountPriceUpdate(vFirstPageUpdateTB, vNormalPageUpdateTB, vLastPageUpdateTB));
         }

         private void vLastPageUpdateTB_TextChanged(object sender, EventArgs e)
         {
             if (vLastPageUpdateTB.Text == "" || vLastPageUpdateTB.Text == null)
             {
                 vLastPageUpdateTB.Text = "0";
             }
             totalPriceUpdateLabel.Text = Convert.ToString(CountPriceUpdate(vFirstPageUpdateTB, vNormalPageUpdateTB, vLastPageUpdateTB));
         }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE [Contracts] SET [v_first_page]=@v_first_page, " +
                    "[v_normal_page]=@v_normal_page, [v_last_page]=@v_last_page, [total_price]=@total_price " +
                    "WHERE [id]=@id", sqlConnection);
                command.Parameters.AddWithValue("id", contractsUpdateCombobox.SelectedValue);
                command.Parameters.AddWithValue("v_first_page", Convert.ToInt32(vFirstPageUpdateTB.Text));
                command.Parameters.AddWithValue("v_normal_page", Convert.ToInt32(vNormalPageUpdateTB.Text));
                command.Parameters.AddWithValue("v_last_page", Convert.ToInt32(vLastPageUpdateTB.Text));
                command.Parameters.AddWithValue("total_price", Convert.ToInt32(totalPriceUpdateLabel.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Изменения успешно внесены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand command = new SqlCommand("DELETE FROM [Contracts] WHERE [id]=@id", sqlConnection);
                command.Parameters.AddWithValue("id", deleteCombobox.SelectedValue);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadContractsNumberComboBox(deleteCombobox);
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
