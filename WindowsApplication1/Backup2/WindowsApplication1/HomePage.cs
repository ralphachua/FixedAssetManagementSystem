using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void input_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InputPage().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Submit().Show();
        }
    }
}