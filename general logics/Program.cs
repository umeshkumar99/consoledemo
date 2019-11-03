//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace general_logics
//{
//    class Program
//    {
//       static void calsum()
//        {
//            string num1, num2, result = string.Empty;
//            int temp=0, overflow = 0;
//            Console.WriteLine("\nPlease enter first no:");
//            num1 = Console.ReadLine();
//            Console.WriteLine("\nPlease enter second no:");
//            num2 = Console.ReadLine();

//            for ( int i= num1.Length; i >= 0; i--)
//            {
//                if (num1.Length == num2.Length)
//                    temp = Convert.ToInt32(((char)num1[i]).ToString()) + Convert.ToInt32(((char)num2[i]).ToString()) + overflow;



//                if (temp > 10)
//                {
//                    overflow = 1;
//                    result = temp.ToString().Substring(temp.ToString().Length - 1) + result;
//                }
//                else
//                {
//                    overflow = 0;
//                    result = temp.ToString() + result;
//                }
//                temp = 0;
//            }
//            Console.WriteLine("result={0}", result);
//            Console.ReadLine();
//        }

//        //program to sum any two numbers of any size

//        static void calsum1()
//        {
//            string num1, num2, result = string.Empty;
//            int temp = 0, overflow = 0;
//            Console.WriteLine("\nPlease enter first no:");
//            num1 = Console.ReadLine();
//            Console.WriteLine("\nPlease enter second no:");
//            num2 = Console.ReadLine();
//            int i = num1.Length-1;// num1.Length > num2.Length ? num1.Length - 1 : num2.Length - 1;
//            int j = num2.Length - 1;
//            for (; i >= 0 || j>=0; i--,j--)
//            {
//                if (num1.Length == num2.Length)
//                    temp = Convert.ToInt32(((char)num1[i]).ToString()) + Convert.ToInt32(((char)num2[j]).ToString()) + overflow;
//                else if (num1.Length > num2.Length && j >= 0)
//                    temp = Convert.ToInt32(((char)num1[i]).ToString()) + Convert.ToInt32(((char)num2[j]).ToString()) + overflow;
//                else if (num1.Length < num2.Length && i >= 0)
//                    temp = Convert.ToInt32(((char)num1[i]).ToString()) + Convert.ToInt32(((char)num2[j]).ToString()) + overflow;
//                else if (num1.Length > num2.Length && j<=0)
//                    temp = Convert.ToInt32(((char)num1[i]).ToString());
//                else if (num1.Length < num2.Length && i <= 0)
//                    temp = Convert.ToInt32(((char)num1[j]).ToString());


//                if (temp >= 10)
//                {
//                    overflow = 1;
//                    result = temp.ToString().Substring(temp.ToString().Length - 1) + result;
//                }
//                else
//                {
//                    overflow = 0;
//                    result = temp.ToString() + result;
//                }
//               // temp = 0;
//            }
//            if (overflow == 1)
//                result = overflow.ToString() + result;

//            Console.WriteLine("result={0}", result);
//            Console.ReadLine();
//        }

//        static void Main(string[] args)
//        {
//            calsum1();
//        }
//    }
//}


//using System;

//public class Palindrome
//{
//    public static bool IsPalindrome(string word)
//    {
//        bool flag = false;
//        char[] cword = word.ToUpper().ToCharArray();
//        int strlen = word.Length / 2;
//        for (int i = 0, j = word.Length; i < strlen; i++, j--)
//        {

//            if (cword[i] != cword[j - 1])
//            {
//                flag = false;
//                break;
//            }
//            else
//                flag = true;
//        }
//        return flag;
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
//        Console.ReadLine();
//    }
//}

//using System;

//public class TextInput
//{

//    protected string result = "";
//    public virtual void Add(char ch)
//    {
//        result = result + ch;
//    }
//    public virtual string GetValue()
//    {
//        return result;
//    }
//}

//public class NumericInput : TextInput
//{

//    public override void Add(char ch)
//    {
//        //base.Add(ch);
//        int temp;
//        if (int.TryParse(ch.ToString(), out temp) == true)
//        {
//            result = result + ch.ToString();
//        }

//    }

//}

//public class UserInput
//{
//    public static void Main(string[] args)
//    {
//        TextInput input = new NumericInput();
//        input.Add('1');
//        input.Add('a');
//        input.Add('0');
//        Console.WriteLine(input.GetValue());
//        Array arr;


