using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class ThrowCustomException
    {
        public static void MainMethod()
        {
            Student newStudent = null;

            try
            {
                newStudent = new Student();
                newStudent.StudentName = "Rishikesh007";

                ValidateStudent(newStudent);
            }
            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static void ValidateStudent(Student student)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(student.StudentName))
            {
                throw new InvalidStudentNameException(student.StudentName);
            }
        }
    }
}
