using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_UT1_RaisesAndSalariesRewritten
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Contains the Main method
     * Restrictions: NOne
     */
    internal class Program
    {
        struct employee
        {
            //struct contains two public variables
            public string sName;
            public double dSalary;
        }

        /* Method: Main
         * Purpose: Rewrites the RaisesAndSalaries Program so that a struct is in place
         */
        static void Main(string[] args)
        {
            //Intializes the employee struct into the main method and applies values
            employee userName = new employee();
            userName.dSalary = 30000;
            Console.WriteLine("What is your name?");
            userName.sName = Console.ReadLine();
            //struct is the only parameter and is referenced
            bool raise = Program.GiveRaise(ref userName);
            if (raise == true)
            {
                Console.WriteLine("Congratulations on the raise!");
                Console.WriteLine("Your new salary is: $" + userName.dSalary);
            }
            else
            {
                Console.WriteLine("Your salary is: $" + userName.dSalary);
            }
        }
        static bool GiveRaise(ref employee user)
        {
            if (user.sName.ToLower() == "max")
            {
                user.dSalary += 19999.99;
                return (true);
            }
            return (false);
        }
    }
}