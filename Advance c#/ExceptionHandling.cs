using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionHandlingprogram
{
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }

            

        }
        [Serializable]
        public class InvalidStudentNameException : Exception
        {
            public InvalidStudentNameException() { }

            public InvalidStudentNameException(string name)
                : base(String.Format("Invalid Student Name: {0}", name))
            {

            }
        }
    public class Program
    {
        public static void ValidateStudent(Student stu)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            if (!regex.IsMatch(stu.StudentName))
            throw new InvalidStudentNameException(stu.StudentName);

        }
        static void Main(string[] args)
        {
            Student newStudent = null;

            try
            {
                newStudent = new Student();
                newStudent.StudentName = "James007";

                ValidateStudent(newStudent);
            }
            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

       
    }
}
