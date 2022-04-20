using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask1
{
    public class Constructors
    {
        //default constructor
        public Constructors()
        {
            Console.WriteLine("Hello! I'm a default constructor");
        }
        //constructor with 2 paramenter(constructor overloading)
        public Constructors(int num1, int num2)
        {
            Console.WriteLine("Sum of numbers:{0}", num1+num2);
        }
        public Constructors(int id, string name)
        {
            Console.WriteLine($"The name of the student with ID {id} is {name}");
        }
        public Constructors(string name, float a)
        {
            Console.WriteLine($"{name} 's height is {a}");
        }
        public Constructors(string name, double b)
        {
            Console.WriteLine($"{name} has scored {b} marks in her exam");
        }

        public static void Main()
        {
            Constructors c = new Constructors();//invoking the default constructor with no paramter
            Constructors c1 = new Constructors(100, 200);//invoking the constructor with two integer parameter 
            Constructors c2 = new Constructors(101, "Nishi");//invoking the constructor with (int,string) 2 parameters
            Constructors c3 = new Constructors("Nishi", 5.4f);//invoking the constructor with (string,float) 2 parameters
            Constructors c4 = new Constructors("Nishi", 95.555);//invoking the constructor with (string,double) 2 parameters
        }
    }
}
