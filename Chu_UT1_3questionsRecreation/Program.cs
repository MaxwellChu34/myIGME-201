using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Net;

namespace Chu_UT1_3questionsRecreation
{
    /* Class: Program
     * AUthor: Maxwell Chu
     * Purpose: Contains the Main method
     * Restrictions: None
     */
    internal class Program
    {
        /* Method: Main
         * Purpose: Recreates the 3questions.exe program
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            string correctOne = "black";
            string correctTwo = "42";
            string correctThree = "What do you mean? Arican or European swallow?";
            string userAnswer = "";
            var stopwatch = new Stopwatch();
        //The program reverts back to here every time the user wants to play again
        start:
            stopwatch.Reset();
            Console.WriteLine("Choose your question (1-3): ");
            string userChoice = Console.ReadLine();
            int choice = Convert.ToInt32(userChoice);
            Console.WriteLine("You have 5 seconds to answer the following question:");
            stopwatch.Start();
            //The question changes depending on the user's choice
            if (choice == 1)
            {
                Console.WriteLine("What is your favorite color?");
                userAnswer = Console.ReadLine();
                //The timer elapses once the user answers and determines whether 5 seconds are up or not
                TimeSpan overtime = stopwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", overtime.Hours, overtime.Minutes, overtime.Seconds, overtime.Milliseconds / 10);
                if (overtime.Seconds >= 5)
                {
                    do
                    {
                        Console.WriteLine("Times up!");
                        Console.WriteLine("The answer is: " + correctOne);
                        break;
                    } while (overtime.Seconds >= 5);
                }
                //If the user answers within less than 5 seconds, the computer checks if the user answered correctly
                if((overtime.Seconds < 5) && (userAnswer == correctOne))
                {
                    Console.WriteLine("Well done!");
                } else if (overtime.Seconds < 5)
                {
                    Console.WriteLine("Wrong! The answer is: " + correctOne);
                }
            } else if (choice == 2)
            {
                Console.WriteLine("What is the answer to life, the universe and everything?");
                userAnswer = Console.ReadLine();
                TimeSpan overtime = stopwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", overtime.Hours, overtime.Minutes, overtime.Seconds, overtime.Milliseconds / 10);
                if (overtime.Seconds >= 5)
                {
                    do
                    {
                        Console.WriteLine("Times up!");
                        Console.WriteLine("The answer is: " + correctTwo);
                        break;
                    } while (overtime.Seconds >= 5);
                }
                if ((overtime.Seconds < 5) && (userAnswer == correctTwo))
                {
                    Console.WriteLine("Well done!");
                }
                else if (overtime.Seconds < 5)
                {
                    Console.WriteLine("Wrong! The answer is: " + correctTwo);
                }
            }
            else
            {
                Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                userAnswer = Console.ReadLine();
                TimeSpan overtime = stopwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", overtime.Hours, overtime.Minutes, overtime.Seconds, overtime.Milliseconds / 10);
                if (overtime.Seconds >= 5)
                {
                    do
                    {
                        Console.WriteLine("Times up!");
                        Console.WriteLine("The answer is: " + correctThree);
                        break;
                    } while (overtime.Seconds >= 5);
                }
                if ((overtime.Seconds < 5) && (userAnswer == correctThree))
                {
                    Console.WriteLine("Well done!");
                }
                else if (overtime.Seconds < 5)
                {
                    Console.WriteLine("Wrong! The answer is: " + correctThree);
                }
            }
            //If the user answers anything remotely related to the answer "yes", the program repeats until otherwise
            Console.WriteLine("Play again?");
            string retryChoice = Console.ReadLine();
            if (retryChoice.ToLower().StartsWith("y"))
            {
                Console.WriteLine();
                goto start;
            }
        }
    }
}