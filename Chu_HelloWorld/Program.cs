using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_HelloWorld
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Program class has the Main function where all lines of this program were created
     * Restrictions: None
     */
    static internal class Program
    {
        /* Method: Main
         * Purpose: Main function holds printed lines to console, variables, math calculations, loops, etc.
         * Restrictions: None
         */ 
        static void Main(string[] args)
        {
            //The console prints my name
            Console.WriteLine("Maxwell Chu");
            //Intialized integers for future math calculations
            int firstNum = 1;
            int secondNum = 2;
            //Used addition, subtraction, multiplication, division, and modulus calculations
            int thirdNum = firstNum + secondNum;
            int fourthNum = thirdNum - firstNum;
            int fifthNum = secondNum * secondNum;
            int sixthNum = fifthNum / secondNum;
            int seventhNum = thirdNum % secondNum;
            //Printed all 5 different results to the console
            Console.WriteLine(thirdNum);
            Console.WriteLine(fourthNum);
            Console.WriteLine(fifthNum);
            Console.WriteLine(sixthNum);
            Console.WriteLine(seventhNum);
            //Intialized both implicit and explicit variables and printed them to the console
            double implicitNum = 4.4;
            int explicitNum = (int)implicitNum;
            Console.WriteLine(implicitNum);
            Console.WriteLine(explicitNum);
            //Setup if statement so that when the seventh number is 1, the console prints that it is true
            if (seventhNum == 1)
            {
                Console.WriteLine("True");
            }
            //Setup for loop so that it prints the value of x 5 times from 0 to 4
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("x is " + x);
            }
            //Setup while loop so that while the third number is 3, the console prints it until it changes to 4
            while (thirdNum == 3)
            {
                Console.WriteLine(thirdNum);
                thirdNum = 4;
            }
        }
    }
}