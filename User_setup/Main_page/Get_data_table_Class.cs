using MySql.Data.MySqlClient;
using System.Data;


namespace User_Interface.Main_page
{
    internal class Get_data_table_Class
    {
        Connect_class connec_Class;


        public Get_data_table_Class( Connect_class connec_Class_im)
        {
            this.connec_Class  = connec_Class_im;
            connec_Class.LoadConfig();
            
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
