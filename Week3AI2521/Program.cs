// See https://aka.ms/new-console-template for more information

using Week3AI2521;

//List<Employee> employeeList = new List<Employee>();
//Employee e1 = new Employee("Alice", 50000);
//Manager m1 = new Manager("Bob", 60000, 10000);  
//SalesPerson s1 = new SalesPerson("Charlie", 40000, 0.1, 200000);

//employeeList.Add(e1);
//employeeList.Add(m1);
//employeeList.Add(s1);
//double total = 0;
//foreach(Employee e in employeeList)
//{
//    Console.WriteLine($"Name: {e.Name}, Pay: {e.calculatePay()}");
//    total += e.calculatePay();
//}
//Console.WriteLine($"Total = {total}");

//Student s1 = new Student();
//s1.Login();
//Lecturer l1 = new Lecturer();
//l1.Login();

//Cat cat1 = new Cat();
//Dog dog = new Dog();
//Animal animal = new Animal();

//List<Book> bookList = new List<Book>([new DigitalEbook(1200,100),new PhysicalPaperBook(1500,200,200)]); 

//foreach(Book b in bookList)
//{
//    Console.WriteLine($"Net Profit: {b.calculateNetProfit()}");
//}

Rectangle r1 = new Rectangle("Rectangle 1",2,3);
Circle c1 = new Circle("Circle 1", 7);

Console.WriteLine($"{r1.Name} {r1.CalculateArea()}");
Console.WriteLine($"{c1.Name} {c1.CalculateArea()}");
