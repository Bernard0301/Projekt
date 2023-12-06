// 2. Stwórz 3 pracowników i dodaj po 5 ocen od 1 do 10

using Projekt_dzień_6;
using System.Reflection.Metadata;

Employee employee1 = new Employee("Paweł", "Kowalski", 34);
Employee employee2 = new Employee("Robert", "Nowak", 41);
Employee employee3 = new Employee("Sebastian", "Dres", 24);

employee1.AddScore(3);
employee1.AddScore(2);
employee1.AddScore(8);
employee1.AddScore(7);
employee1.AddScore(5);

employee2.AddScore(5);
employee2.AddScore(2);
employee2.AddScore(3);
employee2.AddScore(1);
employee2.AddScore(10);

employee3.AddScore(3);
employee3.AddScore(8);
employee3.AddScore(4);
employee3.AddScore(9);
employee3.AddScore(10);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

List<Employee> employees2 = new List<Employee>();

int MaxValue = 0;
Employee employeeMaxPoints = null;

foreach (var empl in employees)
{
    if (empl.Result > MaxValue)
    {
        employeeMaxPoints = empl;
        MaxValue = empl.Result;
    }
}

Console.WriteLine("pracownik" + " " + employeeMaxPoints.Name + " " + employeeMaxPoints.Surname + " " + "lat" + " "+ employeeMaxPoints.Age + " " + "uzyskał najlepsz wynik" + " " + employeeMaxPoints.Result + " " + "punktów");
 










