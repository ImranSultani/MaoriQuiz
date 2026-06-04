using System.Numerics;

namespace MaoriQuizqqeqe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("--------------------------------\nWelcome To The Maori Quiz!");
            Console.ResetColor();
            Console.WriteLine("--------------------------------\nWhat's your name?");
            int leftPos = Console.CursorLeft;
            int topPos = Console.CursorTop;
            string nameEntered = Console.ReadLine();
            Console.SetCursorPosition(leftPos, topPos);
            Console.Write(new string(' ', nameEntered.Length));
            Console.SetCursorPosition(leftPos, topPos);

            

            bool isValid = nameEntered.All(c => char.IsLetter(c) || c == ' ');

            if (isValid)
            {
                Console.WriteLine($"--------------------------------\nHello, {nameEntered}");
            }
            else
            {
                Console.WriteLine("--------------------------------\nYour name has invalid characters!");
                Console.WriteLine("--------------------------------\nWhat's your name?");
                nameEntered = Console.ReadLine();
            }

            bool nameLengthIsOver1 = nameEntered.Length < 2;

            while (nameLengthIsOver1)
            {
                Console.WriteLine("--------------------------------\nYour name has to be over 1 character long!");
                Console.WriteLine("--------------------------------\nWhat's your name?");
                nameEntered = Console.ReadLine();
            }

            bool nameLengthIsUnder30 = nameEntered.Length > 30;

            while (nameLengthIsUnder30)
            {
                Console.WriteLine("--------------------------------\nYour name has to be under 30 characters!");
                Console.WriteLine("--------------------------------\nWhat's your name?");
                nameEntered = Console.ReadLine();
            }

            Console.WriteLine("--------------------------------\nWhat's your age?");
            int ageEntered;
            while (!int.TryParse(Console.ReadLine(), out ageEntered) || ageEntered < 0 || ageEntered > 100)
            {
                Console.WriteLine("--------------------------------\nPlease enter a valid age!");
            }

            if (ageEntered >= 10)
            {
                Console.WriteLine("--------------------------------\nWelcome to the Māori Quiz!");
            }
            else
            {
                Console.WriteLine("--------------------------------\nAre you sure that this is your correct age? Y / N");
                string ageConfirmation = Console.ReadLine();
                char ageConfirmationChar = Convert.ToChar(ageConfirmation);
                ageConfirmationChar = ageConfirmation.Trim()[0];
                if (ageConfirmationChar == 'Y' || ageConfirmationChar == 'y')
                {
                    Console.WriteLine("--------------------------------\nYou must be at least 13 years old to participate in the Māori Quiz.");
                    return;
                }
                else if (ageConfirmationChar == 'N' || ageConfirmationChar == 'n')
                {
                    Console.WriteLine("--------------------------------\nPlease enter your correct age: ");
                    while (!int.TryParse(Console.ReadLine(), out ageEntered) || ageEntered < 10 || ageEntered > 100)
                    {
                        Console.WriteLine("--------------------------------\nYour input for your age is invalid.");
                        Console.WriteLine("--------------------------------\nPlease enter a valid age: ");
                    }
                    if (ageEntered >= 10)
                    {
                        Console.WriteLine("--------------------------------\nWelcome to the Māori Quiz, {nameEntered}!");
                    }
                    else
                    {
                        Console.WriteLine("--------------------------------\nYou must be at least 13 years old to participate in the Māori Quiz.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("--------------------------------\nInvalid input. Please enter Y or N.");
                }

            }
        }
    }
}