//        Console.ReadLine();
//    }
//}

using System;
//namespace PskillsConsoleApplication
//{
//    class Baseclass
//    {
//        int i;
//        public Baseclass(int ii)
//        {
//            i = ii;
//            Console.Write("Base ");
//        }
//    }
//    class Derived : Baseclass
//    {
//        public Derived(int ii) : base(ii)
//        {
//            Console.Write("Derived ");
//        }
//    }
//class MyFun
//{

//    class Fun { }
//    static void Main(string[] args)
//    {

//        string Fun = "hello, world";
//        string s = Fun;
//        Type t = typeof(Fun);
//        int[][] jagged = new int[3][];

//        //   Console.WriteLine(s);
//        Console.WriteLine(t);
//        Console.ReadLine();
//    }
//}
//using System;
using System.Reflection;

//class myfun
//{
//    static void fun()
//    {
//        Console.WriteLine("fun");
//    }
//    static void fun(int i)
//    {
//        Console.WriteLine("int");
//    }
//    static void fun(double d)
//    {
//        Console.WriteLine("double");
//    }
//    static void fun(object o)
//    {
//        Console.WriteLine("object");
//    }

//    static void Main()
//    {
//        fun("1.0");
//        Console.ReadLine();
//    }

//}


//using System;

namespace Trial
{
    class Program
    {
        /*
         * Complete the function below.
         * DO NOT MODIFY CODE OUTSIDE THIS FUNCTION!
         */
        //interface fun{
        //    void fun();
        //    void fun(int x);
        //    void fun(ref int  x);
        //    void fun(int x);

        //}
        public static  void foo(int i)
            {
            i=20;
            }
        static string[] twins(string[] a, string[] b)
        {

            string[] result=new string[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                string temp = even(odd(a[i]));
                if (temp == b[i])
                    result[i] = "Yes";
                else
                    result[i] = "No";
                //Console.WriteLine("\nafter opertaion temp={0}", temp);
            }
            return  result;

        }
        static string odd(string strInput)
        {
           
            char ch;
            char[] charStr = strInput.ToCharArray();
            for (int i = 0; i < strInput.Length; i += 2)
            {
                ch = charStr[i];
                if ((i + 2) < strInput.Length)
                {
                    charStr[i] = charStr[i + 2];
                    charStr[i + 2] = ch;
                }
            }
            return  new string( charStr);

        }

        static string even(string strInput)
        {

            char ch;
            char[] charStr = strInput.ToCharArray();
            for (int i = 1; i < strInput.Length; i += 2)
            {
                ch = charStr[i];
                if ((i + 2) < strInput.Length)
                {
                    charStr[i] = charStr[i + 2];
                    charStr[i + 2] = ch;
                }
            }
            return new string(charStr);

        }

        // DO NOT MODIFY CODE OUTSIDE THE ABOVE FUNCTION!
        public class Customer
        {
            public Guid customerID { get; set; } = Guid.NewGuid();
        }

        static void Main(String[] args)
        {

            
            //int i = 10;
            //foo(i);
            //Console.WriteLine("i={0}", i);

            //List<int> a = new List<int>();
            //a.Add(10);
            //a.Add(20);
            //List<int> b = new List<int>();
            //b.Add(10);
            //b.Add(20);
            //b.Add(50);
            //Console.WriteLine(a==b);
            //System.Text.StringBuilder cb = new System.Text.StringBuilder();
         
            string[] res;

            int _a_size = 0;
            Console.WriteLine("Please string lenght");
            _a_size = Convert.ToInt32(Console.ReadLine());
            string[] _a = new string[_a_size];
            string _a_item;
            for (int _a_i = 0; _a_i < _a_size; _a_i++)
            {
                _a_item = Console.ReadLine();
                _a[_a_i] = _a_item;
            }


            int _b_size = 0;
            _b_size = Convert.ToInt32(Console.ReadLine());
            string[] _b = new string[_b_size];
            string _b_item;
            for (int _b_i = 0; _b_i < _b_size; _b_i++)
            {
                _b_item = Console.ReadLine();
                _b[_b_i] = _b_item;
            }

            res = twins(_a, _b);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
            Console.ReadLine();
        }
    }
}