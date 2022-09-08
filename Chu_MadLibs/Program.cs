using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace Chu_MadLibs
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Provides the main method that contains all code programmed
     * Restrictions: None
     */
    static internal class Program
    {
        /* Method: Main
         * Purpose: Constructs a mad lib game that gives the user many options in inputs. The user can decide to play, pick a story, and choose which words to put in. 
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            //The computer finds the text file that's specifically located somewhere in itself. it reads thoroughly and sends it to a string. That separates into different stories depending on the story.
            StreamReader input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");
            string template = input.ReadToEnd();
            string[] templateLines = template.Split('\n');
            //The string "newWord" is what is meant to add to the end result string.
            string resultString = "";
            string newWord;
            //The user is asked whether or not they want to play Mad Libs. It isn't case sensitive, and if the user says no, the entire program ends.
            Console.WriteLine("Do you want to play Mad Libs?");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            while ((answer != "yes") && (answer != "no"))
            {
                Console.WriteLine("Please answer again, type yes or no.");
                answer = Console.ReadLine();
                answer = answer.ToLower();
            }
            if (answer == "no")
            {
                Console.WriteLine("Goodbye");
                return;
            }
            Console.WriteLine("What is your name?");
            Console.ReadLine();
            Console.WriteLine("Choose a story by entering a number between 1 and " + templateLines.Length);
            string chosenLine = Console.ReadLine();
            int chosen = Convert.ToInt32(chosenLine);
            Console.WriteLine("Please type a word that matches with the part of speech or term needed.");
            string[] words = templateLines[chosen - 1].Split(' ');
            //The program iterates through each value in the array to separate each word.
            foreach (string word in words)
            {
                //The word value that contains the characters for an escape sequence is replaced with the actual escape sequence.
                if (word == "\\n")
                {
                    newWord = word.Replace(word, "\n");
                    resultString += newWord;
                } //Words that have their first character be a bracket is then sent to ask the user to replace what is needed.
                else if (word[0] == '{')
                {
                    newWord = word.Replace("{", "").Replace("}", "").Replace("_", "");
                    Console.WriteLine(newWord + ":");
                    newWord = Console.ReadLine();
                    resultString += newWord + " ";
                } else
                {
                    resultString += word + " ";
                }
            }
            Console.WriteLine(resultString);
        }
    }
}