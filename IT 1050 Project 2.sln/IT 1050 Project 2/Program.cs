using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {// Person 1
            Person p1 = new Person();
            Person Spouse1 = new Person();
            Console.WriteLine("What is your First Name?");
            p1.FirstName = Console.ReadLine();

            Console.WriteLine("What is your Last Name?");
            p1.LastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            p1.Age = int.Parse(Console.ReadLine());

            p1.PrintNameAndAges();

            Console.WriteLine("What is your Spouse's Name?");
            p1.Spouse.FirstName = Console.ReadLine();

            Console.WriteLine("What is your Spouse's Age?");
            p1.Spouse.Age = int.Parse(Console.ReadLine());

            p1.Spouse.PrintNameAndAges();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            // Person 2

            Person p2 = new Person();
            Person Spouse2 = new Person();
            Console.WriteLine("What is your First Name?");
            p2.FirstName = Console.ReadLine();

            Console.WriteLine("What is your Last Name?");
            p2.LastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            p1.Age = int.Parse(Console.ReadLine());

            p2.PrintNameAndAges();

            Console.WriteLine("What is your Spouse's Name?");
            p1.Spouse.FirstName = Console.ReadLine();

            Console.WriteLine("What is your Spouse's Age?");
           

            p2.Spouse.PrintNameAndAges();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
          



        }
    }
}
