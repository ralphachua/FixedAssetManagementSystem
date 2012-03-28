using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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