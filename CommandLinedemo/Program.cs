//Copyright (C) Microsoft Corporation.  All rights reserved.

// cmdline2.cs
// arguments: John Paul Mary
using System;
using System.Text;

public class CommandLine2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Number of command line parameters = {0}",
           args.Length);
        foreach (string s in args)
        {
            Console.WriteLine(s);
        }
        Console.ReadLine();
        string str = "0";
        for (int i = 0; i < 100; i++)
        {
            str = Convert.ToString((Convert.ToInt32(str) + i));
            Console.Write("\t{0}", str);
        }
        Console.ReadLine();

        StringBuilder str1 = new StringBuilder("p");

        for (long i1 = 0; i1 < 10; i1++)
        {
            // i1 = i1 + Convert.ToInt32(str1.ToString());
            str1.Append(str1.ToString());
            Console.Write("\t{0}, i={1}", str1.ToString(), i1);
        }
        Console.ReadLine();
    }
}

