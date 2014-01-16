using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestString
{
    /// <summary>
    /// Class to Show the basic
    /// Functionality of string Functions.
    /// </summary>
    class TestString
    {
        /// <summary>
        /// Main Method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string test="Ankit Singh";
            string test2 = "Ankit Singh";
            string test3 = "Works in Optimus";
            
            Console.WriteLine(test.ToUpper());//ToUpper() Method;

            Console.WriteLine(test.ToLower());//ToLower() Method;
            
            string clone = (string)test.Clone();//Clone() Method;
            
            Console.WriteLine(clone);

            if (test.CompareTo(test2) == 0)
                Console.WriteLine("Both The Strings are Equal");  //CompareTo() Method;
            if (test.CompareTo(test3) == 1)
                Console.WriteLine("Strings are Not Equal");

            if (test.Contains("ing"))
                Console.WriteLine("It contains the Specified String."); //Contains() Method;

            if (test3.EndsWith("s"))
                Console.WriteLine("The String ends With character s");// EndsWith() Method;

            if (test2.Equals(test3))
                Console.WriteLine("Both the Strings are Equal.");//Equals() Method;

            Console.WriteLine(test3.IndexOf("O"));//IndexOf() Method;

            string test4=test3.Insert(16," Informations");//Insert() Method;
            Console.WriteLine(test4);

            Console.WriteLine(test4.LastIndexOf("s"));//LastIndexOf() Method;

            Console.WriteLine(test3.Length);//Length Method;

            Console.WriteLine(test.Remove(6));//Remove() Method;

            Console.WriteLine(test.Replace("g","h"));//Replace() Method;

            if(test4.StartsWith("W"))
                Console.WriteLine("The String Starts With W");//StartsWith() Method;

            Console.WriteLine(test3.Substring(9,7));//Substring() Method;

            Console.WriteLine(test.ToCharArray());//ToCharArray() Method;

            Console.WriteLine(test3.Trim());//Trim() Method;
            Console.WriteLine(test3.TrimEnd());//TrimEnd() Method;
            Console.WriteLine(test3.TrimStart());//TrimStart() Method;

             Console.ReadLine();
            
        }
    }
}
