using System;

namespace Color_Guessing_Game
{
    class AppLogic
    {

        public static void ProcessUsername(ConsoleColor color)
        {
            string username;

            Console.ForegroundColor = color;

            Console.WriteLine("Please enter your name ?");

            username = Console.ReadLine().ToUpper();
            Console.ResetColor();

            Console.WriteLine("Player:  {0}", username.ToUpper());
       
        }

        public static void DisplayQuestion(ConsoleColor color)
        {
            Console.WriteLine("This is how the game would work, I would display a list of colors and i would choose one color from the list, your job is to guess the color i choose.");
          
                string[] colors = { "Red", "Yellow", "Blue", "Purple", "Orange", "Black" };

                NEWGAME:
                Console.WriteLine("These are the colors");

                //Display List of color int tje colors array
                for (int i = 0; i < colors.Length; i++)
                {
                    Console.WriteLine(colors[i]);
                }


                Random random = new Random();

                int colorIndex = random.Next(colors.Length);

                string chosenColor = colors[colorIndex];

                Console.ForegroundColor = color;

                Console.WriteLine("  Guess The color i choose ?");

                GuessAgain:
                string answer = Console.ReadLine();
                if (answer != chosenColor)
                {
                    PrintWrongMessage(ConsoleColor.Red, "Wrong guess , Guess again");
                    goto GuessAgain;

                }
                else if (answer == chosenColor)
                {
                    PrintSuccessMessage(ConsoleColor.Green, "Correct");
                }


                Console.ResetColor();

                Console.WriteLine("Play Again ? [Y or N]");
                string PlayAgain = Console.ReadLine().ToUpper();
                if (PlayAgain == "Y")
                {
                    goto NEWGAME;
                }
                else if (PlayAgain == "N")
                {
                    return;
                }
            
  
        }

           
       public static void PrintWrongMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

  
        public static void PrintSuccessMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
