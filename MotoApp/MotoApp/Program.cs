using MotoApp.Data;
using MotoApp.Entites;
using MotoApp.Repositories;

//var employeeRepository = new GenericReposiotry<Employee>();
//employeeRepository.Add(new Employee { FirstName = "Arek" });
//employeeRepository.Add(new Employee { FirstName = "Paweł" });
//employeeRepository.Add(new Employee { FirstName = "Ania" });
//employeeRepository.Save();

var sqlRepository = new SqlRepository(new MotoAppDbContext());
sqlRepository.Add(new Employee { FirstName = "Arek" });
sqlRepository.Add(new Employee { FirstName = "Paweł" });
sqlRepository.Add(new Employee { FirstName = "Ania" });
sqlRepository.Save();
var emp = sqlRepository.GetById(2);
Console.WriteLine(emp);


