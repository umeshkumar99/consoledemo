using System;
using System.Threading;
using System.Diagnostics;

namespace MultiThreading
{
    class Program
    {
        public static int onemill = 0;
        public static void addonemill()
        {
            //  onemill = 0;
            for (int i = 0; i < 1000000; i++)
            {
                // Interlocked.Increment(ref onemill);
                onemill++;
            }
            Console.WriteLine("the sum of one million numbers is: {0}", onemill);
        }
        public static void addonemillI()
        {
            // onemill = 0;
            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Increment(ref onemill);
                //onemill++;
            }
            Console.WriteLine("the sum of one million umbers is: {0}", onemill);
        }
        static object _lock = new object();
        public static void addonemillL()
        {

            // onemill = 0;
            for (int i = 0; i < 100; i++)
            {
                lock (_lock)
                {
                    onemill++;
                    Console.WriteLine("the sum of one million number is: {0}", onemill);
                }
            }
            Console.WriteLine("the sum of one million number is: {0}", onemill);
        }
        public static void evennumber()
        {
            double evennum = 0;
            for (int i = 0; i < 100000000; i++)
            {
                if (i % 2 == 0)
                    evennum = evennum + 1;
            }
            Console.WriteLine("the sum of even numbers is: {0}", evennum);
        }

        public static void oddnnumber()
        {
            double oddnum = 0;
            for (int i = 0; i < 100000000; i++)
            {
                if (i % 2 == 1)
                    oddnum = oddnum + 1;
            }
            Console.WriteLine("the sum of odd numbers is: {0}", oddnum);
        }

        public static void evennumberT()
        {
            double evennum = 0;
            for (int i = 0; i < 100000000; i++)
            {
                if (i % 2 == 0)
                    evennum = evennum + 1;
            }
            Console.WriteLine("the sum of even numbers with threading is: {0}", evennum);
            Thread.Sleep(5000);
        }

        public static void oddnnumberT()
        {
            double oddnum = 0;
            for (int i = 0; i < 100000000; i++)
            {
                if (i % 2 == 1)
                    oddnum = oddnum + 1;
            }
            Console.WriteLine("the sum of odd numbers with threading is: {0}", oddnum);
            Thread.Sleep(3000);
        }
        public static void maincall()
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            // st = Stopwatch.StartNew();
            evennumber();
            oddnnumber();
            st.Stop();
            Console.WriteLine("Total time elapsed is :" + st.ElapsedMilliseconds);
            st.Reset();
            // st = Stopwatch.StartNew();
            st.Start();
            Thread td1 = new Thread(evennumberT);
            Thread td2 = new Thread(oddnnumberT);
            td1.Start();
            td2.Start();
            if (td1.Join(1000))// worker thread join main thread with elapse time of 1 second
                Console.WriteLine("thread1 finish");
            else
                Console.WriteLine("thread1 did not finish in 1 second");

            td2.Join();// worker thread join main thread 
            for (int i = 0; i < 10; i++)
            {
                if (td1.IsAlive)// check if main thread1 still busy
                    Console.WriteLine("Thread1 is still working");
                else
                    Console.WriteLine("thread1 finish");
            }
            st.Stop();
            Console.WriteLine("Total time elapsed with multihtreading is :" + st.ElapsedMilliseconds);
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("processor count without mutithreading  is:" + Environment.ProcessorCount);
            // maincall();
            //addonemill();
            //addonemill();
            //Console.WriteLine("the Initial vlue of one million number is {0}", onemill);
            
            Thread t1 = new Thread(addonemillL);
            t1.Priority = ThreadPriority.Highest;
            //Thread t2 = new Thread(addonemillL);
            //Thread t3 = new Thread(addonemillL);
            Console.WriteLine("the Initial vlue of one million number is {0}", onemill);
            t1.Start();

            for (int i = 100; i < 200; i++)
            {
                
                    
                    Console.WriteLine("the counter from main thread: {0}", i);
                
            }
           

            // t2.Start();
            //t3.Start();
            t1.Join();
            //t2.Join();
            //t3.Join();
            t1.Abort();
            
            Console.WriteLine("the sum of one million number are: {0}", onemill);
            Console.ReadLine();
        }
    }
}
