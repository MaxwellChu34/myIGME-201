using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_MoreAboutVariables
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Houses the main method
     * Restrictions: None
     */
    static internal class Program
    {
        /* Method: Main
         * Purpose: Answers the 4 questions in PE8 that require a program; to view a specific one, comment the rest out
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            //5
            //3D array Double that stores the x, y, and z variables
            double[,,] xyz = new double[21,31,3];
            double x;
            double y;
            double z;
            int xRange;
            int yRange;
            string pick;
            //Nested for loop displays sets up coordinates for array
            for (xRange = 0; xRange < 21; xRange++)
            {
                for(yRange = 0; yRange < 31; yRange++)
                {
                    //Coordinates are then converted to the respected ranges and then calculated to solve z
                    x = ((Convert.ToDouble(xRange) / 10) - 1);
                    y = ((Convert.ToDouble(yRange) / 10) + 1);
                    z = (3 * (y * y)) + (2 * x) - 1;
                    //Each variable is then implemented into a certain location in the array
                    xyz[xRange, yRange, 0] = x;
                    xyz[xRange, yRange, 1] = y;
                    xyz[xRange, yRange, 2] = z;
                }
            }
            //The user is asked to pick a coordinate of their choice, and the outcomes are the variables that were calculated beforehand
            Console.WriteLine("Please pick a number from 0 to 20");
            pick = Console.ReadLine();
            xRange = Convert.ToInt32(pick);
            Console.WriteLine("Please pick another number from 0 to 30");
            pick = Console.ReadLine();
            yRange = Convert.ToInt32(pick);
            Console.WriteLine("You have chosen the x, y, and z variables");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(xyz[xRange, yRange, i]);
            }
            //7
            //A user's response is sent to a string and converted into a char array
            Console.WriteLine("Please write anything");
            string userInput = Console.ReadLine();
            char[] characterOrder = userInput.ToCharArray();
            string reverse = "";
            //The array is then read backwards and added to a new array to be sent out for the user
            for (int i = characterOrder.Length - 1; i > -1; i--)
            {
                reverse += characterOrder[i];
            }
            Console.WriteLine("Here is the reverse of what you typed");
            Console.WriteLine(reverse);
            //8
            //The user's reponse is split by spaces and commas
            Console.WriteLine("Please type anything (Preferable with the word 'no'); Don't worry about case sensitivity");
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(' ', ',');
            string newWord;
            string newPhrase = "";
            //The computer iterates through the string array that the phrase was sent to in order to see which contains the word "no" with and without a comma
            foreach(string word in words)
            {
                if((word == "no") || (word == "No") || (word == "nO") || (word == "NO"))
                {
                    //The word is replaced with "yes" if the following conditions are met and a new phrase is then sent to the console
                    newWord = word.Replace(word, "yes");
                    newPhrase += newWord + " ";
                } else if ((word == "no,") || (word == "No,") || (word == "nO,") || (word == "NO,"))
                {
                    newWord = word.Replace(word, "yes,");
                    newPhrase += newWord + " ";
                }
                else
                {
                    newPhrase += word + " ";
                }
            }
            Console.WriteLine(newPhrase);
            //9
            //The original phrase the user enters is sent to an array and split by spaces
            Console.WriteLine("Please type anything");
            string regularPhrase = Console.ReadLine();
            string[] regularWords = regularPhrase.Split(' ');
            string doubleQuotedWord;
            string doubleQuotedPhrase = "";
            //Each word is then replaced with a new one that is double quoted and sent back to the console
            foreach (string word in regularWords)
            {
                doubleQuotedWord = word.Replace(word, "\""+word+"\"");
                doubleQuotedPhrase += doubleQuotedWord + " ";
            }
            Console.WriteLine(doubleQuotedPhrase);
        }
    }
}