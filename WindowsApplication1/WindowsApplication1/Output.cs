using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace WindowsApplication1
{
    public partial class Output : Form
    {
        SqlConnection myConn = new SqlConnection();
        SqlDataReader rdr;

        public Output()
        {
            InitializeComponent();

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
            this.Dispose();
            new Search().Show();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

            myConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
            myConn.Open();


            string commandString = @"SELECT * FROM Asset WHERE [Asset ID] = '" + id.Text + "'";
            SqlCommand cmd = new SqlCommand(commandString, myConn);
            string commandString1 = "";
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    name.Text = (string)rdr["Asset Name"];
                    ACost.Text = rdr["Asset Acquisition Cost"].ToString();
                    Life.Text = rdr["Asset Useful Life"].ToString();
                    commandString = @"SELECT [Status] FROM Status WHERE [Status ID] like '" + rdr["Asset Status"] + "'";
                  
                    commandString1 = @"SELECT [Category Type] FROM Category WHERE [Category ID] = " + rdr["Asset Category"];
                   
                }
                if (rdr != null)
                {
                    rdr.Dispose();
                }
                 cmd = new SqlCommand(commandString, myConn);
                  stat.Text = (string)cmd.ExecuteScalar();
             
                cmd = new SqlCommand(commandString1, myConn);
                category.Text = (string)cmd.ExecuteScalar();
                commandString = @"SELECT CASE WHEN (CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date], GETDATE() ) as Decimal(12 , 2)) <= 0) THEN [Quantity] ELSE CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date], GETDATE() ) as Decimal(12 , 2)) END  From Asset Where [Asset ID] ='" + id.Text + "'";
                cmd = new SqlCommand(commandString, myConn);
                BookVal.Text = cmd.ExecuteScalar().ToString();


                //SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT ([Asset Acquisition Cost] - [Depreciation Years]) AS [Test]  From Asset Join Category ON Asset.[Asset Category] = Category.[Category ID] Where [Asset ID] =" + id.Text, myConn);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM History WHERE [Asset ID] = '" + id.Text + "'", myConn);
                DataTable t = new DataTable();
                adapter.Fill(t);
                dataGridView1.DataSource = t;
                this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            else
            {
                MessageBox.Show("Not in database!!");
                this.Dispose();
            }
            myConn.Close();
        }


        private void depreciation_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new ViewDepreciation().Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Edit editPage = new Edit();
            editPage.id.Text = this.id.Text;
            this.Dispose();
            editPage.Show();
        }

        private void Output_Load(object sender, EventArgs e)
        {

        }

        private void History_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new History().Show();
        }

        private void Print_Click(object sender, EventArgs e)
        {


            string filename = string.Format("ouput-{0:yyyy-MM-dd_hh-mm-ss-tt}.csv", DateTime.Now);
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filename);

            string header = "Asset ID:," + id.Text + ", ,Asset Name:," + name.Text + ", ,Asset Acquisition Cost:," + ACost.Text;
            streamWriter.WriteLine(header);
            header = "Asset Useful Life:," + Life.Text + ", ,Current Book Value:," + BookVal.Text + ", ,Current Status:," + stat.Text;
            streamWriter.WriteLine(header);
            streamWriter.WriteLine("");

            string strHeader = "";

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {

                strHeader += dataGridView1.Columns[i].HeaderText + ",";

            }

            streamWriter.WriteLine(strHeader);





            for (int m = 0; m < dataGridView1.Rows.Count; m++)
            {

                string strRowValue = "";

                for (int n = 0; n < dataGridView1.Columns.Count; n++)
                {

                    strRowValue += dataGridView1.Rows[m].Cells[n].Value + ",";

                }

                streamWriter.WriteLine(strRowValue);

            }



            streamWriter.Dispose();

            ProcessStartInfo psi = new ProcessStartInfo(filename);
            psi.UseShellExecute = true;
            Process.Start(psi);
        }
    }




}