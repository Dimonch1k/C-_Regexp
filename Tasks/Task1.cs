using System;
using System.Text.RegularExpressions;

namespace Tasks
{
    public class Task1
    {
        public void EmailValidation()
        {

            string[] emails = {
                "thug@itstep.ua",
                "johndoe@gmail.com",
                "alice@itstep.ua",
                "bob@itstep.org",
                "info@itstep.ua"
            };

            string pattern = @"^[a-zA-Z0-9._%+-]+@itstep\.ua$";
            Regex regex = new Regex(pattern);

            foreach (var email in emails)
            {
                if (regex.IsMatch(email))
                {
                    Console.WriteLine($"{email} - valid email with domain itstep.ua");
                }
                else
                {
                    Console.WriteLine($"{email} - invalid email with domain itstep.ua");
                }
            }
        }
    }

}
