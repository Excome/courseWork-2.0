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
using System.IO;

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
            StreamReader sr = File.OpenText("connection.txt");
            string connectionString = sr.ReadLine();
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

        private void advertisersButton_Click(object sender, EventArgs e)
        {
            AdvertisersForm AdvertisersForm = new AdvertisersForm(this);
            AdvertisersForm.ShowDialog();
        }

        private void contractsButton_Click(object sender, EventArgs e)
        {
            ContractsForm ContractsForm = new ContractsForm(this);
            ContractsForm.ShowDialog();
        }

        private void bookletsButton_Click(object sender, EventArgs e)
        {
            BookletsForm BookletsForm = new BookletsForm(this);
            BookletsForm.ShowDialog();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            SalesRatingForm SalesRatingForm = new SalesRatingForm(this);
            SalesRatingForm.ShowDialog();
        }

        private void advertReportButton_Click(object sender, EventArgs e)
        {
            AdvertReportForm AdvertReportForm = new AdvertReportForm(this);
            AdvertReportForm.ShowDialog();
        }
    }
}
