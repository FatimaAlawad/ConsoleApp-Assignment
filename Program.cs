// Define an interface called IQuittable
// This interface forces any class that implements it to include a Quit method
interface IQuittable
{
void Quit(); // Method signature only (no body)
}

// Employee class that implements IQuittable
class Employee : IQuittable
{
// Property to store employee name
public string Name { get; set; }

// Property to store employee ID
public int Id { get; set; }

// Implementation of Quit method from interface
public void Quit()
{
Console.WriteLine(Name + " has quit the job.");
}
}

// Main program class
class Program
{
// Entry point of the console application
static void Main(string[] args)
{
// Create object using polymorphism
// Object type is IQuittable but actual object is Employee
IQuittable employee = new Employee()
{
Name = "Fatima",
Id = 101
};

// Call Quit method
employee.Quit();

// Prevent console from closing immediately
Console.ReadLine();
}
}
