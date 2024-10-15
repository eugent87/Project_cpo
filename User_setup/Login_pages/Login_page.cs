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

       

        private void Show_pass_CheckedChanged(object sender, EventArgs e)
        {

            if (Show_pass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
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
                this.Hide();
                new Main_page(userId).Show();
                
                

            }
            else
            {
                MessageBox.Show("Неправильный ID или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registr_page().Show();



        }

        

        private void Login_page_Load(object sender, EventArgs e)
        {
            connec_Class.LoadConfig();
            txtPassword.PasswordChar = '*';

        }

        

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar >= 'А' && e.KeyChar <= 'я')
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
