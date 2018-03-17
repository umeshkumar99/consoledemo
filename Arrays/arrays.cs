//Copyright (C) Microsoft Corporation.  All rights reserved.

// arrays.cs
using System;
class DeclareArraysSample
{

    public static void PrintIndexAndValues(String[] myArr)
    {
        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("   [{0}] : {1}", i, myArr[i]);
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        // Single-dimensional array
        int[] numbers = new int[5];
        Console.WriteLine("\nLength of array is {0}", numbers.Length);
        Array.Resize( ref numbers, 10);
        Console.WriteLine("\nLength of array is {0}", numbers.Length);
        // Multidimensional array
        string[,] names = new string[5,4];

        // Array-of-arrays (jagged array)
        byte[][] scores = new byte[7][];

        // Create the jagged array
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = new byte[i+3];
        }

        // Print length of each row
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
            Console.WriteLine("\nLength of row {0} is {1}", i, scores.Length);
        }


        // Create and initialize a new string array.
        String[] myArr = {"The", "quick", "brown", "fox", "jumps",
            "over", "the", "lazy", "dog"};

        // Display the values of the array.
        Console.WriteLine(
            "The string array initially contains the following values:");
        PrintIndexAndValues(myArr);

        // Resize the array to a bigger size (five elements larger).
        Array.Resize(ref myArr, myArr.Length + 5);

        // Display the values of the array.
        Console.WriteLine("After resizing to a larger size, ");
        Console.WriteLine("the string array contains the following values:");
        PrintIndexAndValues(myArr);

        // Resize the array to a smaller size (four elements).
        Array.Resize(ref myArr, 4);

        // Display the values of the array.
        Console.WriteLine("After resizing to a smaller size, ");
        Console.WriteLine("the string array contains the following values:");
        PrintIndexAndValues(myArr);
    //}

    



    Console.ReadLine();
    }
}


