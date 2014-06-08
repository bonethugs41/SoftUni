//A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class AccountData
{
    static void Main()
    {
        string firstName = "Gosho";
        string middleName = "Petkov";
        string lastName = "Ivanov";
        object holder = firstName + " " + middleName + " " + lastName;
        double moneyBalance = -432.445;
        string bankName = "Iron Bank of Braavos";
        string IBAN = "BR7832IS32978434555";
        long firstCardNum = 9562214421556588;
        long secondCardNum = 9562217621226554;
        long thirdCardNum = 9562211431562998;
    }
}