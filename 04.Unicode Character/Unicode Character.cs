using System;
using System.Text;

//Declare a character variable and assign it with the symbol that has Unicode code 42
//(decimal) using the \u00XX syntax, and then print it.
//Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.

class Problem_4_Unicode_Character
{
    static void Main()
    {

        char code = '\u002A';
        Console.WriteLine(code);

    }
}

