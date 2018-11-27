//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string cmpName = Console.ReadLine();

        Console.Write("Enter company address: ");
        string cmpAddress = Console.ReadLine();

        Console.Write("Enter phone: ");
        int cmpPhone = int.Parse(Console.ReadLine());

        Console.Write("Enter fax: ");
        int cmpFax = int.Parse(Console.ReadLine());

        Console.Write("Enter web site: ");
        string cmpWebSite = Console.ReadLine();

        Console.Write("Enter manager first name: ");
        string mgrFirstName = Console.ReadLine();

        Console.Write("Enter manager last name: ");
        string mgrLastName = Console.ReadLine();

        Console.Write("Enter manager phone number: ");
        int mgrPhone = int.Parse(Console.ReadLine());

        Console.Write("Enter manager age: ");
        byte mgrAge = byte.Parse(Console.ReadLine());


        Console.WriteLine("Company Name: {0}", cmpName);
        Console.WriteLine("Address: {0}", cmpAddress);
        Console.WriteLine("Phone: {0}",cmpPhone);
        Console.WriteLine("Fax: {0}", cmpFax);
        Console.WriteLine("Web site: {0} \r\n", cmpWebSite);
        Console.WriteLine("Manager: {0} {1}", mgrFirstName, mgrLastName);
        Console.WriteLine("Age: {0}, Number: {1}", mgrAge, mgrPhone);
    }
}
