using System;

namespace NameParser.App
{
    class Program
    {
        static void Main(string[] args)
        {

            var menu = new [] {"First Option", "Second Option"};
            Console.WriteLine("Please enter your name!");

            var parser = new Parser();
            var name = Console.ReadLine();

            Console.WriteLine($"Hi, {name}!");
            
            var user = parser.ParseName(name);

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Your first name is {user.FirstName}! {Environment.NewLine}");            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Your last name is {user.LastName}!");


            Console.Beep();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

            foreach (var item in menu)
            {
                Console.WriteLine($"{Array.IndexOf(menu, item)+1}.) {item}");
            }
            var choice = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"You chose {menu [int.Parse(choice) - 1]}");
            Console.ResetColor();

        }
    }
}
