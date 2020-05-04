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
    public partial class AdvertReportForm : Form
    {
        MainForm MainForm;
        SqlConnection sqlConnection;

        public AdvertReportForm(MainForm MainForm)
        {
            this.MainForm = MainForm;
            InitializeComponent();
        }

        private void AdvertReportForm_Load(object sender, EventArgs e)
        {
            sqlConnection = MainForm.sqlConnection;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Advertisers ORDER BY[id]", sqlConnection);
                DataSet comboboxDataSet = new DataSet();
                sqlAdapter.Fill(comboboxDataSet);
                DataTable comboboxDataTable = comboboxDataSet.Tables[0];
                advertisersComboBox.DataSource = comboboxDataTable;
                advertisersComboBox.DisplayMember = "name";
                advertisersComboBox.ValueMember = "id";
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
                typeComboBox.SelectedIndex = 1;
                advertisersComboBox.SelectedIndex = 1;
                this.Width = 215;
                this.Height = 341;
            }
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
                for (int i = 0; i < 5; i++)
                {
                    DataRow row = DataTable.NewRow();
                    switch(i)
                    {
                        case 0:
                            row[0] = "Итого:";
                            break;
                        case 1:
                            row[1] = "Сумма:";
                            int summ = 0;
                            foreach (DataRow item in DataTable.Rows)
                            {
                                if (! DBNull.Value.Equals(item["Итоговая цена"]))
                                    summ += Convert.ToInt32(item["Итоговая цена"]);

                            }
                            row[2] = summ;
                            break;
                        case 2:
                            row[1] = "Средн.:";
                            int avg = 0;
                            int k = 0;
                            foreach (DataRow item in DataTable.Rows)
                            {
                                if (!DBNull.Value.Equals(item["Итоговая цена"])) {
                                    avg += Convert.ToInt32(item["Итоговая цена"]);
                                    k ++;
                                }                                    
                            }
                            row[2] = avg / k;
                            break;
                        case 3:
                            row[1] = "Макс.:";
                            int max = 0;
                            foreach (DataRow item in DataTable.Rows)
                            {
                                if (!DBNull.Value.Equals(item["Итоговая цена"]))
                                    if(max < Convert.ToInt32(item["Итоговая цена"]))
                                        max = Convert.ToInt32(item["Итоговая цена"]);
                            }
                            row[2] = max;
                            break;
                        case 4:
                            row[1] = "Мин.:";
                            int min = Convert.ToInt32(DataTable.Rows[0]["Итоговая цена"]);
                            foreach (DataRow item in DataTable.Rows)
                            {
                                if (!DBNull.Value.Equals(item["Итоговая цена"]))
                                    if (min > Convert.ToInt32(item["Итоговая цена"]))
                                        min = Convert.ToInt32(item["Итоговая цена"]);
                            }
                            row[2] = min;
                            break;

                    }
                    DataTable.Rows.Add(row);

                }
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

        private void advertisersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                SqlCommand command = new SqlCommand("", sqlConnection);
                if (typeComboBox.SelectedIndex == 0)
                {
                    command.CommandText = "SELECT COUNT(id) FROM Contracts WHERE [id_advertiser]=@id_advertiser";
                    command.Parameters.AddWithValue("id_advertiser", advertisersComboBox.SelectedValue);
                    hScrollBar1.Maximum = Convert.ToInt32(command.ExecuteScalar());
                }
                else if (typeComboBox.SelectedIndex == 1)
                {
                    command.CommandText = "SELECT COUNT(id) FROM Booklets WHERE [id_advertiser]=@id_advertiser";
                    command.Parameters.AddWithValue("id_advertiser", advertisersComboBox.SelectedValue);
                    hScrollBar1.Maximum = Convert.ToInt32(command.ExecuteScalar());
                }
                if (hScrollBar1.Maximum == 0)
                {
                    hScrollBar1.Maximum = 0;
                }
                else
                {
                    hScrollBar1.Minimum = 1;
                }
                hScrollBar1.Value = hScrollBar1.Maximum;
                rowsTB1.Text = Convert.ToString(hScrollBar1.Maximum);
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

        private void allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allCheckBox.CheckState == CheckState.Checked)
            {
                int summAll = 0;
                for (int i = 0; i < advertisersComboBox.Items.Count; i++)
                {
                    advertisersComboBox.SelectedIndex = i;
                    summAll += Convert.ToInt32(rowsTB1.Text);
                }
                hScrollBar1.Maximum = summAll;
                hScrollBar1.Minimum = 1;
                hScrollBar1.Value = hScrollBar1.Maximum;
                rowsTB1.Text = Convert.ToString(hScrollBar1.Maximum);
                advertisersComboBox.Enabled = false;
            } 
            else
            {
                advertisersComboBox.Enabled = true;
                advertisersComboBox.SelectedIndex = 0;
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.Width = 215;
                this.Height = 341;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                this.Width = 830;
                this.Height = 495;
                if (dataGridView1.Rows == null || dataGridView1.Rows.Count == 0)
                {
                    tabControl1.SelectedIndex = 0;
                }
            }
        }

        private string queryCreator()
        {
            string query = "";            
            if (typeComboBox.SelectedIndex == 0)
            {
                query = " USE typography SELECT TOP (@rows) [" +
                    "Advertisers].name AS 'Рекламодатель', [Periodical_Numbers].name_periodical AS 'Название'," +
                    "[Periodical_Numbers].number AS 'Номер', [Contracts].v_first_page AS 'V первой стр.', " +
                    "[Contracts].v_normal_page AS 'V обычной стр.', [Contracts].v_last_page AS 'V последней стр.', " +
                    "[Periodical_Numbers].advertising_cm AS 'Цена см^2', [Contracts].total_price AS 'Итоговая цена' " +
                    "FROM[typography].[dbo].[Advertisers] " +
                    "INNER JOIN[Contracts] ON[Contracts].id_advertiser = [Advertisers].id " +
                    "INNER JOIN[Periodical_Numbers] ON[Periodical_Numbers].id = [Contracts].id_number_periodical ";
                if (allCheckBox.CheckState == CheckState.Unchecked)
                {
                    query += "WHERE [Contracts].id_advertiser=@id_advertiser ";
                }
            }
            else if(typeComboBox.SelectedIndex == 1)
            {
                query = "USE typography SELECT TOP (@rows) " +
                    "Advertisers.name AS 'Рекламодатель', Booklets.name AS 'Назвиние', Booklets.count AS 'Тираж', " +
                    "Booklets.unit_price AS 'Цена 1шт.', Booklets.unit_cost AS 'Стоимость 1шт.', Booklets.total_price AS 'Итоговая цена' " +
                    " FROM Booklets INNER JOIN Advertisers ON Advertisers.id = Booklets.id_advertiser ";
                if (allCheckBox.CheckState == CheckState.Unchecked)
                {
                    query += "WHERE [Booklets].id_advertiser=@id_advertiser ";
                }
            }
            if (typeCheckedListBox1.SelectedIndex == 0)
            {
                query += "ORDER BY total_price DESC";
            }
            else if (typeCheckedListBox1.SelectedIndex == 1)
            {
                query += "ORDER BY total_price ASC";
            }
                return query;
        }

        private void reportButton1_Click(object sender, EventArgs e)
        {
            string query = queryCreator();
            if (query != "" && rowsTB1.Text != "0")
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("rows", Convert.ToInt32(rowsTB1.Text));
                if (query.IndexOf("WHERE") != -1)
                {
                    command.Parameters.AddWithValue("id_advertiser", advertisersComboBox.SelectedValue);
                }
                LoadDataTable(command);
                tabControl1.SelectedIndex = 1;
            } else
            {
                MessageBox.Show("Все поля параметры должны быть выбраны");
            }
        }

        Bitmap bmp;

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                dataGridView1.ClearSelection();
                bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                dataGridView1.Height = height;
                printPreviewDialog1.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
