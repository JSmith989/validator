using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            //phone
            Console.WriteLine("Enter a valid phone number");
            var phoneNumber = Console.ReadLine();
           



            //pin
            Console.WriteLine("Enter a pin(number between 4-8 digits long)");
            var pin = Console.ReadLine();
            if (!int.TryParse(pin, out _))
            {
                Console.WriteLine("Only Numbers");

            }
            else if (pin.Length >= 4 && pin.Length <= 8)
            {
                Console.WriteLine("Pin Valid");
            };

            

        }
    }
}
