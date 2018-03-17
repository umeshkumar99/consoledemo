using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOpsConceptdata
{
    public static class class1
    {
        public static string myname;
        public static int age;
        public static double sal;
        // public int i;

    }
    public class class2
    {

        private int empid;
            private string address;
        public string myname;
        public int age;
        public double sal = 11000;
        public double bonus;
        protected internal double totalsal;
        public string name { get; set; }
        public class2()
        { address = ""; myname = ""; age = 0; sal = 0.0; bonus = 0.0; totalsal = 0.0; }

        public class2(string _address, int _age, double _sal, string _myname)
        { address = _address; myname = _myname; age = _age; sal = _sal; bonus = (0.2 * _sal); totalsal = _sal + bonus; }

        public int id { get
            {
                return empid;
            }
                 set
            {
                empid = value;

            }
                
                }
        public virtual void calcbonus()
        {
            bonus = (20.00 / 100.00) * sal;
            return;
        }


        public virtual void getdata()
        {
            Console.WriteLine("\nYou Nameis:{0}, age:{1},address:{2},Sal:{3},bonus:{4},totalsal:{5}", this.myname, this.age, this.address, this.sal, this.bonus, this.totalsal);
        }
        ~class2()
        {

        }

    }

    
    public class PClass3
    {
        private string Pmyname;
        internal int Page;
        public double Psal;
    }
    public class PClass2 : class2
    {
        //public string myname;
        //public int age;
        //public double sal;
        public PClass2(string _address, int _age, double _sal, string _myname) : base(_address, _age, _sal, _myname)
        {

        }
        public override void calcbonus()
        {
            //   base.calcbonus();
            bonus = (50.00 / 100.00) * sal;
            totalsal = bonus + sal;
            return;
            //base.calcbonus(cls2);
        }
        public double getTotalsal()
        {
            return totalsal;
        }
        public void setData()
        {

        }
        public override void getdata()
        {
            base.getdata();
            Console.WriteLine("\nYou Name is:{0}", this.myname);
            Console.WriteLine("\nYou is age:{0}", this.age);
            //Console.WriteLine("\nYou Nameis:{0}, age:{1},address:{2},Sal:{3},bonus:{4},totalsal:{5}", this.name, this.age, this.sal, this.bonus, this.totalsal);
            //Console.WriteLine("\nYou Nameis:{0}, ag e:{1},address:{2},Sal:{3},bonus:{4},totalsal:{5}", this.name, this.age, this.sal, this.bonus, this.totalsal);
            //Console.WriteLine("\nYou Nameis:{0}, age:{1},address:{2},Sal:{3},bonus:{4},totalsal:{5}", this.name, this.age, this.sal, this.bonus, this.totalsal);
            //Console.WriteLine("\nYou Nameis:{0}, age:{1},address:{2},Sal:{3},bonus:{4},totalsal:{5}", this.name, this.age, this.sal, this.bonus, this.totalsal);
        }
    }

    public sealed class clssealed
    {
        public string myname;
        public int age;
        public double sal;
        public double bonus;
    }

    //public clsdrivefromseal:clssealed
    //    {
    //    }

    public abstract class absmainclass
        {
        public string username;
        public string password;
        public string usercode;
        public bool status;

        public abstract void setData();
        public abstract void GetData();
        public void prnData()
        {

        }
    }

    public class MyUserdata : absmainclass
    {
        public override void GetData()
        {
            throw new NotImplementedException();
        }

        public override void setData()
        {
            throw new NotImplementedException();
        }
    }

    public  class PClass31: PClass3
    {
        public string myname;
        public int age;
        public double sal;
        public void Getvalues()
        {
            this.Page = 20;
            return;
        }

    }
    public interface Imyinterface
    {
         int calc2num(int i1, int i2);
        int mul2num(int i1, int i2);

    }
   public  interface Imyinterface1
    {
        int  sum2num(int i1, int i2);
        int mul2num(int i1, int i2);

    }
    interface ImyInterface2: Imyinterface
    {
        int calc3num(int i1, int i2, int i3);
        int mul3num(int i1, int i2,int i3);
    }

    public abstract class myAbstactclasas : ImyInterface2
    {
        public abstract int calc2num(int i1, int i2);
        public abstract int calc3num(int i1, int i2, int i3);
        public abstract int mul2num(int i1, int i2);
        public abstract int mul3num(int i1, int i2, int i3);
        public void getdata()
        {
            Console.WriteLine("This is test function");
        }
    }

    public class demointerface : ImyInterface2
    {
        public int calc2num(int i1, int i2)
        {
            throw new NotImplementedException();
        }

        public int calc3num(int i1, int i2, int i3)
        {
            throw new NotImplementedException();
        }

        public int mul2num(int i1, int i2)
        {
            throw new NotImplementedException();
        }

        public int mul3num(int i1, int i2, int i3)
        {
            throw new NotImplementedException();
        }
    }


    public class myclass : Imyinterface, Imyinterface1
    {
        public int calc2num(int i1, int i2)
        {
            throw new NotImplementedException();
        }

        public int mul2num(int i1, int i2)
        {
            throw new NotImplementedException();
        }

        public int sum2num(int i1, int i2)
        {
            throw new NotImplementedException();
        }
    }

    public class addingValues
    {
        //public int num1, num2, result;
        //public string str1, str2, sResult;
        //public DateTime dt1, dt2, dResult;
        //public double d1, d2, dbResult;

        public int add(int num1,int num2)
        {

            return num1 + num2;
        }


        public string add(string str1, string str2)
        {

            return str1 + " " +  str2;
        }

        public DateTime add(DateTime dt1, int days)
        {

            DateTime temp = dt1.AddDays(days);
            return temp;
        }

        public double add(double num1, double num2)
        {

            return num1 + num2;
        }


        
    }

}
