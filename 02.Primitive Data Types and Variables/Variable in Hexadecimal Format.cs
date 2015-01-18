using System;



class Problem_3_Variable_in_Hexadecimal_Format
{
    static void Main()
    //Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
    //Use Windows Calculator to find its hexadecimal representation.
    //Print the variable and ensure that the result is 254.
    {


        int value = Convert.ToInt32("0xFE", 16);
        Console.WriteLine(value);
    }

}

