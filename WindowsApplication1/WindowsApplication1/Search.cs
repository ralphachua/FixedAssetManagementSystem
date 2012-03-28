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
    public partial class Search : Form
    {
        SqlConnection myConn = new SqlConnection();
        public Search()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void searchB_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void goid_Click(object sender, EventArgs e)
        { 
            bool error=false;
            if (id.Text is string && id.Text.Length > 0)
            {
                id.BackColor = Color.White;
            }
            else
            {
                error = true;
                id.BackColor = Color.Red;
            }

            if (error == false)
            {
                Output outputPage = new Output();
                outputPage.id.Text = this.id.Text;
                if (!outputPage.IsDisposed)
                {
                    this.Dispose();
                    outputPage.Show();
                }
            }
            else
            {
                error = false;
            }
            
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

        private void id_TextChanged(object sender, EventArgs e)
        {
            myConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
            myConn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT [Asset ID], [Asset Name], [Category Type], [Quantity], [Asset Reference Number], [Asset Purchase Date] FROM Asset Join Category ON [Category ID] = [Asset Category] WHERE [Asset ID] LIKE '"+id.Text +"%'", myConn);
            DataTable t = new DataTable();
            adapter.Fill(t);
            dataGridView1.DataSource = t;
            dataGridView1.Refresh();
        }


    }
}