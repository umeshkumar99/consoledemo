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
            List< student> ListStudent = new List<student>();
            ListStudent.Add( st1);
            ListStudent.Add(st2);
            ListStudent.Add(st3);
            ListStudent.Add( st4);
            ListStudent.Add(st5);
            if (ListStudent.Contains(st5))
                Console.WriteLine("Student exists1");
            //List<student> ListStudent1 = ListStudent.(stud => stud.);
            //ListStudent.Where(cust => cust.name.StartsWith("T")) &&  cust.duration > 45);
            if (ListStudent.Exists(cust => cust.name.StartsWith("T")))
            Console.WriteLine("Student exists1");
            student sttemp = ListStudent.Find(cust => cust.duration > 45);
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", sttemp.name, sttemp.coursename, sttemp.duration);
            student sttemp1 = ListStudent.FindLast(cust => cust.duration > 45);
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", sttemp1.name, sttemp1.coursename, sttemp1.duration);

            //testing
            Console.Clear();
            List<student> sttemp2 = ListStudent.FindAll(cust => cust.duration >= 45 && cust.name.StartsWith("u"));
            foreach ( student item in sttemp2)
            {
               
                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }

            ListStudent.Sort();
            Console.WriteLine("List after sort by duration\n");
            foreach (student item in ListStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }

            Console.WriteLine("List after reverse sort by duration\n");
            ListStudent.Sort();
            ListStudent.Reverse();
            foreach (student item in ListStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }
            SortByName sname = new SortByName();
            ListStudent.Sort(sname);
            Console.WriteLine("List after sort by Name\n");
            foreach (student item in ListStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }

            SortBycoursename cname = new SortBycoursename();
            ListStudent.Sort(cname);
            Console.WriteLine("List after sort by course name\n");
            foreach (student item in ListStudent)
            {

                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration);
                Console.WriteLine("_________________________________________");
            }


            Console.ReadLine();
        }

    }
    public class student : IComparable<student> 
    {
        public int studentid { get; set; }
        public string name { get; set; }
        public string coursename { get; set; }
        public int duration { get; set; }

        public int CompareTo(student other)
        {
            //if(this.duration>other.duration)
            //return 1;
            //else if (this.duration < other.duration)
            //    return -1;
            //else 
            //    return 0;
            return this.duration.CompareTo(other.duration);

        }
    };



    public class SortByName : IComparer<student>
    {
        public int Compare(student x, student y)
        {
            return x.name.CompareTo(y.name);
        }

    }
    public class SortBycoursename : IComparer<student>
    {
        public int Compare(student x, student y)
        {
            return x.coursename.CompareTo(y.coursename);
        }

    }

    

}
