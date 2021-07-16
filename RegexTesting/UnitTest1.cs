using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexDemoOperations;

namespace RegexTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodforArrayIndexOutofBoundException()
        {
            string expected = "Index was outside the bounds of the array.";
            string actual =  RegexDemo.CheckFirstName();
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethodforEmptyName()
        {
            try
            {
                RegexDemo.CheckLastName();
            }catch(RegexCustomException ex)
            {
                string expected = "Empty name";
                Assert.AreEqual(expected,ex.Message);
            }

        }
        [TestMethod]
        public void TestMethodforNullPhoneNumber()
        {
            try
            {
                RegexDemo.PhoneNumberValidation();
            }
            catch (RegexCustomException ex)
            {
                string expected = "Null";
                Assert.AreEqual(expected, ex.Message);
            }

        }
        [TestMethod]
        public void TestEmail()
        {
            try
            {
                RegexDemo.MailVerification();
            }catch(RegexCustomException ex)
            {
                string expected = "Emails are invalid";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        public void TestMethodPassword()
        {

            try
            {
                RegexDemo.Password();
            }
            catch (RegexCustomException ex)
            {
                string expected = "Invalid Password";
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}
