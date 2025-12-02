namespace Adapter
{
    public class BillingSystem
    {
        public void ProcessSalary(string name, string department, int salary)
        {
            Console.WriteLine($"{name} from {department} receives salary {salary}.");
        }
    }
}