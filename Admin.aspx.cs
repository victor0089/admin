using System;

namespace YourNamespace
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Hardcoded credentials for demonstration
            if (username == "admin" && password == "password")
            {
                lblMessage.Text = "Login successful!";
            }
            else
            {
                lblMessage.Text = "Invalid username or password";
            }
        }
    }
}
