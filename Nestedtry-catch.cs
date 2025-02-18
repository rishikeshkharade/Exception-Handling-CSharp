using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Nestedtry_catch
    {
        public static void Nestedtrycatch()
        {
            var divider = 0;

            try
            {
                try
                {
                    var result = 100 / divider;
                }
                catch(NullReferenceException ex)
                {
                    Console.WriteLine("Inner catch");
                }
            }
            catch
            {
                Console.WriteLine("Outer catch");
            }
            }
            } 
    }
