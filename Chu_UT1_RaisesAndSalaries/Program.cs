using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_UT1_RaisesAndSalaries
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Contains the Main Method and the GiveRaise bool function
     * Restrictions: None
     */
    internal class Program
    {
        /* Method: Main
         * Purpose: Asks the user for their name, and if its "max" the user gets a raise
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;
            //Computer asks user for the name and the result is sent to a variable
            Console.WriteLine("What is your name?");
            sName = Console.ReadLine();
            //Bool function is called with two parameters
            bool raise = Program.GiveRaise(sName, ref dSalary);
            //If the returned value is true, then the if statement occurs. Otherwise else.
            if(raise == true)
            {
                Console.WriteLine("Congratulations on the raise!");
                Console.WriteLine("Your new salary is: $" + dSalary);
            }
            else
            {
                Console.WriteLine("Your salary is: $" + dSalary);
            }
        }
        static bool GiveRaise(string name, ref double salary)
        {
            //If the user's name is mine, then the salary variables increases and returns the truth value. Otherwise false.
            if(name.ToLower() == "max")
            {
                salary += 19999.99;
                return (true);
            }
            return (false);
        }
    }
}
