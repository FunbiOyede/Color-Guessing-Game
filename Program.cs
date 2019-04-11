using System;


namespace Color_Guessing_Game
{
    class Program 
    {
        static void Main(string[] args)
        {
            string AppName = "Color guessing game";
            string AppVersion = "1.0.0";
            Console.ForegroundColor = ConsoleColor.Green;

            //diplaying application version
            Console.WriteLine("{0} : version {1} ", AppName, AppVersion);
            Console.ResetColor();
            Console.WriteLine("Welcome to the game of guessing colors");

            //getting username
            AppLogic.ProcessUsername(ConsoleColor.DarkMagenta);

            //Displaying the colors 
            AppLogic.DisplayQuestion(ConsoleColor.Magenta);
        }

    }
}
