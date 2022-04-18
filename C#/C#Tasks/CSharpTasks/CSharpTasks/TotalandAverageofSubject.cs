using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    /// <summary>
    /// Finding total and average of subject using if else concept
    /// </summary>
    internal class TotalandAverageofSubject
    {
        public static void Main()
        {
            int sub1, sub2, sub3;
            double Total, avg; 
            int option, temp = 0;
            
            Console.WriteLine("Enter marks of subject 1");
            sub1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of subject 2");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of subject 3");
            sub3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Enter 1 to get the total of all subjects or Enter 2 to get the average of all scores  ");
            option= Convert.ToInt32(Console.ReadLine());
            
            //if-else loop
            if(option == 1)
            {
                Total = sub1 + sub2 + sub3;
                Console.WriteLine("The total is: {0}", Total);
            }
            else
            {
                temp=sub1 + sub2 + sub3;
                avg = temp / 3;
                Console.WriteLine("The average is: {0}", avg);
            }


        }
    }
}
