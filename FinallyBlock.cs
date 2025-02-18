using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class FinallyBlock
    {
        public static void FinallyBlockMethod()
        {
            FileInfo file = null;

            try
            {
                Console.Write("Enter a file name to write: ");
                string fileName = Console.ReadLine();
                file = new FileInfo(fileName);
                using (StreamWriter writer = file.AppendText())
                {
                    writer.WriteLine("Hello World!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: {0}", ex.ToString());
            }
            finally
            {

                file = null;
            }
        }
    }
    }
