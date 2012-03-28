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
            this.Close();
        }

        private void input_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Int32 CategoryID, StatusID, SubCategoryID;
            myConn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\extras\\UPDacadJun\\cs192\\project\\WindowsApplication1\\WindowsApplication1\\Database1.mdf;Integrated Security=True;User Instance=True");
            myConn.Open();

            string commandString = @"SELECT [Category ID] FROM Category WHERE [Category Type] like '" + category.Text+"'";
            SqlCommand cmd = new SqlCommand(commandString, myConn);
            CategoryID = (Int32)cmd.ExecuteScalar();

            commandString = @"SELECT [Status ID] FROM Status WHERE Status like '" + stat.Text + "'";
            cmd = new SqlCommand(commandString, myConn);
            StatusID = (Int32)cmd.ExecuteScalar();

            commandString = @"SELECT COUNT(*) FROM Subcategory";
            cmd = new SqlCommand(commandString, myConn);
            SubCategoryID = (Int32)cmd.ExecuteScalar();

            commandString = @"
           INSERT INTO Subcategory ([Category ID],[Subcategory ID], Type)
           values (" + CategoryID + "," + SubCategoryID + ",'"+ type.Text + "')";
            cmd = new SqlCommand(commandString, myConn);
            cmd.ExecuteNonQuery();

            commandString = @"
           INSERT INTO Asset ([Asset ID], [Asset Name], [Asset Acquisition Cost], [Asset Useful Life], [Asset Category], [Asset Status], [Asset Type], [Asset Purchase Details])
           values (" + id.Text + ",'" + name.Text + "','" + cost.Text + "','" + life.Text + "'," + CategoryID+ "," + StatusID + ","+  SubCategoryID + ",'"+ details.Text +"')";
            cmd = new SqlCommand(commandString, myConn);
            cmd.ExecuteNonQuery();


            commandString = @"
           INSERT INTO History ([Asset ID], Date, Particulars, [Type of Transaction], Cost, Remarks)
           values (" + id.Text + ",'" + DateTime.Now.ToString("G") + "','" + this.dataGridView1.Rows[0].Cells[1].Value.ToString() + "','" + this.dataGridView1.Rows[0].Cells[2].Value.ToString() + "','" + this.dataGridView1.Rows[0].Cells[3].Value.ToString() + "','" + remarks.Text + "')";
           
            cmd = new SqlCommand(commandString, myConn);
            cmd.ExecuteNonQuery();
            if (myConn != null)
             {
                 myConn.Close();
             }
         
            new Submit().Show();
            this.Close();
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

    
    }
}