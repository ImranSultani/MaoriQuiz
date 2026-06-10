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

            // The Welcome message and asking for the user's name, then clearing the input for the name

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
                // Checks if the name as only letters and spaces
            }

            bool nameLengthIsOver1 = nameEntered.Length < 2;

            while (nameLengthIsOver1)
            {
                Console.WriteLine("--------------------------------\nYour name has to be over 1 character long!");
                Console.WriteLine("--------------------------------\nWhat's your name?");
                nameEntered = Console.ReadLine();
                // Checks if the character is over 1 letter long
            }

            bool nameLengthIsUnder30 = nameEntered.Length > 30;

            while (nameLengthIsUnder30)
            {
                Console.WriteLine("--------------------------------\nYour name has to be under 30 characters!");
                Console.WriteLine("--------------------------------\nWhat's your name?");
                nameEntered = Console.ReadLine();
                // Checks if the character is under 30 letters long
            }

            Console.WriteLine("--------------------------------\nWhat's your age?");
            int ageEntered;
            while (!int.TryParse(Console.ReadLine(), out ageEntered) || ageEntered < 0 || ageEntered > 100)
            {
                Console.WriteLine("--------------------------------\nPlease enter a valid age!");
                // Checks if the age is a valid number and between 0 and 100
            }

            if (ageEntered >= 10)
            {
                Console.WriteLine("--------------------------------\nWelcome to the Māori Quiz!");
                // Checks if the user is old enough to play the quiz
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
                    // Checks if the user confirms their age and if they are not old enough, it ends the program
                }
                else if (ageConfirmationChar == 'N' || ageConfirmationChar == 'n')
                {
                    Console.WriteLine("--------------------------------\nPlease enter your correct age: ");
                    while (!int.TryParse(Console.ReadLine(), out ageEntered) || ageEntered < 10 || ageEntered > 100)
                    {
                        Console.WriteLine("--------------------------------\nYou are too young to play this quiz.");
                        return;
                        Console.WriteLine("--------------------------------\nPlease enter a valid age: ");
                        // Checks if the new age input is valid and between 10 and 100
                    }
                    if (ageEntered >= 10)
                    {
                        Console.WriteLine($"--------------------------------\nWelcome to the Māori Quiz, {nameEntered}!");
                        // Checks if the new age input is old enough to play the quiz
                    }
                    else
                    {
                        Console.WriteLine("--------------------------------\nYou must be at least 13 years old to participate in the Māori Quiz.");
                        return;
                        // If the new age input is still not old enough, it ends the program
                    }
                }
            }



            Console.WriteLine("--------------------------------\nWhat difficulty would you like? (Easy(e), Medium(m), Hard(h))");
            string choiceForDifficulty = Console.ReadLine();
            choiceForDifficulty = choiceForDifficulty.Trim();


            if (choiceForDifficulty == "e" || choiceForDifficulty == "E")
            {
                Console.WriteLine("--------------------------------\nYou have chosen Easy difficulty!");
                easyQuiz();
                // If the user chooses easy difficulty, it calls the easyQuiz method
            }
            else if (choiceForDifficulty == "m" || choiceForDifficulty == "M")
            {
                Console.WriteLine("--------------------------------\nYou have chosen Medium difficulty!");
                mediumQuiz();
                // If the user chooses medium difficulty, it calls the mediumQuiz method
            }
            else if (choiceForDifficulty == "h" || choiceForDifficulty == "H")
            {
                Console.WriteLine("--------------------------------\nYou have chosen Hard difficulty!");
                hardQuiz();
                // If the user chooses hard difficulty, it calls the hardQuiz method
            }
            else
            {
                Console.WriteLine("--------------------------------\nInvalid input. Please enter E, M, or H.");
                // If the user inputs an invalid choice for difficulty, it shows an error message
            }
            while (choiceForDifficulty != "e" && choiceForDifficulty != "E" && choiceForDifficulty != "m" && choiceForDifficulty != "M" && choiceForDifficulty != "h" && choiceForDifficulty != "H") ;


            }
            static void easyQuiz()
            {
                String[] easyQuestions = { "1. What is the correct Māori word for \"water\"?\nA) Wai\nB) Kai\nC) Rā\nD) Ika", "2. If someone says \"Kia ora\", what is the best English translation?\nA) Good morning\nB) Hello / Cheers\nC) Goodbye\nD) Thank you", "3. What does the word \"Kai\" mean in Māori?\nA) To sleep\nB) To run\nC) Food\nD) Dog", "4. How do you say \"Goodbye\" to someone who is staying (when you are the one leaving)?\nA) Haere rā\nB) E noho rā\nC) Kia ora\nD) Mōrena", "5. Which of these numbers means \"Five\"?\nA) Tahi\nB) Waru\nC) Rima\nD) Tekau" };
                // All easy questions and their choices

                int userPoints = 0;
                char[] easyAnswers = { 'A', 'B', 'C', 'B', 'C' };

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"--------------------------------\n{easyQuestions[i]}");
                    Console.WriteLine("--------------------------------\nWhat is your answer? A, B, C, or D?");
                    string userAnswer = Console.ReadLine().ToUpper();
                    if (userAnswer == easyAnswers[i].ToString())
                    {
                        Console.WriteLine("--------------------------------\nCorrect!");
                        userPoints++;
                    }
                    else
                    {
                        Console.WriteLine("--------------------------------\nIncorrect! The correct answer was " + easyAnswers[i]);
                    }


                    // static void EasyQuiz() { String[] easyQuestions = { "1. What is the correct Māori word for \"water\"?\nA) Wai\nB) Kai\nC) Rā\nD) Ika", "2. If someone says \"Kia ora\", what is the best English translation?\nA) Good morning\nB) Hello / Cheers\nC) Goodbye\nD) Thank you", "3. What does the word \"Kai\" mean in Māori?\nA) To sleep\nB) To run\nC) Food\nD) Dog", "4. How do you say \"Goodbye\" to someone who is staying?\nA) Haere rā\nB) E noho rā\nC) Kia ora\nD) Mōrena", "5. Which of these numbers means \"Five\"?\nA) Tahi\nB) Waru\nC) Rima\nD) Tekau" }; String[] easyAnswers = { "A", "B", "C", "A", "C" }; int userscore = 0; for (int i = 0; i < 5; i++) {  Console.WriteLine(easyQuestions[i]);  Console.WriteLine("**********************************************");  Console.WriteLine("Enter your answer (A, B, C, or D): "); string useranswer = Console.ReadLine().ToUpper(); if (useranswer == easyAnswers[i]) {  Console.WriteLine("Correct!\n");  userscore++; } else {  Console.WriteLine("Incorrect! The answer was " + easyAnswers[i] + "\n"); } }  Console.WriteLine("Your final score is " + userscore + "/5"); }
                }
            }

            static void mediumQuiz()
            {
                String[] mediumQuestions = { "1. What is the English translation for the Māori word \"tupuna\"?\nA) Child\nB) Ancestor\nC) Friend\nD) Teacher", "2. Complete the sentence with the correct possessive pronoun: \"Kei hea ___ pene?\" (Where is your pen?)\nA) tāu\nB) tō\nC) tū\nD) tā", "3. Which of the following kupu (words) represents the direction \"north\" in Māori?\nA) Tonga\nB) Rāwhiti\nC) Te Raki\nD) Ururangi", "4. If someone says, \"Kei te hiakai au,\" how are they feeling?\nA) Tired\nB) Thirsty\nC) Hungry\nD) Happy", "5. What is the correct translation for \"Thank you\" when speaking to one person?\nA) Kia ora\nB) Tēnā koe\nC) Haere rā\nD) Ngā mihi" };
            // All medium questions and their choices

            int userPoints = 0;
            char[] mediumAnswers = { 'B', 'A', 'B', 'C', 'B' };

            for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(mediumQuestions[i]);
                Console.WriteLine("What is your answer? A, B, C, or D?");
                string userAnswer = Console.ReadLine().ToUpper();
                if (userAnswer == mediumAnswers[i].ToString())
                {
                    Console.WriteLine("Correct!");
                    userPoints++;
                }
                else
                {
                    Console.WriteLine("Incorrect! The correct answer was " + mediumAnswers[i]);
                }
            }
            }

            static void hardQuiz()
            {
                String[] hardQuestions = { "1. Which of the following correctly translates to \"I have two, maybe four pairs of socks\"?\nA) E rua pea ōku tōkena, e whā rānei.\nB) E rua, e whā pea ōku tōkena.\nC) E rua pea aku tōkena, e toru pea.\nD) E whā pea ōku tōkena, e waru pea.", "2. In Māori grammar, possession is strictly categorized. Which of the following items requires an (O)-category possessive marker (e.g., ōku instead of āku)?\nA) Your food and drink\nB) Your clothes and shoes\nC) Your younger brother or sister\nD) Your parents or grandparents", "3. Complete this well-known whakataukī (proverb): \"Ehara taku toa i te toa takitahi, engari he toa...\"\nA) ...he toa rawa atu.\nB) ...he toa ki te whenua.\nC) ...he toa takitini.\nD) ...he toa ki te tangata.", "4. What is the correct English translation for the kīwaha (idiom) \"Ka mau te wehi!\"?\nA) Be quiet!\nB) Sit down!\nC) That's fantastic! / Awesome!\nD) You are very brave.", "5. What is the correct English translation for the directional sentence \"I kake te tangata ki te tihi o te maunga\"?\nA) The man climbed to the peak of the mountain.\nB) The man walked around the base of the mountain.\nC) The man fell from the top of the mountain.\nD) The man was looking at the mountain." };
                // All hard questions and their choices

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(hardQuestions[i]);
                }
            }

        }
    }

