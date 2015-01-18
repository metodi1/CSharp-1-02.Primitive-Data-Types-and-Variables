using System;
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.


class Null_Values_Arithmetic
{
    static void Main()
    {
        //assigns null values
        int? integerNull = null;
        double? doubleNull = null;

        //print null variables at the console
        Console.WriteLine("This is null value of integer:{0}", integerNull);
        Console.WriteLine("This is null value of double:{0}", doubleNull);

        //add some number
        integerNull = 21;
        doubleNull = 10;

        //print null variables after added number at the console
        Console.WriteLine("This is null value of integer after added some number:{0}", integerNull);
        Console.WriteLine("This is null value of double after added some number:{0}", doubleNull);
    }
}

