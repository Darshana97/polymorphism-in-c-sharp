using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{

    class Employee
    {
        public string FirstName = "Darshana";
        public string LastName = "Senevirathna";

       public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.ReadLine();
        }

    }

    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Full time");
            //Console.ReadLine();
        }
    }

    class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Part time");
            //Console.ReadLine();
        }

    }

    class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Temporary");
            //Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee e in employees)
            {
                e.PrintFullName();
               
            }

            
            

        }
    }
}
