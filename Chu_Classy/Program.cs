using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_Classy
{
    /* Class: Program
         * Author: Maxwell Chu
         * Purpose: Holds the main method
         * Restrictions: None
     */
    internal class Program
    {
        /* Method: Main
         * Purpose: Calls MyMethod that calls other classes
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            //Calls the method first and second
            MyMethod(new First());
            MyMethod(new Second());
        }
        public static void MyMethod(object myObject)
        {
            //Creates variables and sends it to each class
            First first = new First();
            Second second = new Second();
            first.Example();
            second.Example();
        }
    }
    public interface IInterface
    {
        void Example();
    }
    public class First : IInterface
    {
        public void Example()
        {
            //When the first example is called
            Console.WriteLine("This is from the first class");
        }
    }
    public class Second : IInterface
    { 
        public void Example()
        {
            //When the second example is called
            Console.WriteLine("This is from the second class");
        }
    }
}
