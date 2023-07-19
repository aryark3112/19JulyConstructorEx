using System;
namespace _19JulyConstructorEx
{

    public class Employee
    {
        int id;
        string name;
        public Employee()
        {
            Console.WriteLine("Constructor of Employee");
            id = -1;
            name = "not given";
        }
        public void Register()
        {
            Console.WriteLine("Enter id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
        }
        public void Display()

        {
            Console.WriteLine("ID:\t" + id);
            Console.WriteLine("Name:\t" + name);
        }
    }
}
