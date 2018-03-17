using System;
using System.Collections.Generic;

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

            Queue<student> QStudent = new Queue<student>();
            QStudent.Enqueue(st1);
            QStudent.Enqueue(st2);
            QStudent.Enqueue(st3);
            QStudent.Enqueue(st4);
            QStudent.Enqueue(st5);
            student Qtemp=   QStudent.Dequeue();

            Console.WriteLine("NO. of student in Queue are :{0}", QStudent.Count);
            foreach (student item in QStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }
             Qtemp = QStudent.Dequeue();
            Console.WriteLine("NO. of student in Queue are :{0}", QStudent.Count);
            foreach (student item in QStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }
             Qtemp = QStudent.Dequeue();
            Console.WriteLine("NO. of student in Queue are :{0}", QStudent.Count);
            foreach (student item in QStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }
             Qtemp = QStudent.Dequeue();
            Console.WriteLine("NO. of student in Queue are :{0}", QStudent.Count);
            foreach (student item in QStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }

            Qtemp = QStudent.Peek();
            Console.WriteLine("NO. of student in Queue are :{0}", QStudent.Count);
            foreach (student item in QStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }





            if (QStudent.Contains(st5))
                Console.WriteLine("Student exists1");
            //QStudent.(stud => stud.duration > 45);
            //if (QStudent.Exists(cust => cust.name.StartsWith("T")))
            //    Console.WriteLine("Student exists1");
            //student sttemp = QStudent.Find(cust => cust.duration > 45);
            //Console.WriteLine("_________________________________________");
            //Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", sttemp.name, sttemp.coursename, sttemp.duration);
            //student sttemp1 = QStudent.FindLast(cust => cust.duration > 45);
            //Console.WriteLine("_________________________________________");
            //Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", sttemp1.name, sttemp1.coursename, sttemp1.duration);

            //List<student> sttemp2 = QStudent.FindAll(cust => cust.duration > 45);


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
