using System;

namespace RegexDemoOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to regex");
            Console.WriteLine("****First Name Validation****");
            RegexDemo.CheckFirstName();
            Console.WriteLine(" ");
            Console.WriteLine("****Last Name Validation****");
            RegexDemo.CheckLastName();
            Console.WriteLine(" ");
            Console.WriteLine("****Email Verification****");
            RegexDemo.MailVerification();
            Console.WriteLine(" ");
            Console.WriteLine("****Phone number Verification****");
            RegexDemo.PhoneNumberValidation();
            Console.WriteLine(" ");
            
        }
    }
}
