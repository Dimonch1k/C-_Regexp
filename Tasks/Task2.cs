using System;
using System.Text.RegularExpressions;

namespace Tasks
{
    public class Task2
    {
        public void PhoneNumberValidation()
        {
            string[] phoneNumbers = {
                "+380501234567",
                "380501234567",
                "+38 (050) 123-45-67",
                "380 (50) 123 45 67",
                "+38-050-123-45-67",
                "+38 050 123 45 67",
                "+38050123-45-67",
                "+38050123 45 67",
                "0501234567",
                "050 123 45 67",
                "050-123-45-67"
            };

            string pattern = @"^(?:\+?38)?(?:\(\d{2,3}\)|\d{2,3})[\s-]?\d{3}[\s-]?\d{2}[\s-]?\d{2}$";
            Regex regex = new Regex(pattern);

            foreach (var phoneNumber in phoneNumbers)
            {
                if (regex.IsMatch(phoneNumber))
                {
                    Console.WriteLine($"{phoneNumber} - valid Ukrainian phone number");
                }
                else
                {
                    Console.WriteLine($"{phoneNumber} - invalid Ukrainian phone number");
                }
            }
        }
    }
}
