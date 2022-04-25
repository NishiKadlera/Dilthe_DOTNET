using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
//1. Retrieve all the Keys and Values using Dictionary and Hashtable.
namespace CSharpTask6
{
    /// <summary>
    /// Dictonary and Hashtable
    /// </summary>
    internal class DictonaryHashtable
    {
        /// <summary>
        /// Main method
        /// </summary>
        public static void Main()
        {
            Dictionary();
            Hashtable();
        }
        /// <summary>
        /// Disctonary method
        /// </summary>
        public static void Dictionary()
        {
            //key value pairs should be of same type
            //dictonary is a generic collection and is access through system.collections.generic namespace
            Console.WriteLine("\n***************DICTONARY****************\n");
            Dictionary<string,string> StateCapital = new Dictionary<string,string>();
            StateCapital.Add("Karnataka", "Bangaluru");
            StateCapital.Add("Kerala", "Thiruvananthapuram");
            StateCapital.Add("TamilNadu", "Chennai");
            StateCapital.Add("AndraPradesh", "Amaravati");
            StateCapital.Add("Goa", "Panaji");
            Console.WriteLine(" ********KEYS********\n");
            var state=new List<string>(StateCapital.Keys);
            foreach (var key in state)
            {
                Console.WriteLine($"The Keys in the dictonary are: {key}");
            }
            Console.WriteLine("\n***********VALUES**********\n");
            var capital = new List<string>(StateCapital.Values);
            foreach (var value in state)
            {
                Console.WriteLine($"The Values in the dictonary are: {value}");
            }
        }
        public static void Hashtable()
        {
            //no need to give the type of key value pair and key and value can be of same or different types
            //hashtable is a non generic collection and is accessed through system.collections namespace
            Console.WriteLine("\n*************HASHTABLE*****************\n");
            Hashtable animals =new Hashtable();
            animals.Add(1, "Dog");
            animals.Add(2, "Cat");
            animals.Add("Three", "Cow");
            animals.Add("Four", "Lion");
            animals.Add("Tiger", 5);
            Console.WriteLine("********KEYVALUES**********\n");
            ICollection collection = animals.Keys;
            foreach(var key in collection)
            {
                Console.WriteLine($"The Keys in Hashtable are: {animals[key]}");
            }
          

        }
    }
}
