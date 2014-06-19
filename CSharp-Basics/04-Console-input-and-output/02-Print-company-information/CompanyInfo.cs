//A company has name, address, phone number, fax number, web site and manager.
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Title = "Company info";

        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Company phone number: ");
        string companyPhone = Console.ReadLine();

        Console.Write("Company fax number: ");
        string companyFax = Console.ReadLine();

        Console.Write("Company web site: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager age: ");
        short managerAge = short.Parse(Console.ReadLine());

        Console.Write("Manager phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("\n\n\n");

        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + companyPhone);
        Console.WriteLine("Fax: " + companyFax);
        Console.WriteLine("Web site: " + companyWebSite);
        Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " (age: {0}, tel. {1})", managerPhone, managerAge);
    }
}