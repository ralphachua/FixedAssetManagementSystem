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
    public partial class Edit : Form
    {
        SqlConnection myConn = new SqlConnection();
        SqlCommandBuilder cmdBldr = new SqlCommandBuilder(); 
        SqlDataReader rdr;
        SqlDataAdapter adapter;
        DataTable t;
        public Edit()
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

        private void depreciation_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new ViewDepreciation().Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Decimal num = 0;
            Int32 num1 = 0;
            DateTime sampledate;
            bool error = false;
            string holder = "Input Error: Please check all input again!";

                if (name.Text is string && name.Text.Length>0)
                {
                    name.BackColor = Color.White;
                }
                else
                {
                    error = true;
                    name.BackColor = Color.Red;
                }
                
                if (stat.Text !="Choose")
                {
                    stat.BackColor = Color.White;
                }
                else
                {
                    error = true;
                    stat.BackColor = Color.Red;
                }

                if (Decimal.TryParse(ACost.Text, out num))
                { 
                    ACost.BackColor = Color.White;
                }
                else
                {
                    error = true;
                    ACost.BackColor = Color.Red;
                }

                if (Int32.TryParse(Life.Text, out num1))
                {
                    Life.BackColor = Color.White;
                }
                else
                {
                    error = true;
                    Life.BackColor = Color.Red;
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value == null || row.Cells[2].Value == null || row.Cells[3].Value == null || row.Cells[4].Value == null)
                        break;

                    if (DateTime.TryParse(row.Cells[1].Value.ToString(), out sampledate))
                    {

                    }
                    else
                    {
                        error = true;
                        holder = holder + "\nHistorical Date should be of Date and Time format!";
                    }

                    if (row.Cells[2].Value is string)
                    {
                        
                    }
                    else
                    {
                        error = true;
                        holder = holder + "\nParticulars should contain only Characters!";
                    }

                    if (row.Cells[3].Value is string)
                    {
                        
                    }
                    else
                    {
                        error = true;
                        holder = holder + "\nType of Transaction should contain only Characters!";
                    }

                    if (row.Cells[4].Value is decimal)
                    {
                        
                    }
                    else
                    {
                        error = true;
                        holder = holder + "\nCost should contain only Integers!";
                    }

                    if (row.Cells[5].Value is string)
                    {
                       
                    }
                    else
                    {
                        error = true;
                        holder = holder + "\nRemarks should contain only Characters!";
                    }
                                                    
                }

               
                if (error == false)
                {
                    try
                    {
                        myConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
                        myConn.Open();
                        adapter.UpdateCommand = cmdBldr.GetUpdateCommand(true);
                        adapter.Update(t);
                        string commandString = @"SELECT [Status ID] FROM Status WHERE [Status] like '" + stat.Text + "'";
                        SqlCommand cmd = new SqlCommand(commandString, myConn);
                        Int32 number = (Int32)cmd.ExecuteScalar();
                        commandString = @"UPDATE [Asset] SET [Asset Name] ='" + name.Text + "', [Asset Acquisition Cost] = '" + ACost.Text + "', [Asset Useful LIfe] = '" + Life.Text + "', [Asset Status] = '" + number + "'WHERE [Asset ID] = '" + id.Text + "'";
                        cmd = new SqlCommand(commandString, myConn);
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        error = true;
                    }
                
                }

                if (myConn != null)
                {
                    myConn.Close();
                }

                if (error == false)
                {
                    myConn.Close();
                    this.Dispose();
                    new SubmitEdit().Show();
                }
                else
                {
                    MessageBox.Show(holder, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = false;
                }
           
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


            string commandString = @"SELECT * FROM Asset WHERE [Asset ID] = '" + id.Text + "'";
            SqlCommand cmd = new SqlCommand(commandString, myConn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    name.Text = (string)rdr["Asset Name"];
                    ACost.Text = rdr["Asset Acquisition Cost"].ToString();
                    Life.Text = rdr["Asset Useful Life"].ToString();
                    commandString = @"SELECT [Status] FROM Status WHERE [Status ID] like '" +rdr["Asset Status"] + "'";
                    cmd = new SqlCommand(commandString, myConn);

                }
                if (rdr != null)
                {
                    rdr.Dispose();
                }
                stat.Text = (string)cmd.ExecuteScalar();
            }
            BindingSource bSource = new BindingSource();
            //SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT ([Asset Acquisition Cost] - [Depreciation Years]) AS [Test]  From Asset Join Category ON Asset.[Asset Category] = Category.[Category ID] Where [Asset ID] =" + id.Text, myConn);
            adapter = new SqlDataAdapter("SELECT * FROM History WHERE [Asset ID] = '" + id.Text + "'", myConn);
            cmdBldr = new SqlCommandBuilder(adapter);
            t = new DataTable();
            adapter.Fill(t);
            t.Columns[0].DefaultValue = id.Text;
            BindingSource bndsource = new BindingSource();
            bndsource.DataSource= t;
            dataGridView1.DataSource = bndsource;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            myConn.Close();

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

            MessageBox.Show("Error happened! Please check you last input in the Table!");

        }

    }
}
