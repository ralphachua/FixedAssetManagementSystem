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
    public partial class Depreciation : Form
    {
        SqlConnection myConn = new SqlConnection();
        public Depreciation()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Close();
            new HomePage().Show();
        }

        private void input_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Tong\\Desktop\\WindowsApplication1\\WindowsApplication1\\Database1.mdf;Integrated Security=True;User Instance=True");
            myConn.Open();
            String commandString = @"SELECT Count(*) FROM Asset";
            SqlCommand cmd = new SqlCommand(commandString, myConn);
            Int32 AssetID = (Int32)cmd.ExecuteScalar();
            InputPage inputpage = new InputPage();
            inputpage.id.Text = AssetID.ToString();
            this.Close();
            inputpage.Show();
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            this.Close();
            new Search().Show();
        }

        private void ViewB_Click(object sender, EventArgs e)
        {
            this.Close();
            new View().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void gocategory_Click(object sender, EventArgs e)
        {
            this.Close();
            new ViewDepreciation().Show();
        }
    }
}
