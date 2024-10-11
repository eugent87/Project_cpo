using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace User_Interface.Main_page
{
    internal class Connect_class
    {
        private string Server { get; set; }
        private string Database { get; set; }
        private string User { get; set; }
        private string Password { get; set; }
        private int Port { get; set; }

        private MySqlConnection connection;

        public Connect_class(string filePath)
        {
            Server = "ERROR";
            Database = "ERROR";
            User = "ERROR";
            Password = "ERROR";
            Port = 0;
            try
            {
                string json = File.ReadAllText(filePath);
                var config = JsonSerializer.Deserialize<Connect_class>(json);

                if (config != null)
                {
                    Server = config.Server;
                    Database = config.Database;
                    User = config.User;
                    Password = config.Password;
                    Port = config.Port;
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Ошибка при чтении JSON-конфигурации: {ex.Message}", "Ошибка загрузки конфигурации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка загрузки файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public MySqlConnection Get_connect()
        {
            string connectionString = $"Server={this.Server};Database={this.Database};User ID={this.User};Password={this.Password};Port={this.Port};";
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Соединение успешно установлено!");
                return connection;
            }
            catch (Exception ex)
            {
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
                    MessageBox.Show("Соединение успешно закрыто.", "Соединение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка при закрытии соединения: {ex.Message}", "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
