using System;
//using System.Linq;
using Microsoft.Office.Interop.Excel;


namespace ConsoleDemo
{
    class Program
    {

        public static void swap(ref int a1, ref int a2)
        {

            int temp;
            temp = a2;
            a2 = a1;
            a1 = temp;
        }
        public static void ArrCheck()
        {
            //int age=6,das=88;
            //const int sal = 12000;
            //age = 8998;
            //string name = "umesh verma";
            //char gender = 'F';
                int[] numarr = new int[5];//={1 ,2,3,4,5,6,7,8,9,10};
            //int o = .ToInt3C2( "898");
            //int.TryParse()

            //numarr[0] = 1;

            //numarr[1] = 1;

            //numarr[2] = 1;
            for (int i = 0; i < numarr.Length; i++)
            {
                if (i == 2)
                    break;
                Console.WriteLine("Enter value for element[{0}]", i+1);
                /*numarr[i] = Convert.ToInt32(Console.ReadLine());*/
                bool result;
                 result = int.TryParse(Console.ReadLine(), out numarr[i]);
                if (!result)
                    Console.WriteLine("You have entered invalid number for element [{0}]", i + 1);
               
            }

            for (int i = 0; i < numarr.Length; i++)
            {
                Console.WriteLine("Entered value for element[{0}]={1}", i+1,numarr[i]);
                
            }
        }
        public static  void CheckEvenOdd(int num)
        {
            if (num % 2 == 0)
                Console.WriteLine("\n {0} is even number", num);
           // return 1;
            else
                Console.WriteLine("\n {0} is Odd number", num);
           // return 2;
        }

        public static void GetEvenOdd(int num)
        {
            for (int i = 1; i < num; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("\ni={0} is even number", i);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="age"></param>
        public static void GetLoan(int age)
        {
            
            if (age > 16 && age < 30)
            {
                Console.WriteLine("you are eligible for education loan");
            }
            else if (age > 40 && age < 60)
            {
                Console.WriteLine("you are eligible for home loan");
            }
            else if (age > 60 && age < 70)
            {
                Console.WriteLine("you are eligible for govt health insurance");
            }
            else
            {
                Console.WriteLine("you are not eligible for any kind of loan");
            }
        }


        public static int getWeekday(int wkday)
        {
            string wkname;
            switch (wkday)
            {
                case 1:
                    {
                        wkname = "Sunday";
                        break;
                    }
                case 2:
                    {
                        wkname = "Monday";
                        break;
                    }
                case 3:
                    {
                        wkname = "Tuesday";
                        break;
                    }
                case 4:
                    {
                        wkname = "Wednesday";
                        break;
                    }
                case 5:
                    {
                        wkname = "Thursday";
                        break;
                    }
                case 6:
                    {
                        wkname = "Friday";
                        break;
                    }
                case 7:
                    {
                        wkname = "Saturday";
                        break;
                    }
                default:
                    wkname = "Wrong week of the day";
                    break;
            }

            Console.WriteLine("Week day is:{0}", wkname);
            return 1;

        }

        static void Main(string[] args)
        {
            try
            {
                //string myname = "umesh verma";
                //////Console.WriteLine("size");
                //Console.WriteLine(" Properties of Integer are:{0},\t {1}.\t {2}\t{3} \n\f\v", int.MinValue, int.MaxValue, sizeof(int), default(int));
                //Console.WriteLine(" Properties of Float are:{0},\t {1}.\t {2}\t{3} \n", float.MinValue, float.MaxValue, sizeof(float), default(float));
                //Console.WriteLine(" Properties of double are:{0},\t {1}.\t {2}\t{3} \n", double.MinValue, double.MaxValue, sizeof(double), default(double));
                //Console.WriteLine(" Properties of UInt64 are:{0},\t {1}.\t {2}\t{3} \n", UInt64.MinValue, UInt64.MaxValue, sizeof(UInt64), default(UInt64));
                //Console.WriteLine(" Properties of Int64 are:{0},\t {1}.\t {2}\t{3} \n", Int64.MinValue, Int64.MaxValue, sizeof(Int64), default(Int64));


                //int i, age;
                //ConsoleKeyInfo ch=new ConsoleKeyInfo();

                //age:
                //Console.WriteLine("Please enter your age:");
                //age = Convert.ToInt32(Console.ReadLine());
                //GetLoan(age);

                //Console.WriteLine("Do you want to exit, Press X to exit:");
                //ch = Console.ReadKey();
                //if (Convert.ToChar(ch.Key) != 'X')
                //    goto age;
                //infinite for loop
                //for (;;)
                //{

                //}

                //infinite while loop
                //while(true)
                //{
                //    break;
                //}
                //do
                //{
                //    Console.WriteLine("\nPlease enter your age:");
                //    bool flag;
                //    string str= Console.ReadLine();
                //    flag =int.TryParse(str,out age);
                //    GetLoan(age);
                //    Console.WriteLine("\nDo you want to exit, Press X to exit:");
                //    ch = Console.ReadKey();
                //} while (Convert.ToChar(ch.Key) != 'X');


                //while (Convert.ToChar(ch.Key) != 'X') 
                //{
                //    Console.WriteLine("\nPlease enter your age:");
                //    bool flag;
                //    string str = Console.ReadLine();
                //    flag = int.TryParse(str, out age);
                //    GetLoan(age);
                //    Console.WriteLine("\nDo you want to exit, Press X to exit:");
                //    ch = Console.ReadKey();
                //} 
                //int num;
                //Console.WriteLine("\nPlease neter number to be checked for even and odd");
                //num=Convert.ToInt32(Console.ReadLine());
                //CheckEvenOdd(num);

                ////Console.WriteLine("{0}", int.Parse("22242424"));
                ////Console.WriteLine("{0}", int.TryParse("xwxw", out i));

                ////int? num = null;
                ////int flag;
                ////flag = num == 10 ? 20 : 30;
                ////Console.WriteLine("Number=10 is {0}", flag);
                ////int? availableticket = null;
                ////int actualtickets = availableticket == null ? 0 : (int)availableticket;
                ////int actualtickets1 = availableticket ?? 0;
                ////Console.WriteLine("Actual tickets={0}", actualtickets);
                ////int[] arr = new int[50];
                ////for (int i1 = 0; i1 < arr.Length; i1++)
                ////{
                ////    arr[i1] = (i1 + 1);
                ////}
                ////Console.WriteLine("maxnum:{0}, min:{1},{2},{3}", arr.Max(), arr.Min(), arr.LongLength, arr.Last());


                //int weeknum;
                //Console.WriteLine("\nPlease Enter weekday:");
                //weeknum = Convert.ToInt32(Console.ReadLine());
                //getWeekday(weeknum);
                //ArrCheck();
                //  CheckEvenOdd(10);
                //ArrCheck();
                int x = 10, y = 20;
                Console.WriteLine("\nValue of x={0} and y={1} before swapping", x, y);
                swap(ref x, ref y);
                Console.WriteLine("\nValue of x={0} and y={1} after swapping", x, y);
                Console.ReadLine();
                //string str = "umesh verma";

                //do
                //{

                //} while (true);
                //while (true)
                //{

                //}

                //if (true)
                //{

                //}

             
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}
