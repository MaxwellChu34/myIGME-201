using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_ParsingAndFormatting
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Holds the main method and all the code within it
     * Restrictions: None
     */
    static internal class Program
    {
        /* Method: Main
         * Purpose: Generates a random number which the user has to guess within 8 turns or less. Different outcomes are given depended on certain circumstances of the guesses.
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);
            //userNumber will be converted into an int and sent to the checkNumber variable. The for loop counter is a global variable so that the computer can say how many turns it took to complete.
            string userNumber;
            int checkNumber;
            int i;
            Console.WriteLine(randomNumber);
            for(i = 1; i <= 8; i++)
            {
                Console.WriteLine("Turn #" + i + ": Enter your guess that is between 1 and 100: ");
                userNumber = Console.ReadLine();
                checkNumber = Convert.ToInt32(userNumber);
                //Depending on how the number is compared to the random number generated, the computer would say it is too low, high, or that it is invalid.
                if((checkNumber < randomNumber) && (checkNumber > 0))
                {
                    Console.WriteLine("Too low");
                }
                if ((checkNumber > randomNumber) && (checkNumber < 101))
                {
                    Console.WriteLine("Too high");
                }
                if ((checkNumber < 1) || (checkNumber > 100))
                {
                    Console.WriteLine("Invalid guess - try again");
                    //The for loop iterates at the same number again until the user inputs a number in the correct range.
                    i = i - 1;
                }
                //The for loop will completely skip any future iterations if the user gusses the random number correctly.
                if (checkNumber == randomNumber)
                {
                    break;
                }
            }
            //This if loop will only occur if the for loop is completely iterated, so i would equal 9. The return line stops the function and ultimately skips over the next line which is for if the user does guess it.
            if (i > 8)
            {
                Console.WriteLine("You ran out of turns. The number was " + randomNumber);
                return;
            }
            Console.WriteLine("Correct! You won in " + i + " turns");
        }
    }
}