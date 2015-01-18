using System;



class Problem_6_Strings_and_Objects
{
    static void Main()
    {
        //Declare two string variables and assign them with Hello and World.
        //Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
        //Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

        string var1 = "Hello";
        string var2 = "World";

        //concatenation of the first two variables
        object concatenation = var1 + ' ' + var2;

        //cast object to string
        string var3 = (string)concatenation;

        //print var3 with the value of the object variable 
        Console.WriteLine(var3);
    }
}


