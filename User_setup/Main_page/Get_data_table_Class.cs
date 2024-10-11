using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface.Main_page
{
    internal class Get_data_table_Class
    {
        Connect_class connec_Class = new Connect_class();


        public Get_data_table_Class(string Con_path)
        {
            connec_Class.LoadConfig(Con_path);
            
        }



        public DataTable get_dataTable(long id)
        {
            string query = "SELECT friend_username, NAME, birthday,interests FROM users WHERE telegram_id = @telegramId";
            MySqlConnection connection = connec_Class.Get_connect();
            DataTable dataTable ;
            MySqlCommand command ;
            MySqlDataAdapter adapter;
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@telegramId", id);
                    adapter = new MySqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                else
                {
                    MessageBox.Show("Соединение не открыто. Невозможно выполнить запрос.", "Ошибка выполнения запроса", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}", "Ошибка запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connec_Class.Close_connect();
            }
            return new DataTable();
        }

    }
}
