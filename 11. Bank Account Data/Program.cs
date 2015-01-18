using System;


//A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
//bank name, IBAN, 3 credit card numbers associated with the account.Declare the variables needed to keep the 
//information for a single bank account using the appropriate data types and descriptive names.

namespace Problem_11.Bank_Account_Data
{
    class BankAccountData
    {
        static void Main()
        {
            //Declare the variables
            string firstName = "Ivan";
            string midleName = "Ivanov";
            string lastName = "Ivanov";
            decimal balance = 10000000000.99M;
            string bankName = "KTB";
            string IBAN = "BG80KTBBG6611020345678";
            long creditCard1 = 1234567891234;
            long creditCard2 = 9234567891234;
            long creditCard3 = 8234567891234;

            //print variables
            Console.WriteLine("First Name:{0} is string\nMidle Name:{1} is string\nLast name:{2} is string", firstName, midleName, lastName);
            Console.WriteLine("Balance:{0} is decimal\nBank name:{1} is string\nIBAN:{2} is string", balance, bankName, IBAN);
            Console.WriteLine("Credit card numbers associated with the account are long");
            Console.WriteLine("The account of credit card number 1 is{0},\nThe account of credit card number 2 is{1}", creditCard1, creditCard2);
            Console.WriteLine("The account of credit card number 3 is{0}", creditCard3);
        }
    }
}
