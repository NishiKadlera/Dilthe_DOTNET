using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask3
{
    internal class Nullables
    {
        
        /// <summary>
        /// Working of Nullables
        /// </summary>
        public static void Main()
        {
            //Declaring the variables
            int? num1 = 10;
            int? num2 = null;//syntax for nullables--a question mark next to datatype
            float? num3 = null;
            double? num4 = null;
            char? num6 = null;
            string? str7 = null;
            Nullable<float> num5 = null;//another syntax for nubllables--Nullables follwed by the datatype within angular brackets

            Console.WriteLine($"The int value is:{num1}");
            Console.WriteLine($"The int value is:{num2}");
            Console.WriteLine($"The float value is:{num3}");
            Console.WriteLine($"The double value is:{num4}");
            Console.WriteLine($"The character value is:{num6}");
            Console.WriteLine($"The string value is:{str7}");
            Console.WriteLine($"The float value is:{num5}");






        }
    }
}
