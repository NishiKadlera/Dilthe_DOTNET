using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask3
{
    internal class NullCoalescing
    {
        /// <summary>
        /// NullCoalescing
        /// </summary>
        public static void Main()
        {
            //declaring the null values to the variable
            int? a=null;
            float? b=3.12f;
            string? g=null;
            string? c= "Everyone";
            string? e="Good Evening!";
            
            //working of null coalescing--takes the first not null value
            double? d = a ?? b;//a has null value, b has float value--so d takes the value of b
            string? f = g ?? c ?? e;//g has null value, c,e has string value--so f takes the first not null value(c-Evening)
            
            Console.WriteLine($"The value of c is: {d}");
            Console.WriteLine($"The value of f is: {f}");
        }
    }
}
