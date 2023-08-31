using MotoApp.Data;
using MotoApp.Entites;
using MotoApp.Repositories;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
AddEmployees(employeeRepository);
AddManagers(employeeRepository);
WriteAllToConsole(employeeRepository);

static void AddEmployees(IRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Arek" });
    employeeRepository.Add(new Employee { FirstName = "Paweł" });
    employeeRepository.Add(new Employee { FirstName = "Ania" });
    employeeRepository.Save();
}

static void AddManagers(IWriteRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Manager { FirstName = "Franciszek" });
    employeeRepository.Add(new Manager { FirstName = "Wiesław" });
    employeeRepository.Add(new Manager { FirstName = "Hanna" });
    employeeRepository.Save();
}

static void WriteAllToConsole(IReadRepository<Employee> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}