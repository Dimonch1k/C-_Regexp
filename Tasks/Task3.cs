using System;
using System.Text.RegularExpressions;

namespace Tasks
{
    public class Task3
    {
        public void PasswordComplexityValidation()
        {
            string[] passwords = {
                "Abcdef1!",
                "password123",
                "AbcdEfgh",
                "Abcde@1",
                "Abcde@12"
            };

            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*()_+])[A-Za-z\d!@#$%^&*()_+]{8,}$";
            Regex regex = new Regex(pattern);

            foreach (var password in passwords)
            {
                if (regex.IsMatch(password))
                {
                    Console.WriteLine($"{password} - valid password");
                }
                else
                {
                    Console.WriteLine($"{password} - invalid password");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
