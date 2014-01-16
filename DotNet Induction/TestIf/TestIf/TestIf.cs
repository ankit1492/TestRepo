using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestIf
{
    /// <summary>
    /// Class to show the basic Functionality
    /// of if and else. 
    /// </summary>
    class TestIf
    {
        #region MyRegion
        /// <summary>
        /// Main Method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.message);
            Console.WriteLine("1 for VB");
            Console.WriteLine("2 for C#");
            Console.WriteLine("3 for Any Other Language");

            string p = Console.ReadLine();

            if (p == "1")
                Console.WriteLine(Constants.choice1);

            else if (p == "2")
                Console.WriteLine(Constants.choice2);

            else
                Console.WriteLine(Constants.choice3);

            Console.ReadLine();
        } 
        #endregion

  
    }
}
