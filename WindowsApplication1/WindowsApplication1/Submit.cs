using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsApplication1
{
    public partial class Submit : Form
    {
        SqlConnection myConn = new SqlConnection();
        public Submit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new HomePage().Show();
        }

        private void input_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new InputPage().Show();
        }

        private void done_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new HomePage().Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Search().Show();
        }

        private void depreciation_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new ViewDepreciation().Show();
        }

        private void History_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new History().Show();
        }
    }
}