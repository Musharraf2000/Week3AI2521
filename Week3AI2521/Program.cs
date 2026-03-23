// See https://aka.ms/new-console-template for more information

using Week3AI2521;

List<Employee> employeeList = new List<Employee>();
Employee e1 = new Employee("Alice", 50000);
Manager m1 = new Manager("Bob", 60000, 10000);  
SalesPerson s1 = new SalesPerson("Charlie", 40000, 0.1, 200000);

employeeList.Add(e1);
employeeList.Add(m1);
employeeList.Add(s1);
double total = 0;
foreach(Employee e in employeeList)
{
    Console.WriteLine($"Name: {e.Name}, Pay: {e.calculatePay()}");
    total += e.calculatePay();
}
Console.WriteLine($"Total = {total}");
