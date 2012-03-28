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
    public partial class View : Form
    {
        SqlConnection myConn = new SqlConnection();
        public View()
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
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void godate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.end.Text);
            Date datepage = new Date();
            datepage.sDate.Text = this.start.Text;
            datepage.eDate.Text = this.end.Text;
            this.Close();
            datepage.Show();
        }

        private void gocategory_Click(object sender, EventArgs e)
        {
            Category catpage = new Category();
            catpage.start = CStart.Text;
            catpage.end = CEnd.Text;
            catpage.id.Text = this.category.Text;
            this.Close();
            catpage.Show();
        }

        private void goname_Click(object sender, EventArgs e)
        {
            ByName namepage = new ByName();
            namepage.Name.Text = NStart.Text;
            this.Close();
            namepage.Show();
        }

        private void depreciation_Click(object sender, EventArgs e)
        {
            this.Close();
            new Depreciation().Show();
        }

    }
}