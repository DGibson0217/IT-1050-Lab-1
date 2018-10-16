using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Project_2
{
    class Person
    {
        // Public member variables
        
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
        public double SumofAllAges;
        public string GetFullName()

        {
            return this.FirstName + " " + this.LastName;
        }
        public void PrintNameAndAges()
        {
            Console.WriteLine("My name is " + this.FirstName);
            Console.WriteLine("My age is" + this.Age);
        }

    }
}


