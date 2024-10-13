using System.Windows.Forms;
using User_Interface;
using User_Interface.Login_pages;

namespace User_setup
{
    public partial class Login_page : Form
    {
        Connect_class connect_Class = new Connect_class();
        static string absolutePath = "";
        public Login_page(string _absolutePath)
        {
            absolutePath = _absolutePath;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            Close_button.BackColor = Color.LightGray;
        }

        private void Close_button_MouseEnter(object sender, EventArgs e)
        {
            Close_button.BackColor = Color.Red;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool login = Login_class.Login(long.Parse(txtLogin.Text), txtPassword.Text, connect_Class);
            if (login)
            {
                new Main_page(absolutePath, long.Parse(txtLogin.Text));
                this.Close();
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

        }
    }
}
