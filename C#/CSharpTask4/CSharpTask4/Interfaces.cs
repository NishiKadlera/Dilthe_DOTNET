using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask4
{
    /// <summary>
    /// Working of two Interfaces
    /// </summary>
    public interface IArea //creating an interface IArea
    {
        /// <summary>
        /// declaring method in IArea interface
        /// </summary>
        public void Area();

    }

    public interface IPerimeter //creating an interface IPerimeter
    {
        /// <summary>
        /// declaring method in IPerimeter interface
        /// </summary>
        public void Perimeter();

    }

    public class Square:IArea, IPerimeter
    {
        void IArea.Area()
        {   
            //calculating the area of square by taking the input from the user
            Console.WriteLine("Area of Square\n************************************");
            int length, breadth, result;
            Console.WriteLine("Enetr side of Square");
            length = Convert.ToInt32(Console.ReadLine());
            result = length* length;
            Console.WriteLine($"\nThe Area of the square is: {result}");

        }
        
        void IPerimeter.Perimeter()
        {
            //calculating the area of perimeter by taking the input from the user
            Console.WriteLine("\nArea of Perimeter\n**********************************");
            int length, breadth, result;
            Console.WriteLine("Enter Length and Breadth");
            length = Convert.ToInt32(Console.ReadLine());
            breadth = Convert.ToInt32(Console.ReadLine());
            result = 2*(length + breadth);
            Console.WriteLine($"\nThe Perimeter of the Square is: {result}");
        }

    }
    internal class Interfaces
    {
        public static void Main()
        {
            IArea area = new Square();
            area.Area();
            IPerimeter perimeter= new Square();
            perimeter.Perimeter();
        }
    }


}
