using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringArray
{
    /// <summary>
    /// Class that shows the implementation of
    /// string arrays.
    /// </summary>
    class StringArray
    {
        /// <summary>
        /// Main Method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            StringArray p = new StringArray();
            string[] t = p.GetStringArray();
            foreach (string ch in t)
            {
                Console.Write(ch);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Method That Returns the 
        /// string array in the Main()
        /// Method.
        /// </summary>
        /// <returns>string array</returns>
        string[] GetStringArray()
        {
            string[] arr = new string[5]; 
            Console.WriteLine("Enter The Values in The String Array:");
            for (int i = 0; i < 5; i++)
                arr[i] = Console.ReadLine();

            return arr;

           
        }
    }
}
