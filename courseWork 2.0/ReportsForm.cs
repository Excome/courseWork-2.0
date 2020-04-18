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

        private void LoadDataTable(string query, int countColumn)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (dataReader.Read())
            {
                data.Add(new string[countColumn]);
                for (int i = 0; i < countColumn; i++)
                {
                    data[data.Count - 1][i] = dataReader[i].ToString();
                }
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
    }
}