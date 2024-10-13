using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_setup;

namespace User_Interface.Login_pages
{
    public partial class Registr_page : Form
    {

        Connect_class connect_Class = new Connect_class();
        public Registr_page()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
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
            bool reg = Login_class.Registr(long.Parse(txtLogin.Text), txtPassword.Text, connect_Class);
            if (reg)
            {
                new Login_page().Show();
                this.Close();
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Close_button_MouseEnter(object sender, EventArgs e)
        {
            Close_button.BackColor = Color.Red;
        }

        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            Close_button.BackColor = Color.LightGray;
        }
    }
}
