using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            student st1 = new student()
            {
                studentid = 1,
                name = "umesh",
                coursename = ".net",
                duration = 60
            };
            student st2 = new student()
            {
                studentid = 2,
                name = "Ramesh",
                coursename = ".net advance",
                duration = 70
            };
            student st3 = new student()
            {
                studentid = 3,
                name = "meenakshi",
                coursename = ".net",
                duration = 60
            };
            student st4 = new student()
            {
                studentid = 4,
                name = "umesh",
                coursename = ".sql",
                duration = 45
            };
            student st5 = new student()
            {
                studentid = 5,
                name = "pradeepthi",
                coursename = ".net",
                duration = 30
            };

            Stack<student> SStudent = new Stack<student>();
            SStudent.Push(st1);
            SStudent.Push(st2);
            SStudent.Push(st3);
            SStudent.Push(st4);
            SStudent.Push(st5);
            student Stemp = SStudent.Pop();

            Console.WriteLine("NO. of student in Stack are :{0}", SStudent.Count);
            foreach (student item in SStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }
            Stemp = SStudent.Pop();
            Console.WriteLine("NO. of student in Stack are :{0}", SStudent.Count);
            foreach (student item in SStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }
            Stemp = SStudent.Pop();
            Console.WriteLine("NO. of student in Stack are :{0}", SStudent.Count);
            foreach (student item in SStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }
            Stemp = SStudent.Pop();
            Console.WriteLine("NO. of student in Stack are :{0}", SStudent.Count);
            foreach (student item in SStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }

            Stemp = SStudent.Peek();
            Console.WriteLine("NO. of student in Stack are :{0}", SStudent.Count);
            foreach (student item in SStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }





            //if (SStudent.Contains(st5))
            //    Console.WriteLine("Student exists1");
            //SStudent.(stud => stud.duration > 45);
            //if (SStudent.Exists(cust => cust.name.StartsWith("T")))
            //    Console.WriteLine("Student exists1");
            //student sttemp = SStudent.Find(cust => cust.duration > 45);
            //Console.WriteLine("_________________________________________");
            //Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", sttemp.name, sttemp.coursename, sttemp.duration);
            //student sttemp1 = SStudent.FindLast(cust => cust.duration > 45);
            //Console.WriteLine("_________________________________________");
            //Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", sttemp1.name, sttemp1.coursename, sttemp1.duration);

            //List<student> sttemp2 = SStudent.FindAll(cust => cust.duration > 45);


            Console.ReadLine();
        }

    }
    public class student
    {
        public int studentid { get; set; }
        public string name { get; set; }
        public string coursename { get; set; }
        public int duration { get; set; }
    };
}
