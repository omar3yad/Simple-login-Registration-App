namespace FirstDescktopApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            // Trim input to avoid accidental whitespace issues
            string username = textBox2.Text.Trim(); 
            string password = textBox1.Text.Trim();

            if (username == "omar3yad" && password == "1")
            {
                MessageBox.Show("Login successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Additional action can be placed here, e.g., navigating to the next form
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear password field for security and reset focus
                txt_pass.Focus();
            }
        }
    }
}
