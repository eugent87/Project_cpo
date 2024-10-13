using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace User_Interface.Main_page
{
    static class Query_class
    {
        public static void Delete_friend_from_db(Connect_class connect_, string Username_)
        {
            string query = "DELETE FROM users WHERE friend_username = @username"; 
            MySqlConnection connection = connect_.Get_connect();

            MySqlCommand command = new MySqlCommand();

            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    command.Connection = connection;
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@username", Username_); 

                    int rowsAffected = command.ExecuteNonQuery();

                    
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Элемент успешно удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить элемент. Возможно, пользователь не найден.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                connect_.Close_connect();
            }
        }


        public static void Add_friend_to_db(Connect_class connect_, string UserName, string Name, string Date, string Interests, long ID)
        {
            
            string checkQuery = "SELECT COUNT(*) FROM users WHERE friend_username = @friend_username";

           
            string insertQuery = "INSERT INTO users (telegram_id, friend_username, NAME, birthday, interests, is_congratulated) " +
                                 "VALUES (@telegram_id, @friend_username, @name, @birthday, @interests, @is_congratulated)";

            MySqlConnection connection = connect_.Get_connect();
            MySqlCommand command = new MySqlCommand();

            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    
                    command.Connection = connection;
                    command.CommandText = checkQuery;
                    command.Parameters.AddWithValue("@friend_username", UserName);

                    long userExists = (long)command.ExecuteScalar(); 

                    if (userExists > 0)
                    {
                        MessageBox.Show("Пользователь с таким именем уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    command.Parameters.Clear();

                    
                    if (string.IsNullOrWhiteSpace(UserName))
                    {
                        MessageBox.Show("Имя пользователя не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(Name))
                    {
                        MessageBox.Show("Имя не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DateTime birthday;
                    if (!DateTime.TryParse(Date, out birthday))
                    {
                        MessageBox.Show("Некорректная дата. Введите дату в формате 'YYYY-MM-DD'.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    command.CommandText = insertQuery;
                    command.Parameters.AddWithValue("@telegram_id", ID);
                    command.Parameters.AddWithValue("@friend_username", UserName);
                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@birthday", birthday);
                    command.Parameters.AddWithValue("@interests", Interests);
                    command.Parameters.AddWithValue("@is_congratulated", 0);

                    int rowsAffected = command.ExecuteNonQuery(); 

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Пользователь успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
                connect_.Close_connect(); 
            }
        }

        public static void Update_friend_in_db(Connect_class connect_, string UserName, string Name, string Date, string Interests, long ID)
        {
            string query = "UPDATE users SET NAME = @name, birthday = @birthday, interests = @interests " +
                           "WHERE telegram_id = @telegram_id AND friend_username = @friend_username";

            MySqlConnection connection = connect_.Get_connect();

            MySqlCommand command = new MySqlCommand();

            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    command.Connection = connection;
                    command.CommandText = query;

                  
                    command.Parameters.AddWithValue("@telegram_id", ID);
                    command.Parameters.AddWithValue("@friend_username", UserName);
                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@birthday", Date);
                    command.Parameters.AddWithValue("@interests", Interests);

                    
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Запись не найдена для обновления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Соединение не открыто. Невозможно выполнить запрос.", "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}", "Ошибка запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect_.Close_connect(); // Закрываем соединение
            }
        }
    }
}
