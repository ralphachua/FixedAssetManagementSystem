using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class InputPage : Form
    {
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
            new Submit().Show();
            this.Close();
        }
    }
}