using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class UsingTryCatchFinally
    {
        public static void TryCatchFinallyDemo()
        {
            try
            {

                Console.WriteLine("Enter a number: ");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"Sqaure of {num} is {num * num}");
            }
            catch
            {
                Console.WriteLine("Error occured.");

            }

            finally
            {
                Console.WriteLine("Re-try with a different number.");
            }
        }
    }
}