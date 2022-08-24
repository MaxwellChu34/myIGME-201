using System;

namespace SquashTheBugs
{
    /* Class Program
     * Author: Maxwell Chu
     * Purpose: Program class has the Main function where the program is fixed
     * Restrictions: None
     */ 
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    //class Program
    static class Program
    {
        /* Method: Main
         * Purpose:Solution to all the bugs in the given exercise
         * Restrictions: None
         */ 
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            //string allNumbers intialized outside the for loop as empty
            string allNumbers = string.Empty;
            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i)
            //for loop is changed so that it is intialized and starts at 1 to equal to 10
            for (int i = 1; i <= 10; i++)
            {
                // declare string to hold all numbers
                //string allNumbers = null;

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.WriteLine(i + "/" + (i - 1) + " = ");
                //if statement to say that the first solution is undefined because it is dividing by 0
                if (i > 1)
                {
                    // output the calculation based on the numbers
                    Console.WriteLine(i / (i - 1));

                    // concatenate each number to allNumbers
                    //allNumbers += i + " ";
                    //each i value that has been successfully processed is concatenated onto the string
                    allNumbers = String.Concat(allNumbers, i.ToString());
                    allNumbers += " ";
                } else if (i == 1)
                {
                    Console.WriteLine("Undefined");
                }
                
                // increment the counter
                //i = i + 1;
                //Counter has been deleted because its unneccessary
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            //+ sign has been added onto the write line to fix error
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}