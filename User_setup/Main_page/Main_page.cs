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
        private long ID=0; 

        public Main_page(string connect_path, long iD)
        {
            get_Data_Table_Class = new Get_data_table_Class(connect_path);
            InitializeComponent();
            ID = iD;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ADD_button_Click(object sender, EventArgs e)
        {

        }

        private void Main_page_Load(object sender, EventArgs e)
        {

            Data_table.DataSource = get_Data_Table_Class.get_dataTable();
        }
    }
}
