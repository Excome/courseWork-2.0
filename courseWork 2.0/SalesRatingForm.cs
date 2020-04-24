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
    }
}
