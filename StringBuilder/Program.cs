using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            /*    StringBuilder is mutable.
                    StringBuilder performs faster than string when appending multiple string values.
                    Initialize StringBuilder as class e.g.StringBuilder sb = new StringBuilder()
                    Use StringBuilder when you need to append more than three or four strings.
                    Use Append() method to add or append strings with StringBuilder.
                    Use ToString() method to get the string from StringBuilder.

            StringBuilder.Append(valueToAppend)	Appends the passed values to the end of the current StringBuilder object.
            StringBuilder.AppendFormat()	Replaces a format specifier passed in a string with formatted text.
            StringBuilder.Insert(index, valueToAppend)	Inserts a string at the specified index of the current StringBuilder object.
            StringBuilder.Remove(int startIndex, int length)	Removes the specified number of characters from the given starting position of the current StringBuilder object.
            StringBuilder.Replace(oldValue, newValue)	Replaces characters with new characters.
    */


            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder("Hello World!!");
            StringBuilder sb2 = new StringBuilder(50);
            StringBuilder sb3 = new StringBuilder("Hello World!!", 50);
            //apend demo
            sb.Append("World!!");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("This is new line.");
            Console.WriteLine(sb);
            //append format demo 
            StringBuilder amountMsg = new StringBuilder("Your total amount is ");
            amountMsg.AppendFormat("{0:C} ", 25);

            Console.WriteLine(amountMsg);

            sb.Insert(5, " C#");
            Console.WriteLine(sb);
            sb.Append("Hello World!!");

            sb.Remove(6, 7);

            Console.WriteLine(sb);

            for (int i = 0; i < sb.Length; i++)
                Console.Write(sb[i]);

            string str = sb.ToString();

        }
    }
}
