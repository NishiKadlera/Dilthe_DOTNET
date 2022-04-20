using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask1
{
    public class StaticandInstanceMethod
    {
        public static void add(int a, int b)
        {
            int result = a +b;
            Console.WriteLine($"The sum of two number is: {result} ");
        }
        public void sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"The difference of two number is: {result} ");
        }
        public static void Main()
        {
            //invoking static method
            add(20,30);
            //invoking Instance method
            StaticandInstanceMethod sb = new StaticandInstanceMethod();
            sb.sub (200,100);
        }
    }
}
