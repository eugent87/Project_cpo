namespace User_setup
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }



        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPassword.Clear();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_pass.Checked)
            {
                txtPassword.Enabled = false;
            }
            else
            {
                txtLogin.Enabled = true;
            }
        }
    }
}
