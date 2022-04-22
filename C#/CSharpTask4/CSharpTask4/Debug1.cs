using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n);
namespace CSharpTask4
{
        class Debug1
        {
            static int num = 1;//semicolon missing
            public static int AddNum(int p)
            {
                num += p;
                return num;
            }
            public static int MultNum(int q) //missing closing brackets
            {
                num *= q;
                return num; //return statement
            }

            public static int getNum()
            {
                return num;
            }
            static void Main(string[] args)
            {

                Debug1 td = new Debug1();

                //create delegate instances
                NumberChanger nc1 = new NumberChanger(AddNum);
                NumberChanger nc2 = new NumberChanger(MultNum);



                //calling the methods using the delegate objects
                nc1(25);
                Console.WriteLine("Value of Num: {0}", getNum());
                nc2(10);
                Console.WriteLine("Value of Num: {0}", getNum());
                Console.ReadKey();
            }
        }
}
