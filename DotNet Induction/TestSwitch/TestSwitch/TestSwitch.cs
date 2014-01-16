using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TestSwitch
{
    /// <summary>
    /// Class To Show The Functionality
    /// Of Switch Statement.
    /// </summary>
    class TestSwitch
    {
        /// <summary>
        /// Main Method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Choose the Language you Work On");
            Console.WriteLine("1 for VB");
            Console.WriteLine("2 for C#");
            Console.WriteLine("3 for any Other Language");

            string p = Console.ReadLine();

            switch (p)
            {
                case "1": Console.WriteLine("VB.NET:OOP,multithreading and more!");
                    break;
                case "2": Console.WriteLine("Good Choice,C# is a fine language");
                    break;
                default: Console.WriteLine("Well..good luck with that.");
                    break;

            }
            Console.ReadLine();
        }
    }
}
