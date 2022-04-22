using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. Show the working of Hybrid Inheritance
namespace CSharpTask4
{
    /// <summary>
    /// Base class
    /// </summary>
    internal class HybridInheritance
    {
        public string StuName;//declaring variable
        public void Heading()//creating a method for class HybridInheritance
        {
            Console.WriteLine("***********Hybrid Inheritance*************");
        }

    }
    /// <summary>
    /// Derived Class
    /// </summary>
    internal class Student : HybridInheritance//single level inheritance
    {
        //declaring variables
        public string StuBranch;
        public int StuAge;
        //To get the input from the user and display details--first inheritance
        public void StuDetails()
        {
            base.Heading();
            Console.WriteLine("\nStudent Details\n***********************\n");
            Console.WriteLine("Enter Student's Name, Branch and Age");
            StuName = Console.ReadLine();
            StuBranch = Console.ReadLine();
            StuAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nThe student details are:\nStudent name: {StuName}\nStudent branch: {StuBranch}\nStudent Age: {StuAge}");

        }
    }
    /// <summary>
    /// Derived class
    /// </summary>
    internal class StudentCourses : Student//multi level inheritance
    {
        //declaring variables
        public string MainCourse;
        public string ElectiveCourse;
        //To get the input from the user and display details--second inheritance
        public void StuCourseDetails()
        {
            Console.WriteLine($"\nEnter {StuName}'s Main Course");
            MainCourse = Console.ReadLine();
            Console.WriteLine($"\nEnter {StuName}'s Elective Course");
            ElectiveCourse = Console.ReadLine();
            Console.WriteLine($"\n{StuName}, who belongs to {StuBranch}, is {StuAge} years of age and has chosen {MainCourse} as main course and {ElectiveCourse} as elective subject.\n ");
        }
    }
    internal class Inheritance
    {
        public static void Main()
        {
            //Multilevel inheritance
            StudentCourses studentCourses = new StudentCourses();
            studentCourses.StuDetails();
            studentCourses.StuCourseDetails();
        }
    }
}

