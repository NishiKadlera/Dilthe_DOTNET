using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    /// <summary>
    /// Bitwise operator
    /// </summary>
    internal class BitwiseOperator
    {

        public static void Main()
        {
            //declaring the variables
            int num1 = 10;  //1010
            int num2 = 5;   //0101
            int num3;

            //AND operator
            num3 = 10 & 5;  //0000--0
            Console.WriteLine(num3);

            //OR Operator
            num3 = 10 | 5;  //1111-- 15
            Console.WriteLine(num3);

            //XOR operator
            num3 = 10 ^ 5;  //1111-- 15
            Console.WriteLine(num3);

            //bitwise complement(~-tilde)
            num3 = ~10;  //-11
            Console.WriteLine(num3);

            //left shift
            num3 = (10 << 1);  //1010--20
            Console.WriteLine(num3);

            num3 = (10 << 3);  //1010--80
            Console.WriteLine(num3);

            //Right shift
            num3 = (80 >> 2);  //1010000--20
            Console.WriteLine(num3);
        }
    }
}
