using Factory;
using Adapter;
using Observer;

class Program
{
    static void Main()
    {
        var db = DatabaseFactory.CreateDatabase("mysql");
        var engine = new DataAnalyticsEngine(db);
        engine.Analyze();

        var hr = new HRSystem();
        var adapter = new EmployeeAdapter();
        adapter.ProcessEmployees(hr.Employees);

        var publisher = new MessagePublisher();
        var sub1 = new MobileSubscriber("Alice");
        var sub2 = new MobileSubscriber("Bob");
        publisher.Subscribe(sub1);
        publisher.Subscribe(sub2);
        publisher.Notify("New iPhone discount");
        publisher.Unsubscribe(sub1);
        publisher.Notify("Samsung models updated");
    }
}