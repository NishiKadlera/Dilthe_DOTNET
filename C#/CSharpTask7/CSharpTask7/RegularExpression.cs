using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//1. Show the working of Custom Exception and Regular Expression(mobile and name)
namespace CSharpTask7
{
    public class NameException: Exception
    {
        public NameException()
        {
            Console.WriteLine("\nInvalid Name!!!");
        }
    }
    public class MobileException : Exception
    {
        public MobileException()
        {
            Console.WriteLine("\nInvalid Mobile Number!!!");
        }
    }

    //public class validation
    //{
    //    public string name { get; set;}
    //    public string mobile { get; set;}
    //}


    public class RegularExpression
    {
        public static void Main()
        {
            string name;
            string mobile;
            try
            {
                Console.WriteLine("****REGULAR EXPRESSION****");
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();
                Console.WriteLine("Enter mobile number");
                mobile = Console.ReadLine();
                ValidateName(name);
                ValidateMobile(mobile);
           
            }
            catch   (NameException)
            {
                Console.WriteLine();
            }
            catch (MobileException)
            {
                Console.WriteLine();
            }

        }
        public static void ValidateName(string name)
        {
            var Nregex = Regex.IsMatch(name, (@"^[a-zA-Z\.\s]*$"));
            if (Nregex == false)
            {
                throw new NameException();
            }
        }


        public static void ValidateMobile(string mobile)
        {
             var Mregex = Regex.IsMatch(mobile, (@"(^[1-9]{10}$)"));
             if (Mregex == false)
             {
                    throw new MobileException();
             }
        }
            

     

        



    }
}
