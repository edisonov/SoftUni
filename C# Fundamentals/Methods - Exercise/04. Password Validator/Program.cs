using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

           // bool isValidLenght = ValidateLenght(password);
           // bool isValidLeteersAndDigits = ValidateLeteersAndDigits(password);
           // bool isTwoDigits = PasswordTwoDigits(password);
           bool isTrue = ValidateLenght(password) && 
                         ValidateLeteersAndDigits(password) && 
                         PasswordTwoDigits(password);
            if (isTrue)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!ValidateLenght(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!ValidateLeteersAndDigits(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!PasswordTwoDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool PasswordTwoDigits(string password)
        {
            int count = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return true;
            }
            return false;
        }

        private static bool ValidateLeteersAndDigits(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;

        }

        private static bool ValidateLenght(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                bool isTrue = true;
                return isTrue;
                // return true;
            }
            return false;
        }
    }
}
