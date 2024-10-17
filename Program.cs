using System;
using System.Data.SQLite;

string dataSource = "Data Source=Chinook.sqlite";

using (SQLiteConnection connection = new SQLiteConnection(dataSource))
{
    connection.Open();
    Console.WriteLine("Conexão com o banco de dados estabelecida.");

    string query = "SELECT * FROM Album LIMIT 5";

    using SQLiteCommand command = new SQLiteCommand(query, connection);
    using SQLiteDataReader reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"AlbumId: {reader["AlbumId"]}, Title: {reader["Title"]}, ArtistId: {reader["ArtistId"]}");
    }

    connection.Close();
    Console.WriteLine("Conexão com o banco de dados fechada.");
}