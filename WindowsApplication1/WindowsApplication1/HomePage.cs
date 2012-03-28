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
    public partial class HomePage : Form
    {
        SqlConnection myConn = new SqlConnection();
        public HomePage()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void input_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InputPage().Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Search().Show();
        }

        private void depreciation_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewDepreciation().Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void History_Click(object sender, EventArgs e)
        {
            this.Hide();
            new History().Show();
        }

    }
}