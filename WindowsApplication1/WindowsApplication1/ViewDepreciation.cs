using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace WindowsApplication1
{
    public partial class ViewDepreciation : Form
    {
        SqlConnection myConn = new SqlConnection();

        public ViewDepreciation()
        {
            InitializeComponent();
            this.start.Text = DateTime.Parse("01/01/1900").ToString("MM/dd/yyyy");
            this.end.Text = DateTime.Now.ToString("MM/dd/yyyy");
            myConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
            myConn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT [Asset Name], [Quantity], [Asset Reference Number], [Asset Purchase Date], [Asset Useful Life], [Asset Acquisition Cost], CAST( [Asset Acquisition Cost] / [Asset Useful Life]/12 as DECIMAL(12,2)) as [Monthly Depreciation],Category.[Category Type], CASE WHEN (CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) <= 0) THEN [Quantity] ELSE CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) END  as [Net Book Value] FROM Asset Join Category ON [Category ID] = [Asset Category] Where [Asset Purchase Date] BETWEEN'" + start.Text + "' AND '" + end.Text + "'", myConn);
            DataTable t = new DataTable();
            adapter.Fill(t);
            t.Columns.RemoveAt(7);
            dataGridView1.DataSource = t;
            this.dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Refresh();
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

        private void depreciation_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void History_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new History().Show();
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category.Text.Equals("All"))
            {
                myConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
                myConn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT [Asset Name], [Quantity], [Asset Reference Number], [Asset Purchase Date], [Asset Useful Life], [Asset Acquisition Cost], CAST( [Asset Acquisition Cost] / [Asset Useful Life]/12 as DECIMAL(12,2)) as [Monthly Depreciation],Category.[Category Type], CASE WHEN (CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) <= 0) THEN [Quantity] ELSE CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) END  as [Net Book Value] FROM Asset Join Category ON [Category ID] = [Asset Category] Where [Asset Purchase Date] BETWEEN'" + start.Text + "' AND '" + end.Text + "'", myConn);
                DataTable t = new DataTable();
                adapter.Fill(t);
                t.Columns.RemoveAt(7);
                dataGridView1.DataSource = t;
                this.dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Refresh();
            }
            else
            {
                myConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
                myConn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT [Asset Name], [Quantity], [Asset Reference Number], [Asset Purchase Date], [Asset Useful Life], [Asset Acquisition Cost], CAST( [Asset Acquisition Cost] / [Asset Useful Life]/12 as DECIMAL(12,2)) as [Monthly Depreciation],Category.[Category Type], CASE WHEN (CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) <= 0) THEN [Quantity] ELSE CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) END  as [Net Book Value] FROM Asset Join Category ON [Category ID] = [Asset Category] Where [Category Type] like '" + category.Text + "' AND [Asset Purchase Date] BETWEEN'" + start.Text + "' AND '" + end.Text + "'", myConn);
                DataTable t = new DataTable();
                adapter.Fill(t);
                t.Columns.RemoveAt(7);
                dataGridView1.DataSource = t;
                this.dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Refresh();
            }
        }

        private void start_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (category.Text.Equals("All"))
                {
                    myConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
                    myConn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT [Asset Name], [Quantity], [Asset Reference Number], [Asset Purchase Date], [Asset Useful Life], [Asset Acquisition Cost], CAST( [Asset Acquisition Cost] / [Asset Useful Life]/12 as DECIMAL(12,2)) as [Monthly Depreciation],Category.[Category Type], CASE WHEN (CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) <= 0) THEN [Quantity] ELSE CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) END  as [Net Book Value] FROM Asset Join Category ON [Category ID] = [Asset Category] Where [Asset Purchase Date] BETWEEN'" + start.Text + "' AND '" + end.Text + "'", myConn);
                    DataTable t = new DataTable();
                    adapter.Fill(t);
                    t.Columns.RemoveAt(7);
                    dataGridView1.DataSource = t;
                    this.dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Refresh();
                    myConn.Close();
                }
                else
                {
                    myConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
                    myConn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT [Asset Name], [Quantity], [Asset Reference Number], [Asset Purchase Date], [Asset Useful Life], [Asset Acquisition Cost], CAST( [Asset Acquisition Cost] / [Asset Useful Life]/12 as DECIMAL(12,2)) as [Monthly Depreciation],Category.[Category Type], CASE WHEN (CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) <= 0) THEN [Quantity] ELSE CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) END  as [Net Book Value] FROM Asset Join Category ON [Category ID] = [Asset Category] Where [Category Type] like '" + category.Text + "' AND [Asset Purchase Date] BETWEEN'" + start.Text + "' AND '" + end.Text + "'", myConn);
                    DataTable t = new DataTable();
                    adapter.Fill(t);
                    t.Columns.RemoveAt(7);
                    dataGridView1.DataSource = t;
                    this.dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Refresh();
                    myConn.Close();
                }
            }
            catch (Exception)
            {
            }
        }

        private void end_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (category.Text.Equals("All"))
                {
                    myConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
                    myConn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT [Asset Name], [Quantity], [Asset Reference Number], [Asset Purchase Date], [Asset Useful Life], [Asset Acquisition Cost], CAST( [Asset Acquisition Cost] / [Asset Useful Life]/12 as DECIMAL(12,2)) as [Monthly Depreciation],Category.[Category Type], CASE WHEN (CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) <= 0) THEN [Quantity] ELSE CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) END  as [Net Book Value] FROM Asset Join Category ON [Category ID] = [Asset Category] Where [Asset Purchase Date] BETWEEN'" + start.Text + "' AND '" + end.Text + "'", myConn);
                    DataTable t = new DataTable();
                    adapter.Fill(t);
                    t.Columns.RemoveAt(7);
                    dataGridView1.DataSource = t;
                    this.dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Refresh();
                    myConn.Close();
                }
                else
                {
                    myConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
                    myConn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT [Asset Name], [Quantity], [Asset Reference Number], [Asset Purchase Date], [Asset Useful Life], [Asset Acquisition Cost], CAST( [Asset Acquisition Cost] / [Asset Useful Life]/12 as DECIMAL(12,2)) as [Monthly Depreciation],Category.[Category Type], CASE WHEN (CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) <= 0) THEN [Quantity] ELSE CAST([Asset Acquisition Cost] - [Asset Acquisition Cost]/[Asset Useful Life] *  DATEDIFF(year, [Asset Purchase Date],'" + end.Text + "' ) as Decimal(12 , 2)) END  as [Net Book Value] FROM Asset Join Category ON [Category ID] = [Asset Category] Where [Category Type] = '" + category.Text + "'[Asset Purchase Date] BETWEEN'" + start.Text + "' AND '" + end.Text + "'", myConn);
                    DataTable t = new DataTable();
                    adapter.Fill(t);
                    t.Columns.RemoveAt(7);
                    dataGridView1.DataSource = t;
                    this.dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Refresh();
                    myConn.Close();
                }
            }
            catch (Exception) { }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            string filename = string.Format("depreciation-{0:yyyy-MM-dd_hh-mm-ss-tt}.csv",DateTime.Now);
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filename);

            string header = "Category:,"+ category.Text+", ,Start Date:,"+start.Text+", ,End Date:,"+end.Text;
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

    

