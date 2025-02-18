using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class ThrowKeyword
    {
        public static void throwkeyword()
        {
            object student = null;

            try
            {
                PrintStudentName(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        private static void PrintStudentName(object std)
        {
            if (std == null) {
                throw new NullReferenceException("Student object is null.");

                Console.WriteLine(std);
            }
        }
    }
}
