namespace Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(string type)
        {
            return type.ToLower() switch
            {
                "mysql" => new MySQLDatabase(),
                "oracle" => new OracleDatabase(),
                "postgres" => new PostgreSQLDatabase(),
                _ => throw new ArgumentException("Unsupported database type.")
            };
        }
    }
}