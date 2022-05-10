using System.Text.RegularExpressions;
namespace RegexValidation
{
    public class Validate
    {
        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]$";
        public static string MOBILENUMBER_REGEX = "^[6-9]{1}[0-9]{9}$";
        public string Validate_FirstName(string firstname)
        {
            if (Regex.IsMatch(firstname, NAME_REGEX))
            {
                Console.WriteLine("Match First Name");
            }
            else
            {
                Console.WriteLine("Doesn't Match First Name");
            }
            return firstname;
        }
        public string Validate_LastName(string lastname)
        {
            if (Regex.IsMatch(lastname, NAME_REGEX))
            {
                Console.WriteLine("Match Last Name");
            }
            else
            {
                Console.WriteLine("Doesn't Match Last Name");
            }
            return lastname;
        }
        public string Validate_MobileNumber(string MobileNumber)
        {
            if (Regex.IsMatch(MobileNumber, MOBILENUMBER_REGEX))
            {
                Console.WriteLine("Match MobileNumber");
            }
            else
            {
                Console.WriteLine("Doesn't Match MobileNumber");
            }
            return MobileNumber;
        }
    }
}