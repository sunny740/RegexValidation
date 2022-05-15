using System.Text.RegularExpressions;
namespace RegexValidation
{
    public class Validate
    {
        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]$";
        public static string MOBILENUMBER_REGEX = "^[6-9]{1}[0-9]{9}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public static string PASSWORD_REGEX = "^[a-zA-z0-9]{8,}";
        public const string PINCODE_REGEX = "^[0-9]{6}$";
        public static string PASSWORDUPPERCASE_REGEX = "^[A-Z]{1, }[a-z]{8, }$";
        public static string PASSWORD_NUMERICNUM = "^[A-Z]{1, }[a-z]{8, }[0-9]{1, }$";
        public static string PASSWORD_SPECIALCHARACTER = "^[A-Z]{1, }[a-z]{8, }[0-9]{1, }[@$#!*&^%]{1}$";
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
        public string Validate_EmailId(string EmailId)
        {
            if (Regex.IsMatch(EmailId, EMAIL_REGEX))
            {
                Console.WriteLine("Match Email");
            }
            else
            {
                Console.WriteLine("Doesn't Match Email");
            }
            return EmailId;
        }
        public string Validate_PassWord(string PASSWORD)
        {
            if (Regex.IsMatch(PASSWORD, PASSWORD_REGEX))
            {
                Console.WriteLine("Match PassWord");
            }
            else
            {
                Console.WriteLine("Doesn't Match PassWord");
            }
            return PASSWORD;
        }
        public string Validate_PinCode(string PinCode)
        {
            if (Regex.IsMatch(PinCode, PINCODE_REGEX))
            {
                Console.WriteLine("Match PinCOde");
            }
            else
            {
                Console.WriteLine("Doesn't Match PinCode");
            }
            return PinCode;
        }
        public string PassWord_Validate(string PassWord)
        {
            {
                if (Regex.IsMatch(PassWord, PASSWORDUPPERCASE_REGEX))
                {
                    Console.WriteLine("{0} is a Valid Password", PassWord);
                }
                return PassWord;
            }
        }
        public string Numeric_Validate(string Numeric)
        {
            {
                if (Regex.IsMatch(Numeric, PASSWORD_NUMERICNUM))
                {
                    Console.WriteLine("{0} is a Valid Password", Numeric);
                }
                return Numeric;
            }
        }
        public string Special_Character(string Character)
        {
            if (Regex.IsMatch(Character, PASSWORD_SPECIALCHARACTER))
            {
                Console.WriteLine("{0} is a valid password", Character);
            }
            return Character;
        }
    }
}