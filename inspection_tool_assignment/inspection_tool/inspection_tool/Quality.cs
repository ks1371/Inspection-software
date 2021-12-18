using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inspection_tool
{
    public partial class Quality : Form
    {
        public Quality()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Heading_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            //TODO save the data to database

            this.Hide();
            dashboard.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Working_standards_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            //TODO save the data to database

            this.Hide();
            dashboard.Show();
        }
    }
}
