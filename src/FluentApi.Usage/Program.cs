// See https://aka.ms/new-console-template for more information

using FluentApi;

Console.WriteLine("Hello, World!");

var connection = FluentSqlConnection.CreateConnection(config =>
    {
        config.ConnectionName = "My Connection";
    }).
    ForServer("server").
    AndDatabase("database").
    AsUser("user").
    WithPassword("password").
    Connect();

//do something with the connection

connection.Close();
