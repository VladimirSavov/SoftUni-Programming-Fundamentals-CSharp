using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isPasswordLengthValid = ValidatePasswordLength(password);
            bool isPasswordContainsValidSymbols = ValidatePasswordText(password);
            bool isDigitInContainPasswordAtLeastTwo = ValidatePasswordDigit(password);

            if (!isPasswordLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswordContainsValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isDigitInContainPasswordAtLeastTwo)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if(isPasswordLengthValid && isPasswordContainsValidSymbols && isDigitInContainPasswordAtLeastTwo)
            {
                Console.WriteLine("Password is valid");
            }
        }  
        
        static bool ValidatePasswordLength(string text)
        {
            return text.Length >= 6 && text.Length <= 10;
        }
        static bool ValidatePasswordText(string text)
        {
            foreach (char character in text)
            { 
                if (!char.IsLetterOrDigit(character))
                {
                    return false;
                }
            }

            return true;
        }
        static bool ValidatePasswordDigit(string text)
        {
            int count = 0;
            foreach  ( char character in text)
            {
                if (char.IsDigit(character))
                {
                    count++;
                }
            }
            return count >= 2 ? true : false;
        }
    }
}
