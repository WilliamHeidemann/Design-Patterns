namespace Gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var database = new DatabaseGateway(new Database());
            database.Connect();
            database.ExecuteQuery("Some query");
            database.Disconnect();
        }
    }
}



public interface IDatabase
{
    void Connect();
    void Disconnect();
    string ExecuteQuery(string query);
}

public class Database : IDatabase
{
    // Implementation of IDatabase methods
    public void Connect()
    {
        Console.WriteLine("Connection to database established.");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnected from the database.");
    }

    public string ExecuteQuery(string query)
    {
        Console.WriteLine("Executing some query");
        return "Result";
    }
}

public class DatabaseGateway : IDatabase
{
    private readonly IDatabase _database;

    public DatabaseGateway(IDatabase database)
    {
        _database = database;
    }

    public void Connect()
    {
        _database.Connect();
    }

    public void Disconnect()
    {
        _database.Disconnect();
    }

    public string ExecuteQuery(string query)
    {
        return _database.ExecuteQuery(query);
    }
}