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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Redirect user to login screen on logout
            Login login = new Login();

            this.Hide();
            login.Show();
        }

        private void AddPicture_Paint(object sender, EventArgs e)
        {
            // Open the picture select dialog and check if image is selected
            if (ImageDialog.ShowDialog() == DialogResult.OK)
            {   
                // Create a new picture control
                PictureBox picture = new PictureBox();

                // Load the image, set the size and stretch the image to fit
                picture.Load(ImageDialog.FileName);
                picture.Size = AddPicture.Size;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;

                // Add the image into the container
                this.ImagePanel.Controls.Add(picture);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void GeneralInfoForm_Click(object sender, EventArgs e)
        {

        }

        private void WorkingStandardsForm_MouseClick(object sender, MouseEventArgs e)
        {
            WorkingStandards workingStandards = new WorkingStandards();
            //TODO make background blur and inactive
            this.Hide();
            workingStandards.Show();
            
         }

      

        private void ToolsForm_MouseClick(object sender, MouseEventArgs e)
        {
            Tools tools = new Tools();
            this.Hide();
            tools.Show();
            
        }

       

        private void QualityForm_Click(object sender, MouseEventArgs e)
        {
            Quality quality = new Quality();
            this.Hide();
            quality.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SiteRulesForm_MouseClick(object sender, MouseEventArgs e)
        {
            Site_Rules siterules = new Site_Rules();
            this.Hide();
            siterules.Show();
        }
    }
}
