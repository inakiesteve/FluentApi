using System.Data;
using System.Data.SqlClient;

namespace FluentApi
{
    public class FluentSqlConnection: 
        IConnectionInitializerStage, 
        IDatabaseSelectionStage, 
        IPasswordSelectionStage, 
        IUserSelectionStage, 
        IServerSelectionStage
    {
        private string _server;
        private string _database;
        private string _user;
        private string _password;

        private FluentSqlConnection()
        {

        }

        public static IServerSelectionStage CreateConnection(Action<ConnectionConfiguration> config)
        {
            var configuration = new ConnectionConfiguration();
            //applies delegate config on configuration
            config?.Invoke(configuration);
            return new FluentSqlConnection();
        }

        public IDbConnection Connect()
        {
            var connection =
                new SqlConnection($"Server={_server};Database={_database};User Id={_user};Password={_password};");

            connection.Open();
            return connection;
        }

        public IUserSelectionStage AndDatabase(string database)
        {
            _database = database;
            return this;
        }

        public IConnectionInitializerStage WithPassword(string password)
        {
            _password = password;
            return this;
        }

        public IPasswordSelectionStage AsUser(string user)
        {
            _user = user;
            return this;
        }

        public IDatabaseSelectionStage ForServer(string server)
        {
            _server = server;
            return this;
        }
    }
}