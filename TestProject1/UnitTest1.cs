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
    }
}