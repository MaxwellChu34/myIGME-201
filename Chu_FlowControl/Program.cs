using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_FlowControl
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Contains the main method that has the entire programmed code
     * Restrictions: None
     */
    static internal class Program
    {
        /* Method: Main
         * Purpose: Answers #2 in PE4 where it requests that a program should be written based on #1. The computer asks the user to keep putting in two integers until both are less than 10.
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            //The program asks the user to implement two intergers. Each is stored in its own string variable and then converted to an integer in a separate integer variable.
            Console.WriteLine("Please input two integers");
            string inputVar1 = Console.ReadLine();
            string inputVar2 = Console.ReadLine();
            int var1 = Convert.ToInt32(inputVar1);
            int var2 = Convert.ToInt32(inputVar2);
            //The while loop will forever iterate until its condition that both numbers are less than 10 is fulfilled. It will then tell the user what two numbers they picked are.
            while ((var1 > 10) && (var2 > 10))
            {
                //If both numbers are greater than 10, the user is then forced to pick two new numbers until both are not.
                Console.WriteLine("Please input two new integers, both are greater than 10");
                inputVar1 = Console.ReadLine();
                inputVar2 = Console.ReadLine();
                //The process of converting each string into an integer is still occuring to check the condition.
                var1 = Convert.ToInt32(inputVar1);
                var2 = Convert.ToInt32(inputVar2);
            }
            Console.WriteLine("Your two numbers are " + var1 + " and " + var2);
        }
    }
}