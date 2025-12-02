namespace Factory
{
    public class PostgreSQLDatabase : IDatabase
    {
        public void Connect() => Console.WriteLine("Connected to PostgreSQL");
        public void Disconnect() => Console.WriteLine("Disconnected from PostgreSQL");
        public string ExecuteQuery(string query) => $"PostgreSQL execution result: {query}";
    }
}