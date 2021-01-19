using System;
using System.Text.RegularExpressions;

namespace Validator
{
   public static class Program
    {
        public static void Main(string[] args)
        {
            //phone
            Console.WriteLine("Enter a valid phone number");
            var phoneNumber = Console.ReadLine();
            Console.WriteLine("{0}valid phone number", IsValidPhoneNumber(phoneNumber) ? "" : "in");

            //email
            Console.WriteLine("Enter a valid email");
            var emailInput = Console.ReadLine();
            Console.WriteLine("{0}valid email", IsValidEmail(emailInput) ? "" : "in");


            //pin
            Console.WriteLine("Enter a pin(number between 4-8 digits long)");
            var pin = Console.ReadLine();
            if (!int.TryParse(pin, out _))
            {
                Console.WriteLine("Only Numbers Please");

            }
            else if (pin.Length >= 4 && pin.Length <= 8)
            {
                Console.WriteLine("Valid Pin");
            }
            else if (pin.Length < 4 || pin.Length > 8)
            {
                Console.WriteLine("Invalid Pin");
            };
        }
        public static bool IsValidPhoneNumber(string number)
        {
            return Regex.Match(number, @"^[0-9]{10}$|^[1-9]\d{2}-\d{3}-\d{4}|^\(\d{3}\)\d{3}-\d{4}|^[1-9]\d{2}\s\d{3}\s\d{4}").Success;
        }

        
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
