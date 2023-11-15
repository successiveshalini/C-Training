using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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

            private static List<CourseSubject> _subjects = new List<CourseSubject>();
            public static List<CourseSubject> Subjects
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
            private static List<Course> _Courses = new List<Course>();
            public static List<Course> Courses
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
            List<Student> studentList = new List<Student>();
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

                        Console.WriteLine("Enter the  subject Id : ");
                        var id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the  subject name : ");
                        var name = Console.ReadLine();

                        Console.WriteLine("Enter the  subject code : ");
                        var code = Console.ReadLine();
                        CourseSubject cs = new CourseSubject();
                        cs.Id = id;
                        cs.Name = name;
                        cs.Code = code;
                        course.AddSubject(cs);
                        break;

                    case 2:
                       Console.WriteLine("Enter the course Id : ");
                        var id2 = int.Parse(Console.ReadLine());

                       Console.WriteLine("Enter the Course name : ");
                        var name2 = Console.ReadLine();

                        Console.WriteLine("Enter the Course code : ");
                        var code2 = Console.ReadLine();
                        Course cs1 = new Course();
                        cs1.Id = id2;
                        cs1.Name = name2;
                        cs1.Code = code2;

                        Student.Courses.Add(cs1);
                        break;

                    case 3:
                        Console.WriteLine("Enter the  Student Id : ");
                        var id3 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the  Student name : ");
                        var name3 = Console.ReadLine();

                        Console.WriteLine("Enter the  Student code : ");
                        var Code3 = Console.ReadLine();
                        Student stu = new Student();
                        stu.Id = id3;   
                        stu.Name = name3;
                        stu.Code = Code3;
                        stu.AddCourse(course);  
                        studentList.Add(stu);

                        break;
                    case 4:
                        foreach (var item in Course.Subjects)
                        {
                            Console.WriteLine(item.Id + " " + item.Name + " " + item.Code);
                        }
                        break;

                    case 5:
                        foreach (var item in Student.Courses)
                        {
                            Console.WriteLine(item.Id + " " + item.Name + " " + item.Code);
                            
                        }
                        break;
                    case 6:
                        foreach (var item in studentList)
                        {
                            Console.WriteLine(item.Id + " " + item.Name + " " + item.Code);

                        }
                        break;
                    case 7:
                        Console.WriteLine("Wants to find the Subject");
                        Console.WriteLine("Enter Subjects Code/Name");
                        string input = Console.ReadLine();
                        var Subject1 = Course.Subjects.FirstOrDefault(s => s.Code.ToLower() == input.ToLower() || s.Name.ToLower() == input.ToLower());
                        if (Subject1 != null)
                        {
                            Console.WriteLine("{0}, {1}, {2}", Subject1.Id, Subject1.Name, Subject1.Name);
                        }
                        else
                        {
                            Console.WriteLine("Subject is not present");
                        }
                        break;

                    case 8:
                        Console.WriteLine("Wants to find the Courses ");
                        Console.WriteLine("Enter Course Code/Name");
                        string print = Console.ReadLine();
                        var isCourse = Student.Courses.FirstOrDefault(c => c.Code.ToLower() == print.ToLower() || c.Name.ToLower() == print.ToLower());
                        if(isCourse != null)
                        {
                            Console.WriteLine("{0}, {1}, {2}", isCourse.Id, isCourse.Name, isCourse.Code);
                        }
                        else
                        {
                            Console.WriteLine("Course is not present");
                        }
                    break;

                    case 9:
                        Console.WriteLine("Wants to find the Student");
                        Console.WriteLine("Enter Student Code/Name");
                        string Result = Console.ReadLine();
                        var isStudent = studentList.FirstOrDefault(s => s.Code.ToLower() == Result.ToLower()|| s.Name.ToLower() == Result.ToLower());
                        if (isStudent != null)
                        {
                            Console.WriteLine("{0}, {1}, {2}", isStudent.Id, isStudent.Code, isStudent.Name);

                        }
                        else
                        {
                            Console.WriteLine("Student is not present");
                        }
                        break;

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


 



