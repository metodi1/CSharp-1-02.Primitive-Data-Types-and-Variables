using System;


namespace Problem_2.Float_or_Double
{
    class Problem_2_Float_or_Double
    {
        static void Main()
        {
            //Which of the following values can be assigned to a variable of type float and which to a variable
            //of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?Write a program to assign the numbers in 
            //variables and print them to ensure no precision is lost.

            double number1 = 34.567839023F;
            float number2 = 12.345F;
            double number3 = 8923.1234857D;
            float number4 = 3456.091F;

            Console.WriteLine("{0} is double, {1} is foat, {2} is double,\n {3} is float", number1, number2, number3, number4);

        }
    }
}
