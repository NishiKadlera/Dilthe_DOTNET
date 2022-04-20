using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    internal class GetManyEmployeeDetails
    {
        int Eid;
        string Name;
        string Dept;

        public void GetDetails()
        {
            Console.WriteLine("Enter the Employee ID");
            Eid= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee ID");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Employee ID");
            Dept = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine($"Employee ID: {Eid}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Dept: {Dept}");
        }

        public static void Main()
        {
            int n;
            GetManyEmployeeDetails emp= new GetManyEmployeeDetails();
            Console.WriteLine("Enter the number of Employee");
            n=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                Console.WriteLine();
                emp.GetDetails();
                Console.WriteLine();
                emp.Display();
            }
        }

    }
}
