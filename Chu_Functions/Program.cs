using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_Functions
{
    delegate string ReadLine(string readLine);
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Contains Main and Reading Methods
     * Restrictions: None
     */
    static internal class Program
    {
        /* Method: Main
         * Purpose: Asks the user to write anything, and then the computer will return it verbatim
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            //Declares, points, and calls the delegate function so that the computer will copy what the user exactly said
            ReadLine readingIt;
            Console.WriteLine("Please write anything in the following line, and the computer will return back what you said.");
            readingIt = new ReadLine(Reading);
            readingIt = Reading;
            Console.WriteLine(readingIt);
        }
        /* Method: Main
         * Purpose: Part of the delegate function where it replaces Console.ReadLine()
         * Restrictions: None
         */
        static string Reading(string readingLine)
        {
            readingLine = Console.ReadLine();
            return readingLine;
        }
    }
}
