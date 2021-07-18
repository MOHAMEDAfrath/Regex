using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexDemoOperations;

namespace RegexTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodforValidFirstName()
        {
            string expected = "Valid";
            string actual =  RegexDemo.CheckFirstName("Ram");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethodforInValidFirstName()
        {
            string expected = "Invalid";
            string actual = RegexDemo.CheckFirstName("Ra");
            Assert.AreEqual(expected, actual);

        }
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
        [TestMethod]
        public void TestMethodforValidPhoneNumber()
        {
             string actual = RegexDemo.PhoneNumberValidation("91 9941478794");
            string expected = "Valid";
            Assert.AreEqual(actual, expected); 

        }
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
        [TestMethod]
        public void TestEmail()
        {
            string actual = RegexDemo.MailVerification("abc@gmail.com");
            string expected = "Valid";
            Assert.AreEqual(actual, expected);

        }
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
        [TestMethod]
        public void TestCreateObjectWithReflections()
        {
            object expected = new RegexDemo();
            object actual = ReflectionFactory.CreateObjectForMoodAnalyse("RegexDemoOperations.RegexDemo", "RegexDemo");
            expected.Equals(actual);

        }
        [TestMethod]
        public void TestParameterConstructor()
        {
            object expected = new RegexDemo("Regex");
            object actual = ReflectionFactory.CreateParameterizedConstructor("RegexDemoOperations.RegexDemo", "RegexDemo", "Regex");
            actual.Equals(expected);
        }
        
    }
}
