//Copyright (C) Microsoft Corporation.  All rights reserved.

using System;
using System.IO;


public class myexception : Exception
{
    public myexception() : base()
    { }

   public myexception(string str) : base(str)
    { }
   public myexception(string str, Exception ex) : base(str, ex)
    { }
}
class NullableBasics
{
    static void DisplayValue(int? num)
    {
        if (num.HasValue == true)
        {
            Console.WriteLine("num = " + num);
        }
        else
        {
            Console.WriteLine("num = null");
        }

        // num.Value throws an InvalidOperationException if num.HasValue is false
        try
        {
            Console.WriteLine("value = {0}", num.Value);
        }

        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);


        }
        catch (IndexOutOfRangeException e)
        {
          
            Console.WriteLine(e.Message);

        }
        //{

        //}
        catch (DivideByZeroException e1)
        {
           //e1.InnerException.Message
            Console.WriteLine(e1.Message);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

        }
        finally
        {

            Console.WriteLine("finally called");
        }

        try
        {
            double? sal;
            Console.WriteLine("Enter sal:");
            sal = Convert.ToDouble( Console.ReadLine());
            if(sal<10000)
            {
            //    throw new myexception("Salary not in range");
           // Console.WriteLine("hi");
            throw new myexception("Sal out of range");
            }
        }
        catch (myexception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

  

    static void Main()
    {
        DisplayValue(1);
        Console.ReadLine();
        DisplayValue(null);
        Console.ReadLine();
    }
}