using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace User_Interface
{
    internal class Connect_class
    {
        [JsonPropertyName("Server")]
        public string Server { get; set; }

        [JsonPropertyName("Database")]
        public string Database { get; set; }

        [JsonPropertyName("User")]
        public string User { get; set; }

        [JsonPropertyName("Password")]
        public string Password { get; set; }

        [JsonPropertyName("Port")]
        public int Port { get; set; }

        private MySqlConnection connection;

        public void LoadConfig()
        {
            // Устанавливаем значения по умолчанию для свойств
            Server = "ERROR";
            Database = "ERROR";
            User = "ERROR";
            Password = "ERROR";
            Port = 0;

            try
            {
                string json = File.ReadAllText(json_path_class.get_absolut_path());
                Console.WriteLine($"Содержимое JSON-файла: {json}"); // Логирование содержимого файла

                // Десериализация в новый объект
                var config = JsonSerializer.Deserialize<Connect_class>(json);

                if (config != null)
                {

                    Server = config.Server ?? "ERROR";
                    Database = config.Database ?? "ERROR";
                    User = config.User ?? "ERROR";
                    Password = config.Password ?? "ERROR";
                    Port = config.Port != 0 ? config.Port : 3306; // Устанавливаем значение порта по умолчанию, если он не задан

                    // Вывод значений в консоль для проверки
                    Console.WriteLine($"Server: {Server}");
                    Console.WriteLine($"Database: {Database}");
                    Console.WriteLine($"User: {User}");
                    Console.WriteLine($"Password: {Password}");
                    Console.WriteLine($"Port: {Port}");
                }
                else
                {
                    throw new JsonException("Файл конфигурации пуст или имеет неверный формат.");
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Ошибка при чтении JSON-конфигурации: {ex.Message}", "Ошибка загрузки конфигурации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Ошибка при чтении JSON-конфигурации: {ex.Message}");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка загрузки файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении JSON-конфигурации: {ex.Message}", "Ошибка загрузки конфигурации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Ошибка при чтении JSON-конфигурации: {ex.Message}");
            }
        }

        public MySqlConnection Get_connect()
        {
            string connectionString = $"Server={Server};Database={Database};User ID={User};Password={Password};Port={Port};";
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Соединение успешно установлено!");
                return connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Ошибка подключения: {ex.Message}");
            }

            return null;
        }

        public void Close_connect()
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();

                    Console.WriteLine("Соединение успешно закрыто.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка при закрытии соединения: {ex.Message}", "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Ошибка при закрытии соединения: {ex.Message}");
            }
        }
    }
}
