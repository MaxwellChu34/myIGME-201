using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Chu_VariablesAndExpressions
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: To house the Main method and all of its programming code
     * Restrictions: None
     */ 
    static internal class Program
    {
        /* Method: Main
         * Purpose: To fulfill Problem #5 in PE3 where it was stated to inquire the user to enter 4 integers and then state the product.
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            //The console asks the user to input four intergers. The next four lines allow the user to enter any integer they want and it will send it to each string variable
            Console.WriteLine("Please enter four integers.");
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();
            string value3 = Console.ReadLine();
            string value4 = Console.ReadLine();
            //Each string value gets converted into an integer respectively so that any mathematical operation can occur
            int numValue1 = Convert.ToInt32(value1);
            int numValue2 = Convert.ToInt32(value2);
            int numValue3 = Convert.ToInt32(value3);
            int numValue4 = Convert.ToInt32(value4);
            //The product of all four integers is then sent back to the console and gives the reader the product of all numbers they inputed.
            int product = numValue1 * numValue2 * numValue3 * numValue4;
            Console.WriteLine("The product of these four integers is " + product);
        }
    }
}