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
    public partial class ReportsForm : Form
    {
        MainForm MainForm;

        public ReportsForm(MainForm MainForm)
        {
            this.MainForm = MainForm;
            InitializeComponent();
        }

        SqlConnection sqlConnection;

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            sqlConnection = MainForm.sqlConnection;
        }

        private void LoadDataTable(SqlCommand cmd)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                DataSet DataSet = new DataSet();
                sqlAdapter.Fill(DataSet);
                DataTable DataTable = DataSet.Tables[0];
                dataGridView1.DataSource = DataTable;
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

        private void LoadPeriodicalsComboBox(ComboBox cb)
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

        private void queryCreator()
        {
            if (typeComboBox.SelectedIndex == 0)
            {
                string query = "SELECT TOP (@rows) [name], [author], [count], [total_sale] FROM [Books]  " +
                          "ORDER BY ([total_sale]*100)/[count] ";
                if (typeCheckedListBox1.SelectedIndex == 0)
                {
                    query += " DESC";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("rows", Convert.ToInt32(rowsTB1.Text));
                    LoadDataTable(command);
                }
                else if (typeCheckedListBox1.SelectedIndex == 1)
                {
                    query += " ASC";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("rows", Convert.ToInt32(rowsTB1.Text));
                    LoadDataTable(command);
                }
            }
            else if (typeComboBox.SelectedIndex == 1)
            {
                string query = "SELECT TOP (@rows) [name_periodical], [number], [count], [total_sale] FROM [Periodical_Numbers] ";
                if (periodicalsComboBox.SelectedItem != null)
                {
                    query += "WHERE [id_periodical]=@id_periodical ";
                }
                if (typeCheckedListBox1.SelectedIndex == 0)
                {
                    query += "ORDER BY ([total_sale]*100)/[count] DESC";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    if (periodicalsComboBox.SelectedItem != null)
                    {
                        command.Parameters.AddWithValue("id_periodical", Convert.ToInt32(periodicalsComboBox.SelectedValue));
                    }
                    command.Parameters.AddWithValue("rows", Convert.ToInt32(rowsTB1.Text));
                    LoadDataTable(command);
                }
                else if (typeCheckedListBox1.SelectedIndex == 1)
                {
                    query += "ORDER BY ([total_sale]*100)/[count] ASC";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    if (periodicalsComboBox.SelectedItem != null)
                    {
                        command.Parameters.AddWithValue("id_periodical", Convert.ToInt32(periodicalsComboBox.SelectedValue));
                    }
                    command.Parameters.AddWithValue("rows", Convert.ToInt32(rowsTB1.Text));
                    LoadDataTable(command);
                } else
                {
                    MessageBox.Show("Все поля должны быть выбраны!");
                }
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex == 0) 
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(id) FROM Books", sqlConnection);
                hScrollBar1.Maximum = Convert.ToInt32(cmd1.ExecuteScalar());
                hScrollBar1.Minimum = 1;
                hScrollBar1.Value = hScrollBar1.Maximum;
                rowsTB1.Text = Convert.ToString(hScrollBar1.Maximum);
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                label2.Visible = false;
                periodicalsComboBox.Visible = false;
                allCheckBox.Visible = false;
            }
            if (typeComboBox.SelectedIndex == 1)
            {
                label2.Visible = true;
                periodicalsComboBox.Visible = true;
                allCheckBox.Visible = true;
                allCheckBox.Checked = false;
                LoadPeriodicalsComboBox(periodicalsComboBox);
            }
        }

        private void allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(allCheckBox.CheckState == CheckState.Checked)
            {
                periodicalsComboBox.SelectedItem = null;
                periodicalsComboBox.Enabled = false;
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(id) FROM [Periodical_Numbers]", sqlConnection);
                hScrollBar1.Maximum = Convert.ToInt32(cmd1.ExecuteScalar());
                hScrollBar1.Minimum = 1;
                hScrollBar1.Value = hScrollBar1.Maximum;
                rowsTB1.Text = Convert.ToString(hScrollBar1.Maximum);
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

            } 
            else
            {
                periodicalsComboBox.Enabled = true;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            rowsTB1.Text = Convert.ToString(hScrollBar1.Value);
        }

        private void typeCheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var list = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
                foreach (int index in list.CheckedIndices)
                    if (index != e.Index)
                        list.SetItemChecked(index, false);
        }

        private void periodicalsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(id) FROM [Periodical_Numbers] WHERE [id_periodical]=@id_periodical", sqlConnection);
            cmd1.Parameters.AddWithValue("id_periodical", periodicalsComboBox.SelectedValue);
            hScrollBar1.Maximum = Convert.ToInt32(cmd1.ExecuteScalar());
            hScrollBar1.Minimum = 1;
            hScrollBar1.Value = hScrollBar1.Maximum;
            rowsTB1.Text = Convert.ToString(hScrollBar1.Maximum);
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        private void reportButton1_Click(object sender, EventArgs e)
        {
            try 
            {
                queryCreator();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}