using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask3
{
    internal class ParametrizedStructures
    {
        /// <summary>
        /// Accessing the structure in the main method
        /// </summary>
        public static void Main()
        {
            //Calling the student structure in the main method
            StuDetails stu=new StuDetails();//creating an instance
            stu.GetStuDetails();
            stu.DisplayStuDetails();
            StuDetails stu1 = new StuDetails(101, "John", 32);
            StuDetails stu2 = new StuDetails(10, "Peter", 30);
       
        }
    }

    //struct is the keyword used for structure class
    struct StuDetails
    {   
        /// <summary>
        /// Get the student details and display them
        /// </summary>
        public int Sid;
        public string SName;
        public int SAge;

        //To get the student details from user
        public void GetStuDetails()
        {
            Console.WriteLine("Enter the Student Id, Name and Age:");
            Sid=Convert.ToInt32(Console.ReadLine());
            SName= Console.ReadLine();
            SAge=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        //To display the Student Details
        public void DisplayStuDetails()
        {
            Console.WriteLine($"The Student Id:{Sid}");
            Console.WriteLine($"The Student Name:{SName}");
            Console.WriteLine($"The Student Age:{SAge}");
            Console.WriteLine();
        }

        //Parameterized constructor in Structure
        public StuDetails(int id, string name, int age)
        {
            Sid=id;
            SName=name;
            SAge=age;
            Console.WriteLine($"The Student Id of {name} is {id} and he is {age} years old");

        }
   
    }
        

}
