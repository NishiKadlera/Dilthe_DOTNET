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
            Console.WriteLine("Memory is cleared");
        }
    }
   
    internal class DisposeMethod
    {
        public static void Main()
        {
            int a,b,c;
            Disposable disposable = new Disposable();//instance for Disposable class
            //Area ar = new Area();    
            //Area Sarea = new Area();//default constructor
            //Area Sarea1 = new Area(ar.a);//constructor with one paramener
            //Area Aarea2  = new Area(ar.b, ar.c);//constructor with two parameter
            //invoking the dispose method

            Area Sarea = new Area();//default constructor

            Console.WriteLine("Enter int values");
            a = Convert.ToInt32(Console.ReadLine());
            Area Sarea1 = new Area(a);//default constructor

            Console.WriteLine("Enter value1");
            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter value2");
            c = Convert.ToInt32(Console.ReadLine());
            Area Aarea2  = new Area(b, c);//constructor with two parameter

            disposable.Dispose();



        }
    }
    public class Area
    {
        int a, b, c;
        public Area()
        {
            Console.WriteLine("Working of Dispose method");
        }
        public Area(int a)//
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
