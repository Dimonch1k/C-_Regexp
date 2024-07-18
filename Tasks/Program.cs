using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ================================
            //Task1 task1 = new Task1();
            //task1.EmailValidation();

            // ================================
            //Task2 task2 = new Task2();
            //task2.PhoneNumberValidation();

            // ================================
            Task3 task3 = new Task3();
            task3.PasswordComplexityValidation();



            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
