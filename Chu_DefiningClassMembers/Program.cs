using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_DefiningClassMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derivedClass = new MyDerivedClass();
            derivedClass.MyString = "Never gonna give you up.";
            Console.WriteLine(derivedClass.GetString());
        }
    }
    public class MyClass
    {
        private string myString;
        public virtual string GetString()
        {
            return myString;
        }
        public string MyString
        {
            set { myString = value; }
        }
    }
    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            return base.GetString() + " (output from the derived class)";
        }
    }
}
