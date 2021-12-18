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
    public partial class SignUp : Form
    {

        Utility utility = new Utility();

        public SignUp()
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

        // Redirect to Login form
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();

            this.Hide();
            loginForm.Show();
        }
    
        private void SignUpAccountButton_Click(object sender, EventArgs e)
        {
            // TODO: Create a new account, store it in database

            // Form entered data
            string username = Username.Text;
            string email = Email.Text;
            string password = Password.Text;

            DBConnection.getDBInstance().saveNewInspectorToDB(Constants.INSERTUser, username, email, password);

            // Redirect to login screen on successfull sign up
            Login login = new Login();

            this.Hide();
            login.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
