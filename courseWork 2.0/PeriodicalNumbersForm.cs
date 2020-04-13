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
    public partial class PeriodicalNumbersForm : Form
    {
        MainForm MainForm;
        public PeriodicalNumbersForm(MainForm mF)
        {
            MainForm = mF;
            InitializeComponent();
        }

        SqlConnection sqlConnection;
        private void PeriodicalNumbersForm_Load(object sender, EventArgs e)
        {
            sqlConnection = MainForm.sqlConnection;
            LoadDataComboBox(comboBox3);
        }

        private void LoadDataComboBox(ComboBox cb)
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

        private void LoadNumbersComboBox(ComboBox cb1, ComboBox cb2)
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
        private void LoadDataTable()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand command = new SqlCommand("SELECT * FROM Periodical_Numbers WHERE [id_periodical]=@id_periodical ORDER BY [id]", sqlConnection);
            command.Parameters.AddWithValue("id_periodical", comboBox3.SelectedValue);
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

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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
                dataGridView1.Rows.Clear();
                LoadDataComboBox(addCombobox);
            }
            if (tabControl1.SelectedIndex == 2)
            {
                LoadDataComboBox(updateCombobox1);
            }
            if (tabControl1.SelectedIndex == 3)
            {
                LoadDataComboBox(deleteComboBox1);
            }
        }

        private void numberAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
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
        private void advertAddTB_KeyPress(object sender, KeyPressEventArgs e)
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
                if (!string.IsNullOrEmpty(numberAddTB.Text) && !string.IsNullOrWhiteSpace(numberAddTB.Text) &&
                    !string.IsNullOrEmpty(countAddTB.Text) && !string.IsNullOrWhiteSpace(countAddTB.Text) &&
                    !string.IsNullOrEmpty(priceAddTB.Text) && !string.IsNullOrWhiteSpace(priceAddTB.Text) &&
                    !string.IsNullOrEmpty(costAddTB.Text) && !string.IsNullOrWhiteSpace(costAddTB.Text) &&
                    !string.IsNullOrEmpty(advertAddTB.Text) && !string.IsNullOrWhiteSpace(advertAddTB.Text))
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [Periodical_Numbers] (name_periodical, id_periodical, number, count, unit_price," +
                        "unit_cost, advertising_cm)VALUES(@name_periodical, @id_periodical, @number, @count, @unit_price, @unit_cost," +
                        " @advertising_cm)", sqlConnection);
                    command.Parameters.AddWithValue("name_periodical", addCombobox.Text);
                    command.Parameters.AddWithValue("id_periodical", addCombobox.SelectedValue);
                    command.Parameters.AddWithValue("number", Convert.ToInt32(numberAddTB.Text));
                    command.Parameters.AddWithValue("count", Convert.ToInt32(countAddTB.Text));
                    command.Parameters.AddWithValue("unit_price", Convert.ToInt32(priceAddTB.Text));
                    command.Parameters.AddWithValue("unit_cost", Convert.ToInt32(costAddTB.Text));
                    command.Parameters.AddWithValue("advertising_cm", Convert.ToInt32(advertAddTB.Text));
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

        private void updateCombobox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadNumbersComboBox(updateCombobox1, updateCombobox2);
        }

        private void updateCombobox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM [Periodical_Numbers] WHERE [id]=@id", sqlConnection);
                command.Parameters.AddWithValue("id", updateCombobox2.SelectedValue);
                SqlDataReader sqlReader = command.ExecuteReader();
                sqlReader.Read();
                countUpdateTB.Text = Convert.ToString(sqlReader["count"]);
                priceUpdateTB.Text = Convert.ToString(sqlReader["unit_price"]);
                costUpdateTB.Text = Convert.ToString(sqlReader["unit_cost"]);
                advertUpdateTB.Text = Convert.ToString(sqlReader["advertising_cm"]);
                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) { sqlConnection.Close(); }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE [Periodical_Numbers] SET [count]=@count, [unit_price]=@unit_price," +
                    "[unit_cost]=@unit_cost, [advertising_cm]=@advertising_cm WHERE [id]=@id", sqlConnection);
                command.Parameters.AddWithValue("id", updateCombobox2.SelectedValue);
                command.Parameters.AddWithValue("count", countUpdateTB.Text);
                command.Parameters.AddWithValue("unit_price", Convert.ToInt32(priceUpdateTB.Text));
                command.Parameters.AddWithValue("unit_cost", Convert.ToInt32(costUpdateTB.Text));
                command.Parameters.AddWithValue("advertising_cm", Convert.ToInt32(advertUpdateTB.Text));
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

        private void advertUpdateTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void deleteComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadNumbersComboBox(deleteComboBox1, deleteComboBox2);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand command = new SqlCommand("DELETE FROM [Periodical_Numbers] WHERE [id]=@id", sqlConnection);
                command.Parameters.AddWithValue("id", deleteComboBox2.SelectedValue);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadNumbersComboBox(deleteComboBox1, deleteComboBox2);
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
