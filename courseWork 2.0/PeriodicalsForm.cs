using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace courseWork_2._0
{
    public partial class PeriodicalsForm : Form
    {
        MainForm MainForm;
        public PeriodicalsForm(MainForm mF)
        {
            MainForm = mF;
            InitializeComponent();
        }

        SqlConnection sqlConnection;
        private void PeriodicalsForm_Load(object sender, EventArgs e)
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
            SqlCommand command = new SqlCommand("SELECT * FROM Periodicals ORDER BY [id]", sqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (dataReader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = dataReader[0].ToString();
                data[data.Count - 1][1] = dataReader[1].ToString();
                data[data.Count - 1][2] = dataReader[2].ToString();
            }
            dataReader.Close();
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            foreach(string[] dataElement in data)
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
            SqlCommand command = new SqlCommand("SELECT [name] FROM Periodicals ORDER BY [id]", sqlConnection);
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                dataGridView1.Rows.Clear();
                LoadDataTable();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                nameAddTB.Clear();
                numberOfYearAddTB.Clear();
                //Добавить изминение размеров формы
            }
            if(tabControl1.SelectedIndex == 2)
            {
                LoadDataComboBox(comboBox1);
            }
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
                    !string.IsNullOrEmpty(numberOfYearAddTB.Text) && !string.IsNullOrWhiteSpace(numberOfYearAddTB.Text))
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [Periodicals] (name, number_of_year)" +
                        "VALUES(@name, @number_of_year)", sqlConnection);
                    command.Parameters.AddWithValue("name", nameAddTB.Text);
                    command.Parameters.AddWithValue("number_of_year", Convert.ToInt32(numberOfYearAddTB.Text));
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

        private void numberOfYearAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM [Periodicals] WHERE [id]=@id", sqlConnection);
                command.Parameters.AddWithValue("id", comboBox1.SelectedValue);
                SqlDataReader sqlReader = command.ExecuteReader();
                sqlReader.Read();
                nameUpdateTB.Text = Convert.ToString(sqlReader["name"]);
                numberOfYearUpdateTB.Text = Convert.ToString(sqlReader["number_of_year"]);
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

        private void numberOfYearUpdateTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }
    }
}
