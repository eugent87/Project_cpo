using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace User_Interface.Login_pages
{
    static class Login_class
    {


        static public bool Login(long ID, string psw, Connect_class connect_)
        {
            string checkQuery = "SELECT COUNT(*) FROM PSW WHERE TelegramID = @ID AND PasswordHash = @psw";

            MySqlConnection connection = connect_.Get_connect();
            MySqlCommand command = new MySqlCommand();

            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    command.Connection = connection;
                    command.CommandText = checkQuery;
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@psw", psw);

                    object result = command.ExecuteScalar();
                    long userExists = (result != null) ? Convert.ToInt64(result) : 0;

                    if (userExists > 0)
                    {
                        MessageBox.Show("Успешный вход.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким ID или паролем не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    command.Parameters.Clear(); 
                }
                else
                {
                    MessageBox.Show("Не удалось подключиться к базе данных.", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}", "Ошибка запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect_.Close_connect();
            }

            return false;
        }
    }
}
