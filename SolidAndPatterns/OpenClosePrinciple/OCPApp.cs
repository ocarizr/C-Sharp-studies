namespace OpenClosePrinciple
{
    public class OCPApp
    {
        public void Run()
        {
            var applicants = new List<IApplicant>()
            {
                new PersonModel {FirstName = "Rafael", LastName = "Ocariz" },
                new ManagerModel {FirstName = "Giovanna", LastName = "Neves" },
                new PersonModel {FirstName = "Luna", LastName = "Mota" },
                new PersonModel {FirstName = "Apolo", LastName = "Barbero" }
            };

            var employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress}. Is Manager: {employee.IsManager}");
            }
        }
    }
}
