namespace Factory
{
    public class OracleDatabase : IDatabase
    {
        public void Connect() => Console.WriteLine("Connected to Oracle DB");
        public void Disconnect() => Console.WriteLine("Disconnected from Oracle DB");
        public string ExecuteQuery(string query) => $"Oracle execution result: {query}";
    }
}