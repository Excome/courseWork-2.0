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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public SqlConnection _sqlConnection;
        public SqlConnection sqlConnection
        {
            get
            {
                return _sqlConnection;
            }
            set
            {
                _sqlConnection = value;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-ATRUUNO\SQLEXPRESS;Initial Catalog=typography;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                MessageBox.Show("Connection to database successful!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void PeriodicalsButton_Click(object sender, EventArgs e)
        {
            PeriodicalsForm PeriodicalsForm = new PeriodicalsForm(this);
            PeriodicalsForm.ShowDialog();
        }

        private void numbersButton_Click(object sender, EventArgs e)
        {
            PeriodicalNumbersForm PeriodicalNumbersForm = new PeriodicalNumbersForm(this);
            PeriodicalNumbersForm.ShowDialog();
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            BooksForm BooksForm = new BooksForm(this);
            BooksForm.ShowDialog();
        }
    }
}
