using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexDemoOperations;

namespace RegexTesting
{
    [TestClass]
    public class UnitTest1
    {
        //Test for valid first name
        [TestMethod]
        public void TestMethodforValidFirstName()
        {
            string expected = "Valid";
            string actual =  RegexDemo.CheckFirstName("Ram");
            Assert.AreEqual(expected, actual);

        }
        // Test for invalid first name
        [TestMethod]
        public void TestMethodforInValidFirstName()
        {
            string expected = "Invalid";
            string actual = RegexDemo.CheckFirstName("Ra");
            Assert.AreEqual(expected, actual);

        }
        //Test for last name
        [TestMethod]
        public void TestMethodforLastName()
        {
            try
            {
                RegexDemo.CheckLastName("Kumar");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Valid";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //test for invalid last name
        [TestMethod]
        public void TestMethodforInvalidLastName()
        {
            try
            {
                RegexDemo.CheckLastName("A");
            }
            catch(RegexCustomException ex)
            {
                string expected = "Invalid name";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //Test for empty name
        [TestMethod]
        public void TestMethodforEmptyName()
        {
            try
            {
                RegexDemo.CheckLastName("");
            }catch(RegexCustomException ex)
            {
                string expected = "Empty name";
                Assert.AreEqual(expected,ex.Message);
            }

        }

        //Test for Valid Phonenumber
        [TestMethod]
        public void TestMethodforValidPhoneNumber()
        {
             string actual = RegexDemo.PhoneNumberValidation("91 9941478794");
            string expected = "Valid";
            Assert.AreEqual(actual, expected); 

        }
        //Test for invalid phone number
        [TestMethod]
        public void TestMethodforInvalidPhoneNumber()
        {
            try
            {
                RegexDemo.PhoneNumberValidation("91 9941478");
            }
            catch (RegexCustomException ex)
            {
             
                Assert.AreEqual("Invalid PhoneNumber", ex.Message);

            }
            

        }
        //test for null phone number
        [TestMethod]
        public void TestMethodforNullPhoneNumber()
        {
            try
            {
                RegexDemo.PhoneNumberValidation(null);
            }
            catch (RegexCustomException ex)
            {
                string expected = "Null";
                Assert.AreEqual(expected, ex.Message);
            }

        }
        //test for invalid email
        [TestMethod]
        public void TestInvalidEmail()
        {
            try
            {
                RegexDemo.MailVerification("abc.@gmail.com");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Email is invalid";
                Assert.AreEqual(expected, ex.Message);
            }

        }
        //Test for valid email
        [TestMethod]
        public void TestEmail()
        {
            string actual = RegexDemo.MailVerification("abc@gmail.com");
            string expected = "Valid";
            Assert.AreEqual(actual, expected);

        }
        //tests for multiple valid emails
        [TestMethod]
        public void TestMultipleEmail()
        {
            string[] input = { "abc@gmail.com", "abc.afr@gmail.com", "abc@gmail.com.in" };
            string actual = RegexDemo.MailVerification(input);
            string expected = "Valid";
            Assert.AreEqual(actual, expected);

        }
        //test for multiple invalid emails
        [TestMethod]
        public void NegativeTestMultipleEmail()
        {
            string[] input = { "abc.@gmail.com", "abc.afrgmail.com", "abc@gmail.com.in.in" };
            try
            {
                 RegexDemo.MailVerification(input);
            }catch(RegexCustomException ex)
            {

                string expected = "Emails in the array are invalid";

                Assert.AreEqual(expected, ex.Message);

            }
            
        }

            //Test for valid password
            [TestMethod]
        public void TestMethodPassword()
        {
            try
            {
                RegexDemo.Password("afrath-A1");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Valid";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //Test for invalid password
        [TestMethod]
        public void TestMethodInvalidPassword()
        {
            try
            {
                RegexDemo.Password("(afrath-A1");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Invalid Password";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //test for object creation for RegexDemo class
        [TestMethod]
        public void TestCreateObjectWithReflections()
        {
            object expected = new RegexDemo();
            object actual = ReflectionFactory.CreateObjectForMoodAnalyse("RegexDemoOperations.RegexDemo", "RegexDemo");
            expected.Equals(actual);

        }
        //Test for parameterconstructor invoked using object created
        [TestMethod]
        public void TestParameterConstructor()
        {
            object expected = new RegexDemo("Regex");
            object actual = ReflectionFactory.CreateParameterizedConstructor("RegexDemoOperations.RegexDemo", "RegexDemo", "Regex");
            actual.Equals(expected);
        }
        
    }
}
