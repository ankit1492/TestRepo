
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
///Enumeration Declaration. 
/// </summary>
enum WeekDays
{
    Monday,Tuesday,Wednesday,Thusrday,Friday,Saturday,Sunday
}
namespace TestEnum
{
    /// <summary>
    /// Class Showing the basic
    /// Functionality of the Enumerations.
    /// </summary>
    class Programa
    {
        /// <summary>
        /// Main Method.
        /// </summary>
        /// <param name="args"></param>
        
        static void Main(string[] args)
        {
            for (int i = (int)WeekDays.Monday; i <= (int)WeekDays.Sunday; i++)
            {
                switch (i)     //Switch Case;
                {
                    case 0: Console.WriteLine("Monday is The First Day of the Week.");
                        break;
                    case 1: Console.WriteLine("Tuesday is The Second Day of the Week.");
                        break;
                    case 2: Console.WriteLine("Wednesday is The Third Day of the Week.");
                        break;
                    case 3: Console.WriteLine("Thursday is The Fourth Day of the Week.");
                        break;
                    case 4: Console.WriteLine("Friday is The Fifth Day of the Week.");
                        break;
                    case 5: Console.WriteLine("Saturday is The Sixth Day of the Week.");
                        break;
                    case 6: Console.WriteLine("Sunday is The Seventh Day of the Week.");
                        break;
                }
            }


                Console.ReadLine();
        }
    }
}
