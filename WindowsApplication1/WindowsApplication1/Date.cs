using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace WindowsApplication1
{
    public partial class Date : Form
    {
        SqlConnection myConn = new SqlConnection();
        SqlDataReader rdr;
        public Date()
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

        private void eDate_TextChanged(object sender, EventArgs e)
        {
            myConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
            myConn.Open();
            string commandString = @"SELECT * FROM History WHERE Date BETWEEN '" + sDate.Text + "' AND '" + eDate.Text + "'";
            SqlCommand cmd = new SqlCommand(commandString, myConn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                if (rdr != null)
                {
                    rdr.Dispose();
                }
                SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT Asset.[Asset ID], Asset.[Asset Name], Asset.[Asset Category], Category.[Category Type], Status.[Status] , History.* FROM Asset JOIN History ON Asset.[Asset ID] = History.[Asset ID] JOIN Status ON Status.[Status ID] = Asset.[Asset Status] JOIN Category ON Category.[Category ID] = Asset.[Asset Category] WHERE Date BETWEEN '" + sDate.Text + "' AND '" + eDate.Text + "'", myConn);
                DataTable t = new DataTable();
                adapter.Fill(t);
                t.Columns.RemoveAt(5);
                t.Columns.RemoveAt(10);
                dataGridView1.DataSource = t;
                dataGridView1.Columns[2].Visible = false;
                this.dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Refresh();
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

        private void History_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new History().Show();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            string filename = string.Format("date-{0:yyyy-MM-dd_hh-mm-ss-tt}.csv", DateTime.Now);
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filename);

            string header = "Start Date:," + sDate.Text + ", ,End Date:," + eDate.Text;
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



