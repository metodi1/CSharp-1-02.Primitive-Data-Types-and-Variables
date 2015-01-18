using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare two integer variables a and b and assign them with 5 and 10 and after 
//that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

class Problem_9_Exchange_Variable_Values
{
    static void Main()
    {
        //Declare and assign two integer variables a and b
        byte a = 5;
        byte b = 10;

        Console.WriteLine("Variable values before the exchange are:a={0} b={1}", a, b);

        //assign a to c
        byte c = a;


        //assign a to b, b to c
        a = b;
        b = c;
        Console.WriteLine("Variable values after the exchange are:a={0} b={1}", a, b);


    }
}
