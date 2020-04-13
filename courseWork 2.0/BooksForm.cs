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

        private void BooksForm_Load(object sender, EventArgs e)
        {
            sqlConnection = MainForm.sqlConnection;
        }
    }
}
