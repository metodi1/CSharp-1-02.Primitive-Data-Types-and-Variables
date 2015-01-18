using System;

namespace Problem_13.Comparing_Floats
{
    class Comparing_Floats
    {
        //Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
        //Note: Two floating-point numbers a and b cannot be compared directly by a == b 
        //because of the nature of the floating-point arithmetic. Therefore, we assume two 
        //numbers are equal if they are more closely to each other than a fixed constant eps.

        //Examples:
        //Number a	Number b	Equal (with precision eps=0.000001)	Explanation
        //5.3	6.01	false	The difference of 0.71 is too big (> eps)
        //5.00000001	5.00000003	true	The difference 0.00000002 < eps
        //5.00000005	5.00000001	true	The difference 0.00000004 < eps
        //-0.0000007	0.00000007	true	The difference 0.00000077 < eps
        //-4.999999	-4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
        //4.999999	4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
        static void Main()
        {
            //precision
            double eps = 0.000001;

            //Read numbers from console.
            Console.WriteLine("Enter numberA:");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter numberB:");
            double numberB = Convert.ToDouble(Console.ReadLine());

            //The absolute value
            double result = Math.Abs(numberA - numberB);

            //compare the absolute value and eps. Printig the result.
            if (result < eps)
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine("The numbers are different");
            }
            
    
        }
    }
}
