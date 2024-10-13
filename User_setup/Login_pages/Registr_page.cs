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
            bool reg = Login_class.Registr(long.Parse(txtLogin.Text), txtPassword.Text, connect_Class);
            if (reg)
            {
                new Login_page();
                this.Close();
            }
        }
    }
}
