using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a pin(number between 4-8 digits long)");
            var pin = Console.ReadLine();
            var isNumeric = int.TryParse(pin, out _);
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
