using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    internal class Overloading
    {
        /// <summary>
        /// Main method
        /// </summary>
        public static void Main()
        {
            Areas(10);
            Areas(2, 5);
            Areas(20);
            Areas(25);
        }
        static int area;
        /// <summary>
        /// Area of Square
        /// </summary>
        /// <param name="a"></param>
        public static void Areas(int a)
        {
            area = a * a;
            Console.WriteLine($"The area of the Square is: {area}");
        }

        /// <summary>
        /// Area of Rectangle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Areas(int a,int b)
        {
            area = a * b;
            Console.WriteLine($"The area of the Rectangle is: {area}");
        }
        /// <summary>
        /// Area of Circle
        /// </summary>
        /// <param name="c"></param>
        public static void Areas(float c)
        {
            area = (int)(3.14*c*c);
            Console.WriteLine($"The area of the Circle is: {area}");
        }
        /// <summary>
        /// Area of Cube
        /// </summary>
        /// <param name="d"></param>
        public static void Areas(double d)
        {
            area = (int)(d* d* d);
            Console.WriteLine($"The area of the Cube is: {area}");
        }
    }
}
