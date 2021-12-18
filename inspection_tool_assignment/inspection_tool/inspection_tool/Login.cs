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
    public partial class Login : Form
    {

        Utility utility = new Utility();

        public Login()
        {
            InitializeComponent();
        }

        // Simulate a placeholder text when starting to type
        private void InputField_Enter(object sender, EventArgs e)
        {
            utility.changePlaceholder_Enter(sender);
        }

        // Simulate a placeholder text when leaving the TextBox empty
        private void InputField_Leave(object sender, EventArgs e)
        {
            utility.changePlaceholder_Enter(sender);
        }

        // Redirect to the signup form (simulates routing)
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();

            this.Hide();
            signUp.Show();
        }

        // Redirect user to dashboard on successful login
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
                
            // TODO: Add user authorization once database is added

            this.Hide();
            dashboard.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
