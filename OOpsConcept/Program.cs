using System;
using OOpsConceptdata;


namespace OOpsConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            try {


                //Console.WriteLine("Enter your name:");
            //class1.myname = Console.ReadLine();
            //Console.WriteLine("Enter your Sal:");
            //class1.sal = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter your Age:");
            //class1.age = Convert.ToInt32(Console.ReadLine());

            //class2 cls2 = new class2();
            //Console.WriteLine("Enter your name:");
            //cls2.myname = Console.ReadLine();
            //Console.WriteLine("Enter your Sal:");
            //class2.sal = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter your Age:");
            //cls2.age = Convert.ToInt32(Console.ReadLine());
            //OOpsConceptdata2.PClass2 cls3 = new OOpsConceptdata2.PClass2();
            //PClass3 pcls3 = new PClass3();
            //pcls3.Page = 50;
            //PClass31 pcls31 = new PClass31();
            class2 cl2 = new class2();
                class2 cl3 = new class2("Sector 14 gurgaon",23,12000.00,"Umesh Sharma");
                Console.WriteLine("\nData from base class:");
                cl3.getdata();
                PClass2 pcls2 = new PClass2("Sector 14 Dwarka",23,12000.00,"Umesh Verma");
                Console.WriteLine("\nData from derived class:");
                pcls2.getdata();
                 int num1=10, num2=20, result;
         string str1="Hare", str2="Krishna", sResult;
         DateTime dt1=Convert.ToDateTime( DateTime.Now.ToLongDateString()),  dResult; 
         double d1=1020.00, d2=700.50, dbResult;
        addingValues value1 = new addingValues();
                result = value1.add(num1, num2);
                dResult = value1.add(dt1, 12);
                sResult = value1.add(str1, str2);
                dbResult = value1.add(d1, d2);
                //  pcls2 = pcls2;
                //cl2.calcbonus();
                //pcls2.getTotalsal();

                //throw myexception;
                Console.ReadLine();



            }
            catch(myexception ex)
            {
               Console.WriteLine(ex.Message);
            }
        }
    }

    public class myexception: Exception
    {
       public myexception()
        { base.GetBaseException(); }
        //myexception(string str)
        //{ base{ str}; }
    }

   
}
