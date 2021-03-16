using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public class Mysql
    {
        private readonly MySqlConnection _connection = new MySqlConnection("server=127.0.0.1;user id=root;password=;database=students;CharSet=utf8");

        public Mysql()
        {
            OpenCloseConnection();

        }

        private async void OpenCloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                await _connection.OpenAsync();
                Console.WriteLine("db connection open");
            }
            else if (_connection.State == System.Data.ConnectionState.Open)
            {
                await _connection.CloseAsync();
                Console.WriteLine("db connection close");
            }
        }

        public MySqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
