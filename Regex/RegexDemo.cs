using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemoOperations
{
    class RegexDemo
    {
        public static void CheckFirstName()
        {
            string[] firstName = { "Ram", "Afrath", "-Ram", "1Kumar", "R", "Mohamed","ashwik","A23rock","R  ","a{}2{D}","RA","Ar","RAM","Ramu"};
            Regex regex = new Regex(@"^[A-Z][a-z]{2,}$");
            for (int i = 0; i < firstName.Length; i++)
            {
                Match match = regex.Match(firstName[i]);
                if (match.Success)
                {
                    Console.WriteLine(firstName[i]+" ----->Valid");
                }
                else
                {
                    Console.WriteLine(firstName[i] + " ----->Invalid");
                }
            }
        }
        public static void CheckLastName()
        {
            string[] lastName = { "Ram", "Afrath", "-Ram", "1Kumar", "R", "Mohamed", "ashwik", "A23rock", "R  ", "a{}2{D}", "RA", "Ar", "RAM", "Ramu" };
            Regex regex = new Regex(@"^[A-Z][a-z]{2,}$");
            for (int i = 0; i < lastName.Length; i++)
            {
                Match match = regex.Match(lastName[i]);
                if (match.Success)
                {
                    Console.WriteLine(lastName[i] + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(lastName[i] + " ----->Invalid");
                }
            }
        }
        public static void MailVerification()
        {
            string[] email = { "abc@gmail.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc@.com.my", "abc123@.com", "abc123@.com.com", "abc()*@gmail.com", ".abc@abc.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            Regex regex = new Regex(@"(^[a-z]+)(([\. \+ \-]?[a-z A-Z 0-9])*)@(([0-9 a-z]+[\.]+[a-z]{3})+([\.]+[a-z]{2,3})?$)");
            for (int i = 0; i < email.Length; i++)
            {
                Match match = regex.Match(email[i]);
                if (match.Success)
                {
                    Console.WriteLine(email[i] + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(email[i] + " ----->Invalid");
                }
            }

        }
        public static void PhoneNumberValidation()
        {
            string[] number = { "91 9941478794", "91 7415289635", "91 7145484749", "918745123698", "91ABCD","91 87478578412" ,"91 98415223"};
            string pattern = @"^[91]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(pattern);
            for (int i = 0; i < number.Length; i++)
            {
                Match match = regex.Match(number[i]);
                if (match.Success)
                {
                    Console.WriteLine(number[i] + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(number[i] + " ----->Invalid");
                }
            }
        }



    }
}
