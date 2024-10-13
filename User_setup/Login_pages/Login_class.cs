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
            // SQL-запрос для проверки существования пользователя
            string checkQuery = "SELECT COUNT(*) FROM PSW WHERE TelegramID = @ID AND PasswordHash = @pswprd";

            // Получаем подключение из переданного объекта connect_
            MySqlConnection connection = connect_.Get_connect();

            try
            {
                if (connection == null)
                {
                    MessageBox.Show("Не удалось получить соединение с базой данных.", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Если соединение не открыто, открываем его
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                using (MySqlCommand command = new MySqlCommand(checkQuery, connection))
                {
                    // Добавляем параметры запроса
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@pswprd", psw);

                    // Выполняем команду и получаем результат
                    object result = command.ExecuteScalar();
                    long userExists = (result != null) ? Convert.ToInt64(result) : 0;

                    // Проверяем, существует ли пользователь
                    if (userExists > 0)
                    {
                        MessageBox.Show("Успешный вход.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким ID или паролем не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Выводим сообщение об ошибке, если запрос не удался
                MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}\nStack Trace: {ex.StackTrace}", "Ошибка запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Закрываем соединение, если оно открыто
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connect_.Close_connect();
                }
            }
        }


        static public bool Registr(long ID, string psw, Connect_class connect_)
        {
            string checkQuery = "SELECT COUNT(*) FROM PSW WHERE TelegramID = @ID";
            string addUser = "INSERT INTO PSW (TelegramID, PasswordHash) VALUES (@telegram_id, @PasswordHash)";

            MySqlConnection connection = connect_.Get_connect();
            MySqlCommand command = new MySqlCommand();

            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                 
                    command.Connection = connection;
                    command.CommandText = checkQuery;
                    command.Parameters.AddWithValue("@ID", ID);

                    object result = command.ExecuteScalar();
                    long userExists = (result != null) ? Convert.ToInt64(result) : 0;

                    if (userExists > 0)
                    {
                        MessageBox.Show("Пользователь с таким ID уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        
                        command.Parameters.Clear(); 
                        command.CommandText = addUser;
                        command.Parameters.AddWithValue("@telegram_id", ID);
                        command.Parameters.AddWithValue("@PasswordHash", psw);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Регистрация успешна.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
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
