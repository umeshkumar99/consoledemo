using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace general_logics
{
    class Program
    {
       static void calsum()
        {
            string num1, num2, result = string.Empty;
            int temp=0, overflow = 0;
            Console.WriteLine("\nPlease enter first no:");
            num1 = Console.ReadLine();
            Console.WriteLine("\nPlease enter second no:");
            num2 = Console.ReadLine();
           
            for ( int i= num1.Length; i >= 0; i--)
            {
                if (num1.Length == num2.Length)
                    temp = Convert.ToInt32(((char)num1[i]).ToString()) + Convert.ToInt32(((char)num2[i]).ToString()) + overflow;
              


                if (temp > 10)
                {
                    overflow = 1;
                    result = temp.ToString().Substring(temp.ToString().Length - 1) + result;
                }
                else
                {
                    overflow = 0;
                    result = temp.ToString() + result;
                }
                temp = 0;
            }
            Console.WriteLine("result={0}", result);
            Console.ReadLine();
        }

        //program to sum any two numbers of any size

        static void calsum1()
        {
            string num1, num2, result = string.Empty;
            int temp = 0, overflow = 0;
            Console.WriteLine("\nPlease enter first no:");
            num1 = Console.ReadLine();
            Console.WriteLine("\nPlease enter second no:");
            num2 = Console.ReadLine();
            int i = num1.Length-1;// num1.Length > num2.Length ? num1.Length - 1 : num2.Length - 1;
            int j = num2.Length - 1;
            for (; i >= 0 || j>=0; i--,j--)
            {
                if (num1.Length == num2.Length)
                    temp = Convert.ToInt32(((char)num1[i]).ToString()) + Convert.ToInt32(((char)num2[j]).ToString()) + overflow;
                else if (num1.Length > num2.Length && j >= 0)
                    temp = Convert.ToInt32(((char)num1[i]).ToString()) + Convert.ToInt32(((char)num2[j]).ToString()) + overflow;
                else if (num1.Length < num2.Length && i >= 0)
                    temp = Convert.ToInt32(((char)num1[i]).ToString()) + Convert.ToInt32(((char)num2[j]).ToString()) + overflow;
                else if (num1.Length > num2.Length && j<=0)
                    temp = Convert.ToInt32(((char)num1[i]).ToString());
                else if (num1.Length < num2.Length && i <= 0)
                    temp = Convert.ToInt32(((char)num1[j]).ToString());


                if (temp > 10)
                {
                    overflow = 1;
                    result = temp.ToString().Substring(temp.ToString().Length - 1) + result;
                }
                else
                {
                    overflow = 0;
                    result = temp.ToString() + result;
                }
                temp = 0;
            }
            Console.WriteLine("result={0}", result);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            calsum1();
        }
    }
}
