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
using User_Interface;
using User_Interface.Main_page;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace User_setup
{
    public partial class Main_page : Form
    {
        private Get_data_table_Class get_Data_Table_Class;
        private long ID = 0;
        Connect_class connec_Class = new Connect_class();


        public Main_page(string connect_path, long iD)
        {
            get_Data_Table_Class = new Get_data_table_Class(connect_path, connec_Class);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void richTextBox3_Leave(object sender, EventArgs e)
        {
            string input = Date_TextBox.Text;
            if (!Validation_class.IsValidDate_match_with_mask(input))
            {
                Date_TextBox.Clear();
                Date_TextBox.Focus(); // Возвращаем фокус на RichTextBox
            }
            if (!Validation_class.IsValidDate_match_good_date(input))
            {
                Date_TextBox.Clear();
                Date_TextBox.Focus(); // Возвращаем фокус на RichTextBox
            }

        }

        private void Add_button_Click(object sender, EventArgs e)
        {

        }


        //private void Update_tabel()
        //{
        //    Data_table.DataSource = get_Data_Table_Class.get_dataTable(this.ID);
        //    Date_TextBox.Text = Date_TextBox.Text.Substring(0, 10);
        //}

        private void Data_table_Click(object sender, EventArgs e)
        {
            UserName_TextBox.Text = Data_table.SelectedRows[0].Cells[0].Value.ToString();
            Name_TextBox.Text = Data_table.SelectedRows[0].Cells[1].Value.ToString();
            Date_TextBox.Text = Data_table.SelectedRows[0].Cells[2].Value.ToString().Substring(0,10);
            Interests_TextBox.Text = Data_table.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить этот элемент?",
                                                    "Подтверждение удаления",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (Data_table.SelectedRows.Count > 0 &&
                    Data_table.SelectedRows[0].Cells[0].Value != null &&
                    !string.IsNullOrEmpty(Data_table.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    string UserName = Data_table.SelectedRows[0].Cells[0].Value.ToString();
                    Query_class.Delete_friend_from_db(connec_Class, UserName);
                    MessageBox.Show("Элемент успешно удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Выделенная строка пуста или содержит недопустимое значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Удаление отменено.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Data_table.DataSource = get_Data_Table_Class.get_dataTable(this.ID);
        }

        private void Add_button_Click_1(object sender, EventArgs e)
        {
            Query_class.Add_friend_to_db(connec_Class, UserName_TextBox.Text, Name_TextBox.Text, Date_TextBox.Text, Interests_TextBox.Text, ID);
            Data_table.DataSource = get_Data_Table_Class.get_dataTable(this.ID);
        }

        private void UserName_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрещаем ввод русских букв (кириллических символов)
            if (char.IsLetter(e.KeyChar) && e.KeyChar >= 'А' && e.KeyChar <= 'я')
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Name_TextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Interests_TextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Update_button_Click(object sender, EventArgs e)
        {
            Query_class.Update_friend_in_db(connec_Class, UserName_TextBox.Text, Name_TextBox.Text, Date_TextBox.Text, Interests_TextBox.Text, ID);
            Data_table.DataSource = get_Data_Table_Class.get_dataTable(this.ID);

        }
    }
}
