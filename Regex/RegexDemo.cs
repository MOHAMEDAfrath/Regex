using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemoOperations
{
    public class RegexDemo
    {
        string message;
        //Default Constructor
        public RegexDemo()
        {

        }
        //Parameterized Constructor
        public RegexDemo(string message)
        {
            this.message = message;
        }
        //checks first name(Lambda expression is used for functions)
        public static Func<string, string> CheckFirstName = (firstName) =>
         {
             string result = "Valid";
             Regex regex = new Regex(@"^[A-Z][a-z]{2,}$");
             Match match = regex.Match(firstName);
             if (match.Success)
             {
                 Console.WriteLine(firstName + " ----->Valid");
             }
             else
             {
                 Console.WriteLine(firstName + " ----->Invalid");
                 result = "Invalid";

             }
             return result;

         };
        //checks last name (Lambda expression is used for functions)
        public static Func<string, string> CheckLastName = (lastName) =>
        {
            string result = "Valid";
            Regex regex = new Regex(@"^[A-Z][a-z]{2,}$");
            if (lastName != "")
            {
                Match match = regex.Match(lastName);
                if (match.Success)
                {
                    Console.WriteLine(lastName + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(lastName + " ----->Invalid");
                    result = "Invalid";
                }
                if (result == "Invalid")
                    throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_NAME, "Invalid name");
                else
                    return result;


            }
            else
            {
                throw new RegexCustomException(RegexCustomException.ExceptionType.EMPTY_MESSAGE, "Empty name");
            }

        };
        //checks for valid email(Lambda expression is used for functions)
        public static Func<string, string> MailVerification = (email) =>
        {
            string result = "Valid";
            Regex regex = new Regex(@"(^[a-z]+)(([\. \+ \-]?[a-z A-Z 0-9])*)@(([0-9 a-z]+[\.]+[a-z]{3})+([\.]+[a-z]{2,3})?$)");
            Match match = regex.Match(email);
            if (match.Success)
            {
                Console.WriteLine(email + " ----->Valid");
            }
            else
            {
                Console.WriteLine(email + " ----->Invalid");
                result = "Invalid";
            }

            if (result == "Invalid")
            {
                throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_EMAIL, "Email is invalid");
            }
            else
            {
                return result;
            }

        };
        //to check multiple mails(Lambda expression is used for functions)
        public static Func<string[], string> MultipleMailVerification = (email) =>
        {
            string result = "Valid";
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
                    result = "Invalid";
                }
            }

            if (result == "Invalid")
            {
                throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_EMAIL, "Emails in the array are invalid");
            }
            else
            {
                return result;
            }

        };

        //Checks for proper phonenumber(Lambda expression is used for functions)
        public static Func<string, string> PhoneNumberValidation = (number) =>
        {
            string result = "Valid";
            //string[] number = { "91 9941478794", "91 7415289635", "91 7145484749", "918745123698", "91ABCD","91 87478578412" ,"91-98415223",null};
            string pattern = @"^[91]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(pattern);

            if (number != null)
            {
                Match match = regex.Match(number);
                if (match.Success)
                {
                    Console.WriteLine(number + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(number + " ----->Invalid");
                    result = "Invalid";
                }
                if (result == "Invalid")
                    throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_PHONE, "Invalid PhoneNumber");
                else
                    return result;
            }
            else
            {
                throw new RegexCustomException(RegexCustomException.ExceptionType.NULL_MESSAGE, "Null");
            }
        };


        //Checks for proper Password(Lambda expression is used for functions)
        public static Func<string, string> Password = (password) =>
        {
            string passwordResult = "Valid";
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$";
            Regex regex = new Regex(pattern);

            Match match = regex.Match(password);
            if (match.Success)
            {
                Console.WriteLine(password + " ----->Valid");
            }
            else
            {
                Console.WriteLine(password + " ----->Invalid");
                passwordResult = "Invalid";
            }

            if (passwordResult == "Invalid")
                throw new RegexCustomException(RegexCustomException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            else
            {
                return passwordResult;
            }
        };



    }
}
