using MotoApp.Entites;
using MotoApp.Repositories;

var employeeRepository = new GenericReposiotry<Employee, int>();
employeeRepository.Add(new Employee { FirstName = "Arek" });
employeeRepository.Add(new Employee { FirstName = "Paweł" });
employeeRepository.Add(new Employee { FirstName = "Ania" });
employeeRepository.Save();
