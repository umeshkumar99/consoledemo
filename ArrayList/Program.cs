using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList can store items(elements) of any datatype.
                ArrayList resizes automatically as you add the elements.
                ArrayList values must be cast to appropriate data types before using it.
                ArrayList can contain multiple null and dulplicate items.
                ArrayList can be accessed using foreach or for loop or indexer.
                Use Add(), AddRange(), Remove(), RemoveRange(), Insert(), InsertRange(), Sort(), Reverse() methods.*/

            /* demo to add data in array list*/
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(1);
            arryList1.Add("Two");
            arryList1.Add(3);
            arryList1.Add(4.5);

            ArrayList arryList2 = new ArrayList();
            arryList2.Add(100);
            arryList2.Add(200);

            //adding entire arryList2 into arryList1
            arryList1.AddRange(arryList2);
            ArrayList arrayList = new ArrayList() { 100, "Two", 12.5, 200 };


            //Access individual item using indexer
            int firstElement = (int)arryList1[0]; //returns 1
            string secondElement = (string)arryList1[1]; //returns "Two"
            int thirdElement = (int)arryList1[2]; //returns 3
            float fourthElement = (float)arryList1[3]; //returns 4.5

            //use var keyword
            var firstElementvar = arryList1[0];

            foreach (var val in arryList1)
                Console.WriteLine(val);
            //contains method to search for sepcific data in arraylist
            Console.WriteLine(arryList1.Contains(100));

            for (int i = 0; i < arryList2.Count; i++)
                Console.WriteLine(arryList2[i]);
            arryList1.Insert(1, "Second Item");
            arryList1.Insert(2, 100);

            Console.WriteLine("\nArraylist after inserting new element");
            foreach (var val in arryList1)
                Console.WriteLine(val);
            //arraylist add range at specific location example 
            ArrayList arryList3 = new ArrayList();
            arryList2.Add(10);
            arryList2.Add(20);
            arryList2.Add(30);
            arryList1.InsertRange(2, arryList3);

            foreach (var item in arryList2)
                Console.WriteLine(item);

            //remove demo
            arryList1.Remove(100); //Removes 1 from ArrayList

            foreach (var item in arryList1)
                Console.WriteLine(item);

            arryList1.RemoveAt(3); //Removes the third element from an ArrayList

            foreach (var item in arryList1)
                Console.WriteLine(item);

            arryList1.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)

            foreach (var item in arryList1)
                Console.WriteLine(item);

            arryList1.Clear();
            //sorting demo asc and desc
            arryList1.Add(300);
            arryList1.Add(200);
            arryList1.Add(100);
            arryList1.Add(500);
            arryList1.Add(400);

            Console.WriteLine("Original Order:");

            foreach (var item in arryList1)
                Console.WriteLine(item);

            arryList1.Reverse();
            Console.WriteLine("Reverse Order:");

            foreach (var item in arryList1)
                Console.WriteLine(item);

            arryList1.Sort();
            Console.WriteLine("Ascending Order:");

            foreach (var item in arryList1)
                Console.WriteLine(item);
            /* demo to add data in array list*/

        }
    }
}
