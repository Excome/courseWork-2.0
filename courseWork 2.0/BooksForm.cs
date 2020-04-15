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
    public partial class BooksForm : Form
    {
        MainForm MainForm;
        public BooksForm(MainForm MainForm)
        {
            this.MainForm = MainForm;
            InitializeComponent();
        }

        SqlConnection sqlConnection;

        private void LoadDataTable()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand command = new SqlCommand("SELECT * FROM Books ORDER BY [id]", sqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (dataReader.Read())
            {
                data.Add(new string[7]);
                data[data.Count - 1][0] = dataReader[0].ToString();
                data[data.Count - 1][1] = dataReader[1].ToString();
                data[data.Count - 1][2] = dataReader[2].ToString();
                data[data.Count - 1][3] = dataReader[3].ToString();
                data[data.Count - 1][4] = dataReader[4].ToString();
                data[data.Count - 1][5] = dataReader[5].ToString();
                data[data.Count - 1][6] = dataReader[6].ToString();
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

        private void LoadDataComboBox(ComboBox cb)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Books ORDER BY[id]", sqlConnection);
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

        private void BooksForm_Load(object sender, EventArgs e)
        {
            sqlConnection = MainForm.sqlConnection;
            LoadDataTable();
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
                nameAddTB.Text = "";
                authorAddTB.Text = "";
                countAddTB.Text = "";
                priceAddTB.Text = "";
                costAddTB.Text = "";
                saleAddTB.Text = "";
            }
            if (tabControl1.SelectedIndex == 2)
            {
                LoadDataComboBox(updateComboBox);
                nameUpdateTB.Text = "";
                authorUpdateTB.Text = "";
                countUpdateTB.Text = "";
                priceUpdateTB.Text = "";
                costUpdateTB.Text = "";
                saleUpdateTB.Text = "";
            }
            if (tabControl1.SelectedIndex == 3)
            {
                LoadDataComboBox(deleteComboBox);
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

        private void saleAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                if (!string.IsNullOrEmpty(nameAddTB.Text) && !string.IsNullOrWhiteSpace(nameAddTB.Text) &&
                    !string.IsNullOrEmpty(authorAddTB.Text) && !string.IsNullOrWhiteSpace(authorAddTB.Text) &&
                    !string.IsNullOrEmpty(countAddTB.Text) && !string.IsNullOrWhiteSpace(countAddTB.Text) &&
                    !string.IsNullOrEmpty(priceAddTB.Text) && !string.IsNullOrWhiteSpace(priceAddTB.Text) &&
                    !string.IsNullOrEmpty(costAddTB.Text) && !string.IsNullOrWhiteSpace(costAddTB.Text) &&
                    !string.IsNullOrEmpty(saleAddTB.Text) && !string.IsNullOrWhiteSpace(saleAddTB.Text))
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [Books] (name, author, count, unit_price, unit_cost, total_sale)" +
                        "VALUES(@name, @author, @count, @unit_price, @unit_cost, @total_sale)", sqlConnection);
                    command.Parameters.AddWithValue("name", nameAddTB.Text);
                    command.Parameters.AddWithValue("author", authorAddTB.Text);
                    command.Parameters.AddWithValue("count", Convert.ToInt32(countAddTB.Text));
                    command.Parameters.AddWithValue("unit_price", Convert.ToInt32(priceAddTB.Text));
                    command.Parameters.AddWithValue("unit_cost", Convert.ToInt32(costAddTB.Text));
                    command.Parameters.AddWithValue("total_sale", Convert.ToInt32(saleAddTB.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена!");
                }
                else { MessageBox.Show("Все поля должны быть заполнены!"); }
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

        private void updateComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM [Books] WHERE [id]=@id", sqlConnection);
                command.Parameters.AddWithValue("id", updateComboBox.SelectedValue);
                SqlDataReader sqlReader = command.ExecuteReader();
                sqlReader.Read();
                nameUpdateTB.Text = Convert.ToString(sqlReader["name"]);
                authorUpdateTB.Text = Convert.ToString(sqlReader["author"]);
                countUpdateTB.Text = Convert.ToString(sqlReader["count"]);
                priceUpdateTB.Text = Convert.ToString(sqlReader["unit_price"]);
                costUpdateTB.Text = Convert.ToString(sqlReader["unit_cost"]);
                saleUpdateTB.Text = Convert.ToString(sqlReader["total_sale"]);
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

        private void saleUpdateTB_KeyPress(object sender, KeyPressEventArgs e)
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
                SqlCommand command = new SqlCommand("UPDATE [Books] SET [name]=@name, [author]=@author, [count]=@count, " +
                    "[unit_price]=@unit_price, [unit_cost]=@unit_cost, [total_sale]=@total_sale WHERE [id]=@id", sqlConnection);
                command.Parameters.AddWithValue("id", updateComboBox.SelectedValue);
                command.Parameters.AddWithValue("name", nameUpdateTB.Text);
                command.Parameters.AddWithValue("author", authorUpdateTB.Text);
                command.Parameters.AddWithValue("count", Convert.ToInt32(countUpdateTB.Text));
                command.Parameters.AddWithValue("unit_price", Convert.ToInt32(priceUpdateTB.Text));
                command.Parameters.AddWithValue("unit_cost", Convert.ToInt32(costUpdateTB.Text));
                command.Parameters.AddWithValue("total_sale", Convert.ToInt32(saleUpdateTB.Text));
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
                SqlCommand command = new SqlCommand("DELETE FROM [Books] WHERE [id]=@id", sqlConnection);
                command.Parameters.AddWithValue("id", deleteComboBox.SelectedValue);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadDataComboBox(deleteComboBox);
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
