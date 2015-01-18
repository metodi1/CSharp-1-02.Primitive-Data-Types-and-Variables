using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A marketing company wants to keep record of its employees. 
//Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single 
//employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

namespace Problem_10.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Ivan";
            string LastName = "Ivanov";
            byte Age = 32;
            char Gender = 'M';
            ulong ID = 8306112507;
            ushort UniqueEmployeeNumber = 1;

            Console.WriteLine("First Name:{0} is string\nLast Name:{1} is string\nAge:{2} is byte\nGender:{3} is char\nID:{4} is ulong\nUniqueEmployeeNumber:2756{5,0:D4} is ushort", FirstName, LastName, Age, Gender, ID, UniqueEmployeeNumber);
        }
    }
}
