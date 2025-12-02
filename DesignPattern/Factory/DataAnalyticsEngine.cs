namespace Factory
{
    public class DataAnalyticsEngine
    {
        private readonly IDatabase _database;
        public DataAnalyticsEngine(IDatabase database) { _database = database; }
        public void Analyze()
        {
            _database.Connect();
            Console.WriteLine(_database.ExecuteQuery("SELECT * FROM analytics_data"));
            _database.Disconnect();
        }
    }
}