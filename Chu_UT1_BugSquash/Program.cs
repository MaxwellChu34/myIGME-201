using Microsoft.Win32;
using System;

namespace UT1_BugSquash
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Contains the Main method and Power int function
     * Restrictions: None
     */
    class Program
    {
        /* Method: Main
         * Purpose: Fixes the errors in the program so that the computer can perform exponential operations
         * Restrictions: None
         */
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY (Compile-time)
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x^y.); (Compile-time)
            Console.WriteLine("This program calculates x^y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine(); (Run-time)
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
                int.TryParse(sNumber, out nY);
            } //while (int.TryParse(sNumber, out nX)); (Run-time)
            while (nY < 0);

            // compute the exponent of the number using a recursive function
            //nAnswer = Power(nX, nY); (Compile-time)
            Program pw = new Program();
            nAnswer = pw.Power(nX, nY);

            //Console.WriteLine("{nX} ^ {nY} = {nAnswer}"); (Logical)
            Console.WriteLine("{0} ^ {1} = {2}", nX, nY, nAnswer);
        }

        int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //returnVal = 0; (Logical)
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1); (Run-time)
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal; (Compile-time)
            return (returnVal);
        }
    }
}