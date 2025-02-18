using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class Re_throwingfanException
    {
        public static void Method()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        static void Method1()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static void Method2()
        {
                
           string str = null;
            try
            {
                Console.WriteLine(str[0]);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
