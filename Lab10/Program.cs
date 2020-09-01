using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, would you like to use our Circle Tester application? Y/N?");
            var userResponse = Console.ReadLine();
            if (userResponse == "y" || userResponse == "Y")
            {
                Console.WriteLine("Please enter the radius of your cirle. (Must be number)");
                var radius = double.Parse(Console.ReadLine());


                Console.WriteLine("Would you like to continue? Y/N");
                userResponse = Console.ReadLine();
                var timesDone = 
            }
            Console.WriteLine($"Goodbye. You created {timesDone} ircle objects");
            var duh = new Circle();
        }
    }
}
