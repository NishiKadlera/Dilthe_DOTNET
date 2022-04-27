using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. Create a custom exception for voting eligibility.
namespace CSharpTask6
{
    internal class CustomExceptions
    {
        public static void Main()
        {
            int age;
            string name;
            Console.WriteLine("********VOTING ELIGIBILITY CHECK**********\n");
            try
            {
                //if we use any other datatype like float and double other than int, we need to add the below if block to display the exception message
                //if (float.IsInfinity(result))
                //{
                //    Console.WriteLine("Division by zero not allowed");

                //}
                Console.WriteLine("Enter your name here:");
                name= Console.ReadLine();
                Console.WriteLine("\nEnter the age:");
                age= Convert.ToInt32(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("\nThe candidate is eligible for voting.\n");
                }
                else
                {
                    Console.WriteLine("The candidate is not eligible for voting.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Please proceed with casting your vote.");
            }
        }

    }
    public class VotingException: Exception
    {
        public VotingException(string message): base(message)
        {

        }
    }
   
}
