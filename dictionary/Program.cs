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
            Console.Clear();
         
            Dictionary<int, student> dictionaryStudent = new Dictionary<int, student>();
            dictionaryStudent.Add(st1.studentid, st1);
            dictionaryStudent.Add(st2.studentid, st2);
            dictionaryStudent.Add(st3.studentid, st3);
            dictionaryStudent.Add(st4.studentid, st4);
            dictionaryStudent.Add(st5.studentid, st5);
            foreach (KeyValuePair<int, student> item in dictionaryStudent)
            {
                Console.WriteLine("Key is:{0}", item.Key);
                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}, StudentID:{3}", item.Value.name,item.Value.coursename,item.Value.duration, item.Value.studentid);
                Console.WriteLine("_________________________________________");
            }

            Console.WriteLine("Looping though student class");
            foreach (student item in dictionaryStudent.Values)
            {
      
                Console.WriteLine("Student ID:{3},Student name:{0}, Course:{1},Duration:{2}", item.name, item.coursename, item.duration, item.studentid);
                Console.WriteLine("_________________________________________");
            }
            Console.WriteLine("Looping though student IDs");
            foreach (int item in dictionaryStudent.Keys)
            {

                Console.WriteLine("Student ID:{0}", item);
                Console.WriteLine("_________________________________________");
            }

            student sttemp = dictionaryStudent[4];
            Console.WriteLine("Key is:{0}", sttemp.studentid);
            Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", sttemp.name, sttemp.coursename, sttemp.duration);
            Console.WriteLine("_________________________________________");

            if (dictionaryStudent.ContainsKey(4))
                Console.WriteLine("Student exists1");
            if (dictionaryStudent.ContainsValue(st4))
                Console.WriteLine("Student exists2");
          //  student sttemp;
            if (dictionaryStudent.TryGetValue(7, out sttemp))
            {
                Console.WriteLine("Student exists3");
                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", sttemp.name, sttemp.coursename, sttemp.duration);

            }

            


            dictionaryStudent.Remove(1);
            foreach (KeyValuePair<int, student> item in dictionaryStudent)
            {
                Console.WriteLine("Key is:{0}", item.Key);
                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.Value.name, item.Value.coursename, item.Value.duration);
                Console.WriteLine("_________________________________________");
            }
            Console.WriteLine("Dictionary count:{0}", dictionaryStudent.Count);
            dictionaryStudent.Clear();
           // dictionaryStudent.find();
            Console.WriteLine("After clearing");
            Console.WriteLine("Dictionary count:{0}", dictionaryStudent.Count);

            foreach (KeyValuePair<int, student> item in dictionaryStudent)
            {
                Console.WriteLine("Key is:{0}", item.Key);
                Console.WriteLine("Student name:{0}, Course:{1},Duration:{2}", item.Value.name, item.Value.coursename, item.Value.duration);
                Console.WriteLine("_________________________________________");
            }

            //student[] students = new student[4];
            //students[0] = st1;
            //students[1] = st2;
            //students[2] = st3;
            //students[3] = st4;
            ////students.ToDictionary(sttemp => studentid,sttemp =>sttemp);

            //Dictionary<int, student> dictionaryStudent1 = new Dictionary<int, student>();
            ////var dictionary = Enumerable.Range(0, students.Length).ToDictionary(x => students[x]);
            //var dictionary = students.Select((value, index) => new { value, index })
            //          .ToDictionary(pair => pair.value, pair => pair.index);

           
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
