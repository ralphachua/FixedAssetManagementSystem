using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Submit : Form
    {
        public Submit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            this.Close();
        }

        private void input_Click(object sender, EventArgs e)
        {
            this.Close();
            new InputPage().Show();
        }
    }
}