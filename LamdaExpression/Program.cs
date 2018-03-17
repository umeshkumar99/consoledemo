using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    class Program
    {
        delegate void TestDelegate(string s);
        static void Main(string[] args)
        {

          //  string n = "Hello ";
            TestDelegate del = n => {
                string s = n + " World";
                Console.WriteLine(s);

            };
            Console.ReadLine();
        }
    }
}
