using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaskProgram.Program;

namespace TaskProgram
{
    public class Program
    {
        public class CourseSubject
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
        }
        public class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }

            private List<CourseSubject> _subjects = new List<CourseSubject>();
            public List<CourseSubject> Subjects
            {
                get { return _subjects; }
            }
            public void AddSubject(CourseSubject subject)
            {
                _subjects.Add(subject);
            }
            public void RemoveSubject(CourseSubject subject)
            {
                _subjects.Remove(subject);
            }
            public void AddSubject(List<CourseSubject> subjects)
            {
                _subjects.AddRange(subjects);
            }
        }
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
            private List<Course> _Courses = new List<Course>();
            public List<Course> Courses
            {
                get { return _Courses; }
            }
            public void AddCourse(Course course1)
            {
                _Courses.Add(course1);
            }
            public void RemoveCourse(Course course1)
            {
                _Courses.Remove(course1);
            }
            public void AddCourse(List<Course> courses)
            {
                _Courses.AddRange(courses);
            }


        }


        static void Main(string[] args)
        {
            int choice = -1;
            bool ch = true;
            Course course = new Course();
            Student stud = new Student();
            bool endProcess = false;
            do
            {
                Console.WriteLine("\n1.Add Subject");
                Console.WriteLine("2.Add Course");
                Console.WriteLine("3.Add Student");
                Console.WriteLine("4.View All Subjects");
                Console.WriteLine("5.View All Courses");
                Console.WriteLine("6.View All Students");
                Console.WriteLine("7.Find Subject by Name/Code");
                Console.WriteLine("8.Find Course by Name/Code");
                Console.WriteLine("9.Find Student by Name/Code");
                Console.WriteLine("10.Exit");
                Console.WriteLine();


                bool t = true;
                while (t)
                {
                    Console.WriteLine("Enter the choice ");
                    var c = Console.ReadLine();
                    bool successive = int.TryParse(c, out choice);
                    if (!successive)
                    {
                        Console.WriteLine("Invalid input");
                        break;
                    }
                    else
                        t = false;  
                }
                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Enter the course subject Id : ");
                        var id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the Course subject name : ");
                        var name = Console.ReadLine();

                        Console.WriteLine("Enter the Course subject code : ");
                        var code = Console.ReadLine();



                        CourseSubject cs = new CourseSubject();
                        cs.Id = id;
                        cs.Name = name;
                        cs.Code = code;
                        course.AddSubject(cs);
                        break;
                    case 4:
                        foreach(var item in course.Subjects)
                        {
                            Console.WriteLine(item.Id + " " + item.Name + " " + item.Code);
                        }
                        break;

                    //case 2:
                    //    Console.WriteLine("Enter the course subject Id : ");
                    //    var id2 = int.Parse(Console.ReadLine());

                    //    Console.WriteLine("Enter the Course subject name : ");
                    //    var name2 = Console.ReadLine();

                    //    Console.WriteLine("Enter the Course subject code : ");
                    //   var code2 = Console.ReadLine();
                    //    CourseSubject cs1 = new CourseSubject();
                    //    cs1.Id = id2;
                    //   cs1.Name = name2;
                    //    cs1.Code = code2;

                    //   course.RemoveSubject(cs1);
                    //break;



                    case 10:
                        endProcess = true;
                        break;


                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                       
                }


            }
            while (!endProcess);


            Console.ReadKey();

    }

    }
}


 



