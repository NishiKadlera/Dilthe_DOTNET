using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. Explore the difference between pass by value, pass by reference(ref keyword) and pass by out(out keyword) in C#.
namespace CSharpTask7
{
    internal class PassByReferance
    {
        /// <summary>
        /// Pass by value, pass by reference, pass by out
        /// </summary>
        public static void Main()
        {
            int a = 10, b = 20;//declaration
            int c = 30;
            int d;
            PassBy PBV=new PassBy();//instance creation
            PBV.PassByValue(a,b);//invoking passbyvalue
            Console.WriteLine("Value after pass by value:{0},{1}\n", a, b);
            PBV.PassByRefence(ref c);//invoking passbyreference
            Console.WriteLine("Value after pass by reference:{0}\n", c);
            PBV.PassByOut(out d);//invoking passbyout
            Console.WriteLine("Value after pass by out:{0}\n", d);



        }
    }
    public class PassBy
    {
        public void PassByValue(int a, int b)//passbyvalue method
        {
            int res;
            res = a + b;
            Console.WriteLine("{0} +{1}={2}",a,b,res);
        }
        public void PassByRefence(ref int c)//passbyreference method
        {
            c = c * c;
            Console.WriteLine("Square root:{0}", c);

        }
        public void PassByOut(out int d)//passbyout method
        {
            d = 40;
            d = d * d * d;
            Console.WriteLine("Cube root: {0}", d);
        }
    }
    
}
