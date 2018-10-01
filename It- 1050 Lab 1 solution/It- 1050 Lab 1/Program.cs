using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It__1050_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part1

            string firstName;
            string middleName;
            String lastName;
           
            System.Console.Write("What is your First Name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your Middle Name: ");
            middleName = System.Console.ReadLine();

            System.Console.Write("What is your Last Name: ");
            lastName = System.Console.ReadLine();

            String fullName = firstName + " " + middleName + " " + lastName;

            System.Console.WriteLine(fullName);

            System.Threading.Thread.Sleep(3000);
            #endregion

            #region part2
            const double multiplier = 2.54;
            const int inchesInFoot = 12;
           

            System.Console.Write("Height In Feet: ");
            int heightInFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("Extra Inches: ");
            double heightInInches = double.Parse(System.Console.ReadLine());

            double inches = inchesInFoot * heightInFeet;
            inches += heightInInches;

            double centimeters = inches * multiplier;

            System.Console.WriteLine(centimeters);

            System.Threading.Thread.Sleep(3000);
            #endregion part2

            #region part3
            System.Console.Write("How old are you?:");
            int age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a citizen of America?:");
            bool isCitizen = bool.Parse(System.Console.ReadLine());

            bool canVote = age > 17 && isCitizen;

            System.Console.WriteLine(canVote);

            System.Threading.Thread.Sleep(3000);

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();

            #endregion part3





        }

    }
}
