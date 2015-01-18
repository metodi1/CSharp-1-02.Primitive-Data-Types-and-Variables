using System;

class Problem_7_Quotes_in_Strings
{
    static void Main()
    {
//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

        string withQuoted = "The \"use\" of quotations causes difficulties.";
        string withoutQuoted = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(withQuoted);
        Console.WriteLine(withoutQuoted);

    }

}

