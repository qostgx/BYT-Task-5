namespace Observer
{
    public class MobileSubscriber : IMessageSubscriber
    {
        private readonly string _name;
        public MobileSubscriber(string name) { _name = name; }
        public void Update(string message)
        {
            Console.WriteLine($"{_name} received message: {message}");
        }
    }
}