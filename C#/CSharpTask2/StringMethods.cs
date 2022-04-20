using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    internal class StringMethods
    {
        public static void Main()
        {
            Console.WriteLine("String Methods\n**************************************");
            //declaring variables
            string x = "C#";
            string y = "Programming";

            //clone() method--duplicates a string
            string z = (string)x.Clone();
            Console.WriteLine(z);

            //concat() method
            Console.WriteLine(string.Concat(x, y));

            //Contains method-- checks whether a substring is present in a particular string or not and returns a boolean value
            string a = "GoodEvening";
            string b = "Evening";
            Console.WriteLine(a.Contains(b));

            //Copy() method--this method produces a copy of a particular string in another string
            string c = string.Copy(a);
            Console.WriteLine(c);

            //Equals() method--checks whether the two strings are equal or not, returns a boolean value
            Console.WriteLine(a.Equals(b));

            //IndexOf() method-- gives the index of character in a string
            int d= b.IndexOf('g');
            Console.WriteLine(d);

            //Substring() method--used to get a part of the string
            string e = a.Substring(4);
            Console.WriteLine(e);


        }
    }
}
