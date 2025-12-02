namespace Factory
{
    public interface IDatabase
    {
        void Connect();
        void Disconnect();
        string ExecuteQuery(string query);
    }
}