using NUnit.Framework;
using RegexValidation;
namespace TestValidation
{
    public class Tests
    {
        [Test]
        public void InputInString_Test_FirstNameOfUser()
        {
            Validate input = new Validate();
            string actual = input.Validate_FirstName("Sunny");
            Assert.AreEqual(actual, "Sunny");
        }
        [Test]
        public void InputInString_Test_LastNameOfUser()
        {
            Validate input = new Validate();
            string actual = input.Validate_LastName("Sejwar");
            Assert.AreEqual(actual, "Sejwar");
        }
        [Test]
        public void InputInString_Test_MobileNumberOfUser()
        {
            Validate input = new Validate();
            string actual = input.Validate_MobileNumber("9862318205");
            Assert.AreEqual(actual, "9862318205");
        }
        [Test]
        public void InputInString_Test_Email()
        {
            Validate input = new Validate();
            string actual = input.Validate_EmailId("sunnyrgpv123@gmil.com");
            Assert.AreEqual(actual, "sunnyrgpv123@gmil.com");
        }
        [Test]
        public void InputInString_Test_PassWord()
        {
            Validate input = new Validate();
            string actual = input.Validate_PassWord("Sejji@123");
            Assert.AreEqual(actual, "Sejji@123");
        }
        [Test]
        public void InputInString_Test_PinCode()
        {
            Validate input = new Validate();
            string actual = input.Validate_PinCode("458010");
            Assert.AreEqual(actual, "458010");
        }
        [Test]
        public void InputIsString_WhenTestPassword_ShouldReturnCapitalLatters()
        {
            Validate validation = new Validate();
            string actual = validation.PassWord_Validate("Sunnythepow");
            Assert.AreEqual(actual, "Sunnythepow");
        }
    }
}