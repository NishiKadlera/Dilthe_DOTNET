using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. Show the working of Dispose method.
namespace CSharpTask7
{
    public class Disposable: IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("\n***********Memory is cleared************");
        }
    }
   
    internal class DisposeMethod
    {
        public static void Main()
        {
            int a,b,c;
            Disposable disposable = new Disposable();//instance for Disposable class
            

            Area Sarea = new Area();//default constructor

            Console.WriteLine("Enter values");
            a = Convert.ToInt32(Console.ReadLine());
            Area Sarea1 = new Area(a);//default constructor

            Console.WriteLine("\nEnter value1 and value2");
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Area Rarea2  = new Area(b, c);//constructor with two parameter

            disposable.Dispose();


        }
    }
    public class Area
    {
        int a, b, c;
        public Area()
        {
            Console.WriteLine("***********Working of Dispose method***********\n");
        }
        public Area(int a)
        {
      
            int area = a * a;
            Console.WriteLine("Area of square is: {0}", area);
        }
        public Area( int b, int c)
        {
          
            int area1 =b*c;
            Console.WriteLine("Area of square is: {0}", area1);
        }
        ~Area()
        {
            Console.WriteLine("EXIT!!");
        }
    }
}
