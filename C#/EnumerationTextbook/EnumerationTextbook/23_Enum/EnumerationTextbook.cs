using System;

namespace EnumerationTextbook._23_Enum
{

    class EnumerationTextbook
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("red");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($" {nameof(ConsoleColor.Yellow)} & {nameof(ConsoleColor.Green)}");
            Console.ResetColor();


        }
    }
}