using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    internal class StringBuilderMethods
    {
        
        public static void Main()
        {
            Console.WriteLine("StringBuilder Method\n");
            //stringbuilder creation
            StringBuilder sb = new StringBuilder("Hello Everyone!!");
            Console.WriteLine(sb.ToString());
            Console.WriteLine();

            //stringbuilder methods-append, remove, append line,insert replace

            //Append method- adds the string at the end of the line
            sb.Append("My name is John.");
            Console.WriteLine(sb);
            Console.WriteLine();

            //Append line-adds the string at the end of the line
            sb.AppendLine("I'm 22 years old.");
            Console.WriteLine(sb);

            //Replace method-replaces one word with another in string
            sb.Replace("old","of age");
            Console.WriteLine(sb);

            //Insert method--allows to insert any text at a specified index value
            sb.Insert(16, "Good Evening!");
            Console.WriteLine(sb);

            //Remove method--removes the character from the specified index position and number of characters mentioned
            sb.Remove(16, 12);
            Console.WriteLine(sb);




        }


    }
}
