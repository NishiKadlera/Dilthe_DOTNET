using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. Show the working of Multi-cast delegate.
namespace CSharpTask6
{
    /// <summary>
    /// Single and Multi cast deegates
    /// </summary>
    public class Delegates
    {
        //creating single cast delegate
        public delegate void Square(int a);
        //creating multi cast delegate
        public delegate void Rectangle(double p, double q);

        //Method for square area- single cast
        public void SArea(int a)
        {
            Console.WriteLine($"Area of square is:{a*a}" );
        }

        public void SPerimeter(int a)
        {
            Console.WriteLine($"Perimeter of square is:{4 * a}\n");
        }


        //Method for Rectangle area- Multi cast
        public void RArea(double p, double q)
        {
            Console.WriteLine($"Area of Rectangle is:{p * q}");
        }
        //Method for Rectangle perimeter- Multi cast
        public void RPerimeter(double p, double q)
        {
            Console.WriteLine($"Perimeter of Rectangle is:{2*(p + q)}");
        }
        //Method for Rectangle surface area- multi cast
        public void RLenWid(double p, double q)
        {
            Console.WriteLine($"The sum of length and width of rectangle is: {p + q}");
        }

        //creating another class to call the methods in the main function
        public class Delegates1
        {
            public static void Main()
            {
                //Instance for delgates class
                Delegates del= new Delegates();
                //instance for delegate square-single cast
                Console.WriteLine("*********Single cast Delegate*********\n");
                Square calc= del.SArea;//referance for SArea method
                calc(10);
                calc = del.SPerimeter;//referance for SPerimeter method
                calc(100);

                //instance for delegate rectangle -multi cast
                Console.WriteLine("***********Multi cast Delegate***********\n");
                Rectangle calc1 = del.RArea;//referance for RArea method
                calc1 += del.RPerimeter;//referance for RPerimeter method
                calc1 += del.RLenWid;//referance for RLenWid method
                calc1(20,10);


            }
        }
    }
}
