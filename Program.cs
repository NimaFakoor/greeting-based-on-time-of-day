using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n time-based-greeting-message \n\n");

            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("Good Morning");
                Console.WriteLine(Convert.ToString(DateTime.Now));
            }
            else if (DateTime.Now.Hour < 17)
            {
                Console.WriteLine("Good Afternoon");
                Console.WriteLine(Convert.ToString(DateTime.Now));
            }
            else
            {
                Console.WriteLine("Good Evening");
                Console.WriteLine(Convert.ToString(DateTime.Now));
            }
        }
    }
}