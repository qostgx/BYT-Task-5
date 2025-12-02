namespace Factory
{
    public class MySQLDatabase : IDatabase
    {
        public void Connect() => Console.WriteLine("Connected to MySQL");
        public void Disconnect() => Console.WriteLine("Disconnected from MySQL");
        public string ExecuteQuery(string query) => $"MySQL execution result: {query}";
    }
}