using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask4
{
        class Debug2
        {

            int result;
            Debug2()
            {
                result = 0;
            }
            public void division(int num1, int num2)
            {
                try
                {
                    result = num1 / num2;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Exception caught: {0}", e.Message);
                }
                finally
                {
                    Console.WriteLine("Result: {0}", result);
                }
            }
            static void Main()
            {
            Debug2 d = new Debug2();
                d.division(200,0);
                Console.ReadKey();
            }
        }
}

