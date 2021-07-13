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
    }
}
