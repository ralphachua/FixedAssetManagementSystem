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
    public partial class InputPage : Form
    {
        SqlConnection myConn = new SqlConnection();
        public InputPage()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            new HomePage().Show(); 
            this.Dispose();
        }

        private void input_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            bool error = false;
            Int32 CategoryID, StatusID, num1;
            myConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
            myConn.Open();

            Decimal num = 0;
            DateTime sampledate;
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
               
                if (category.Text !="Choose")
                {
                    category.BackColor = Color.White;
                }
                else
                {
                    error = true;
                    category.BackColor = Color.Red;
                }

                if (DateTime.TryParse(AcquiDate.Text, out sampledate))
                {
                    AcquiDate.BackColor = Color.White;
                }
                else
                {
                    error = true;
                    AcquiDate.BackColor = Color.Red;
                }

                if (Decimal.TryParse(cost.Text, out num))
                { 
                    cost.BackColor = Color.White;
                }
                else
                {
                    error = true;
                    cost.BackColor = Color.Red;
                }

                if (Int32.TryParse(life.Text, out num1))
                {
                    life.BackColor = Color.White;
                }
                else
                {
                    error = true;
                    life.BackColor = Color.Red;
                }

                if (details.Text is string || details.Text.Length==0)
                {
                    details.BackColor = Color.White;
                }
                else
                {
                    error = true;
                    details.BackColor = Color.Red;
                }

                if (refNum.Text is string && refNum.Text.Length>0)
                {
                     refNum.BackColor = Color.White;
                }
                else
                {
                    error = true;
                    refNum.BackColor = Color.Red;
                }

                if (Int32.TryParse(Qty.Text, out num1))
                {
                    Qty.BackColor = Color.White;
                }
                else
                {
                    error = true;
                    Qty.BackColor = Color.Red;
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null || row.Cells[3].Value == null)
                        break;

                    if (DateTime.TryParse(row.Cells[0].Value.ToString(), out sampledate))
                    {

                    }
                    else
                    {
                        error = true;
                        holder = holder + "\nHistorical Date should be of Date and Time format!";
                    }

                    if (row.Cells[1].Value is string)
                    {
                        
                    }
                    else
                    {
                        error = true;
                        holder = holder + "\nParticulars should contain only Characters!";
                    }

                    if (row.Cells[2].Value is string)
                    {
                        
                    }
                    else
                    {
                        error = true;
                        holder = holder + "\nType of Transaction should contain only Characters!";
                    }

                    if (Decimal.TryParse(row.Cells[3].Value.ToString(), out num))
                    {
                     
                    }
                    else
                    {
                        error = true;
                        holder = holder + "\nCost should contain only Integers!";
                    }
                                                    
                }

                if (remarks.Text is string && remarks.Text.Length>0)
                {
                    remarks.BackColor = Color.White;
                }
                else
                {
                    error = true;
                    remarks.BackColor = Color.Red;
                }
                if (error == false)
                {
                    try
                    {
                        string commandString = @"SELECT [Category ID] FROM Category WHERE [Category Type] like '" + category.Text + "'";
                        SqlCommand cmd = new SqlCommand(commandString, myConn);
                        CategoryID = (Int32)cmd.ExecuteScalar();

                        commandString = @"SELECT [Status ID] FROM Status WHERE Status like '" + stat.Text + "'";
                        cmd = new SqlCommand(commandString, myConn);
                        StatusID = (Int32)cmd.ExecuteScalar();

                        commandString = @"
                INSERT INTO Asset ([Asset ID], [Asset Name], [Asset Acquisition Cost], [Asset Useful Life], [Asset Category], [Asset Status], [Asset Purchase Details], [Asset Reference Number], [Asset Purchase Date], [Quantity])
                values ('" + id.Text + "','" + name.Text + "','" + cost.Text + "','" + life.Text + "'," + CategoryID + "," + StatusID + ",'" + details.Text + "'," + refNum.Text + ",'" + AcquiDate.Text + "'," + Qty.Text + ")";
                        cmd = new SqlCommand(commandString, myConn);
                        cmd.ExecuteNonQuery();

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null || row.Cells[3].Value == null)
                                break;
                            commandString = @"INSERT INTO History ([Asset ID], Date, Particulars, [Type of Transaction], Cost, Remarks) values (@a, @b, @c, @d, @e, @f)";
                            cmd = new SqlCommand(commandString, myConn);
                            cmd.Parameters.AddWithValue("@a", (id.Text));
                            cmd.Parameters.AddWithValue("@b", (row.Cells[0].Value));
                            cmd.Parameters.AddWithValue("@c", (row.Cells[1].Value));
                            cmd.Parameters.AddWithValue("@d", (row.Cells[2].Value));
                            cmd.Parameters.AddWithValue("@e", (row.Cells[3].Value));
                            cmd.Parameters.AddWithValue("@f", (remarks.Text));
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
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
                this.Dispose();
                new Submit().Show();
            }
            else 
            {
                MessageBox.Show(holder,"Input Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                error = false;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < this.panel1.Controls.Count; i++){
                if(this.panel1.Controls[i] is ComboBox || this.panel1.Controls[i] is TextBox)
                this.panel1.Controls[i].ResetText() ;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            myConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
            myConn.Open();

            string commandString = @"SELECT [Depreciation Years] FROM Category WHERE [Category Type] like '" + category.Text + "'";
            SqlCommand cmd = new SqlCommand(commandString, myConn);
            Int32 depval = (Int32) cmd.ExecuteScalar();
            life.Text = depval.ToString();
            
            String commandString2 = @"SELECT Count(*) FROM Asset";
            SqlCommand cmd2 = new SqlCommand(commandString2, myConn);
            Int32 aid = (Int32)cmd2.ExecuteScalar();

            string commandString1 = @"SELECT [Category Tag] FROM Category WHERE [Category Type] like '" + category.Text + "'";
            SqlCommand cmd1 = new SqlCommand(commandString1, myConn);
            string tag = cmd1.ExecuteScalar().ToString();
            id.Text = tag + aid; 
           
            myConn.Close();
            
        }

        private void History_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new History().Show();
        }



      

    
    }
}