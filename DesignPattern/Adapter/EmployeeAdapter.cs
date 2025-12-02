namespace Adapter
{
    public class EmployeeAdapter
    {
        private readonly BillingSystem _billing = new BillingSystem();
        public void ProcessEmployees(string[] hrEmployees)
        {
            foreach (var employee in hrEmployees)
            {
                var parts = employee.Split(",");
                string name = parts[0].Trim();
                string department = parts[1].Trim();
                int salary = int.Parse(parts[2].Trim());
                _billing.ProcessSalary(name, department, salary);
            }
        }
    }
}