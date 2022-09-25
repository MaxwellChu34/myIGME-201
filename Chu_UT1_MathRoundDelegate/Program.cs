using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_UT1_MathRoundDelegate
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Contains the Main method
     * Restrictions: None
     */
    internal class Program
    {
        delegate int roundingFunction(double a);
        /* Method: Main
         * Purpose: Rounds a decimal number of the user's choice
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            //The delegate function calls makes up the variable
            roundingFunction findEstimate;
            Console.WriteLine("Please enter a number with decimals");
            string userNum = Console.ReadLine();
            double num = double.Parse(userNum);
            //The variable creates a new function called RoundTheNumber and returns the rounded number from the user
            findEstimate = new roundingFunction(RoundTheNumber);
            int answer = findEstimate(num);
            Console.WriteLine("The rounded number is " + answer);
        }

        static int RoundTheNumber(double number)
        {
            //The number parameter takes in from the user's entry and then is sent to return the rounded number
            int roundNum = (int)Math.Round(number);
            return (roundNum);
        }
    }
}
