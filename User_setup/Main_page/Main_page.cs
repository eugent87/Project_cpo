using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Interface.Main_page;

namespace User_setup
{
    public partial class Main_page : Form
    {
        private Get_data_table_Class get_Data_Table_Class;
        private long ID = 0;

        public Main_page(string connect_path, long iD)
        {
            get_Data_Table_Class = new Get_data_table_Class(connect_path);
            InitializeComponent();
            ID = iD;
        }



        private void Main_page_Load(object sender, EventArgs e)
        {

            Data_table.DataSource = get_Data_Table_Class.get_dataTable(this.ID);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.LightGray;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
