
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19JulyConstructorEx
{
    internal class program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            employee.Display();
            Console.WriteLine("Let us go for Registration!!!");
            employee.Register();
            employee.Display();
            Console.ReadKey();
        }
    }
}