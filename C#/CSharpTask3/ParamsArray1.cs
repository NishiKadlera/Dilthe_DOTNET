using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask3
{
    internal class ParamsArray1
    {
        public static void Main()
        {
            int[] num = { 10, 20, 30 };
            StuCount(num);
            Console.WriteLine();
            StuCount(1, 2, 3, 4, 5, 6, 7, 8, 9, 0);
            Console.WriteLine();
            StuCount(2, 3, 4, 5, 6);
        }
        public static void StuCount(params int[] arr)
        {
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
