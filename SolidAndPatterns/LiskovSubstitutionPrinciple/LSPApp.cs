namespace LiskovSubstitutionPrinciple
{
    public class LSPApp
    {
        public void Run()
        {
            IManager manager = new Manager();
            manager.FirstName = "Giovanna";
            manager.LastName = "Neves";
            manager.CalculatePerHourRate(4);

            IManaged employee = new Employee();

            employee.FirstName = "Rafael";
            employee.LastName = "Ocariz";
            employee.CalculatePerHourRate(5);
            employee.AssignManager(manager);

            Console.WriteLine($"{employee.FirstName} {employee.LastName} salary is ${employee.Salary}/hour.");

            manager.GeneratePerformanceReview();
            (manager as CEO)?.FireSomeone(employee);
        }
    }
}
