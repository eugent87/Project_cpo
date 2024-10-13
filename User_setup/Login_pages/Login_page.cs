using System.Windows.Forms;
using User_Interface;
using User_Interface.Login_pages;

namespace User_setup
{
    public partial class Login_page : Form
    {
        Connect_class connec_Class = new Connect_class();

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

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Введите корректный ID", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!long.TryParse(txtLogin.Text, out long userId))
            {
                MessageBox.Show("ID должен быть числом", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool login = Login_class.Login(userId, txtPassword.Text, connec_Class);
            if (login)
            {
                new Main_page(userId).Show();

            }
            else
            {
                MessageBox.Show("Неправильный ID или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            new Registr_page().Show();



        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_page_Load(object sender, EventArgs e)
        {

        }
    }
}
