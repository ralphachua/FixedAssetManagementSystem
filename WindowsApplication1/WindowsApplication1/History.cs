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
    public partial class History : Form
    {
        SqlConnection myConn = new SqlConnection();
        public History()
        {
            InitializeComponent();
            this.start.Text = DateTime.Parse("01/01/1900").ToString("MM/dd/yyyy");
            this.end.Text = DateTime.Now.ToString("MM/dd/yyyy");
            this.CStart.Text = DateTime.Parse("01/01/1900").ToString("MM/dd/yyyy");
            this.CEnd.Text = DateTime.Now.ToString("MM/dd/yyyy");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void godate_Click(object sender, EventArgs e)
        {
            DateTime sampledate;
            bool error = false;
            if (DateTime.TryParse(start.Text, out sampledate))
            {
                start.BackColor = Color.White;
            }
            else
            {
                error = true;
                start.BackColor = Color.Red;
            }

            if (DateTime.TryParse(end.Text, out sampledate))
            {
                end.BackColor = Color.White;
            }
            else
            {
                error = true;
                end.BackColor = Color.Red;
            }

            if (error == false)
            {
                Date datepage = new Date();
                datepage.sDate.Text = this.start.Text;
                datepage.eDate.Text = this.end.Text;
                if (!datepage.IsDisposed)
                {
                    this.Dispose();
                    datepage.Show();
                }
            }
            else
            {
                error = false;
            }
        }

        private void gocategory_Click(object sender, EventArgs e)
        {
            DateTime sampledate;
            bool error = false;
            if (DateTime.TryParse(CStart.Text, out sampledate))
            {
                CStart.BackColor = Color.White;
            }
            else
            {
                error = true;
                CStart.BackColor = Color.Red;
            }

            if (DateTime.TryParse(CEnd.Text, out sampledate))
            {
                CEnd.BackColor = Color.White;
            }
            else
            {
                error = true;
                CEnd.BackColor = Color.Red;
            } 
            
            if (category.Text != "Choose")
            {
                category.BackColor = Color.White;
            }
            else
            {
                error = true;
                category.BackColor = Color.Red;
            }

            if (error == false)
            {
                Category catpage = new Category();
                catpage.start = CStart.Text;
                catpage.end = CEnd.Text;
                catpage.id.Text = this.category.Text;
                this.Dispose();
                catpage.Show();
            }
            else 
            {
                error = false;
            }
        }

        private void goname_Click(object sender, EventArgs e)
        {
            bool error = false;
            
            if (NStart.Text is string && NStart.Text.Length>0)
            {
                CEnd.BackColor = Color.White;
            }
            else
            {
                error = true;
                NStart.BackColor = Color.Red;
            }

            if (error == false)
            {
                ByName namepage = new ByName();
                namepage.name.Text = NStart.Text;
                if (!namepage.IsDisposed)
                {
                    this.Dispose();
                    namepage.Show();
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

        private void HistoryB_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        
    }
}