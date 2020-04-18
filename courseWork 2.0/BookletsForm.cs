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
    public partial class BookletsForm : Form
    {
        MainForm MainForm;

        public BookletsForm(MainForm MainForm)
        {
            this.MainForm = MainForm;
            InitializeComponent();
        }

        SqlConnection sqlConnection;

        private void BookletsForm_Load(object sender, EventArgs e)
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
            SqlCommand command = new SqlCommand("USE typography " +
                "SELECT Booklets.id, Booklets.name, Advertisers.name, " +
                "Booklets.count, Booklets.unit_price, Booklets.unit_cost " +
                "FROM Booklets " +
                "JOIN Advertisers ON Advertisers.id = Booklets.id_advertiser " +
                "ORDER BY id", sqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (dataReader.Read())
            {
                data.Add(new string[6]);
                data[data.Count - 1][0] = dataReader[0].ToString();
                data[data.Count - 1][1] = dataReader[1].ToString();
                data[data.Count - 1][2] = dataReader[2].ToString();
                data[data.Count - 1][3] = dataReader[3].ToString();
                data[data.Count - 1][4] = dataReader[4].ToString();
                data[data.Count - 1][5] = dataReader[5].ToString(); 
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

        private void LoadBookletsComboBox(ComboBox cb)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT id, name FROM Booklets ORDER BY[id]", sqlConnection);
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
                LoadAdvertisersComboBox(advertisersAddCombobox);
            }
            if (tabControl1.SelectedIndex == 2)
            {
                LoadBookletsComboBox(bookletsUpdateComboBox);
                LoadAdvertisersComboBox(advertisersUpdateComboBox);
            }
            if (tabControl1.SelectedIndex == 3)
            {
                LoadBookletsComboBox(bookletsDeleteComboBox);
            }
        }

        private void countAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void priceAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void costAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void bookletsUpdateComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM [Booklets] WHERE [id]=@id", sqlConnection);
                command.Parameters.AddWithValue("id", bookletsUpdateComboBox.SelectedValue);
                SqlDataReader sqlReader = command.ExecuteReader();
                sqlReader.Read();
                nameUpdateTB.Text = Convert.ToString(sqlReader["name"]);
                advertisersUpdateComboBox.SelectedValue = Convert.ToInt32(sqlReader["id_advertiser"]);
                countUpdateTB.Text = Convert.ToString(sqlReader["count"]);
                priceUpdateTB.Text = Convert.ToString(sqlReader["unit_price"]);
                costUpdateTB.Text = Convert.ToString(sqlReader["unit_cost"]);
                sqlReader.Close();
            }
            catch(Exception ex)
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

        private void countUpdateTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void priceUpdateTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void costUpdateTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE [Booklets] SET [name]=@name, [id_advertiser]=@id_advertiser, " +
                    "[count]=@count, [unit_price]=@unit_price, [unit_cost]=@unit_cost WHERE [id]=@id", sqlConnection);
                command.Parameters.AddWithValue("id", bookletsUpdateComboBox.SelectedValue);
                command.Parameters.AddWithValue("name", nameUpdateTB.Text);
                command.Parameters.AddWithValue("id_advertiser", Convert.ToInt32(advertisersUpdateComboBox.SelectedValue));
                command.Parameters.AddWithValue("count", Convert.ToInt32(countUpdateTB.Text));
                command.Parameters.AddWithValue("unit_price", Convert.ToInt32(priceUpdateTB.Text));
                command.Parameters.AddWithValue("unit_cost", Convert.ToInt32(costUpdateTB.Text));
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
                SqlCommand command = new SqlCommand("DELETE FROM [Booklets] WHERE [id]=@id", sqlConnection);
                command.Parameters.AddWithValue("id", bookletsDeleteComboBox.SelectedValue);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadBookletsComboBox(bookletsDeleteComboBox);
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
