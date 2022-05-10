using System.Text.RegularExpressions;
namespace RegexValidation
{
    public class Validate
    {
        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]$";

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
    }
}