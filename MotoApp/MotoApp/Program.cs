using MotoApp.Data;
using MotoApp.Entites;
using MotoApp.Repositories;
using MotoApp.Repositories.Extensions;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext(), EmploeeAdded);
employeeRepository.ItemAdded += EmployeeRepositoryOnIyemAdded;

void EmployeeRepositoryOnIyemAdded(object? sender, Employee e)
{
    Console.WriteLine($"Employee added ==> {e.FirstName} from {sender?.GetType().Name}");
}

AddEmployees(employeeRepository);
//AddManagers(employeeRepository);
WriteAllToConsole(employeeRepository);

static void EmploeeAdded(object item)
{
    var employee = (Employee)item;
    Console.WriteLine($"{employee.FirstName} added");
}
static void AddEmployees(IRepository<Employee> repository)
{
    var employees = new[]
    {
    //new BusinessPartner {  },
    //new BusinessPartner {},
    //new BusinessPartner {}

    new Employee { FirstName = "Arek" },
    new Employee { FirstName = "Paweł" },
    new Employee { FirstName = "Ania" }
    };

    repository.AddBatch(employees);
}

//static void AddManagers(IWriteRepository<Employee> employeeRepository)
//{
//    employeeRepository.Add(new Manager { FirstName = "Franciszek" });
//    employeeRepository.Add(new Manager { FirstName = "Wiesław" });
//    employeeRepository.Add(new Manager { FirstName = "Hanna" });
//    employeeRepository.Save();
//}

static void WriteAllToConsole(IReadRepository<Employee> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}