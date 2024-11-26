using System;
using Microsoft.Data.SqlClient; 

class Program
{
    static string connectionString = "Server=your_server;Database=your_database;User  Id=your_user;Password=your_password;";

    static void Main(string[] args)
    {
        ShowAllUsers();
    }

    static void ShowAllUsers()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Users", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    Console.WriteLine($"Id: {id}, Name: {name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
