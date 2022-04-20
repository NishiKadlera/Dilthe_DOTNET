using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask1
{
    internal class TraineeDetails
    {
        /// <summary>
        /// Used Datatypes
        /// </summary>
        public static void Main()
        {
            int TID;
            string TFirstname;
            string TLastname;
            string TDepartment;
            string TEmail;
            Console.WriteLine("Enter your Trainee ID");
            TID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your FirstName");
            TFirstname = Console.ReadLine();
            Console.WriteLine("Enter your LastName");
            TLastname = Console.ReadLine();
            Console.WriteLine("Enter your Department");
            TDepartment = Console.ReadLine();
            Console.WriteLine("Enter your Email ID");
            TEmail = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Trainee ID: {TID}.\nTrainee Name: {TFirstname} {TLastname}.\nTrainee Department: {TDepartment}.\nTrainee EmailID: {TEmail}");
        }
    }
}
