using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class UsingTryCatch
    {


        public static void TryCatchDemo()
        {
            try
            {

                Console.WriteLine("Enter a number: ");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"Square of {num} is {num * num}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error info:" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Re-try with a different number.");
            }
        }
    }
}
