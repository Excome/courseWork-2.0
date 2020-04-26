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
    public partial class SalesRatingForm : Form
    {
        MainForm MainForm;
        SqlConnection sqlConnection;

        public SalesRatingForm(MainForm MainForm)
        {
            this.MainForm = MainForm;
            InitializeComponent();
        }

        private void SalesRating_Load(object sender, EventArgs e)
        {
            sqlConnection = MainForm.sqlConnection;
            this.Width = 215;
            this.Height = 341;
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
            try
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

        private void queryCreator()
        {
            if (typeComboBox.SelectedIndex == 0)
            {
                string query = "SELECT TOP (@rows) [name] AS 'Название', [author] AS 'Автор', [count] AS 'Тираж', [total_sale] AS 'Кол-во продаж' FROM [Books]  " +
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
                string query = "SELECT TOP (@rows) [name_periodical] AS 'Название', [number] AS 'Номер', [count] AS 'Тираж', [total_sale] AS 'Кол-во продаж' FROM [Periodical_Numbers] ";
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
                }
                else
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

        private void periodicalsComboBox_SelectionChangeCommitted_1(object sender, EventArgs e)
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

        private void allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allCheckBox.CheckState == CheckState.Checked)
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
                tabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.Width = 215;
                this.Height = 341;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                this.Width = 619;
                this.Height = 495;
            }
        }

        Bitmap bmp;

        private void printButton_Click(object sender, EventArgs e)
        {
            int width = dataGridView1.Width;
            int height = dataGridView1.Height;
            dataGridView1.Width = 877;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            dataGridView1.ClearSelection();
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Width = width;
            dataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

    }
}
