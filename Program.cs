using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace MaoriQuizqqeqe
{
    internal class Program
    {

        static void Main(string[] args)


        {


            Console.WriteLine("--------------------------------\nWelcome To The Maori Quiz!");
            Console.WriteLine("--------------------------------\nPlease enter your name:");
            Console.ResetColor();
            string nameEntered = Console.ReadLine();

            // The Welcome message and asking for the user's name, then clearing the input for the name

            do
            {
                if (string.IsNullOrWhiteSpace(nameEntered))
                {
                    Console.WriteLine("--------------------------------\nYour name cannot be empty! Please enter your name:");
                    nameEntered = Console.ReadLine();
                    // Checks if the name is empty or just spaces
                }
                if (!nameEntered.All(c => char.IsLetter(c) || c.Equals(' ')))
                {
                    Console.WriteLine("--------------------------------\nYour name has invalid characters! Please enter your name:");
                    nameEntered = Console.ReadLine();
                    // Checks if the name as only letters and spaces
                }
                else if (nameEntered.Length < 2 || nameEntered.Length > 30)
                {
                    Console.WriteLine("--------------------------------\nYour name has to be in the (2-30) character range! Please enter your name:");
                    nameEntered = Console.ReadLine();
                    // Checks if the character is over 1 letter long


                }
            } while ((string.IsNullOrWhiteSpace(nameEntered)) || !(nameEntered.All(c => char.IsLetter(c) || c.Equals(' '))) || nameEntered.Length < 2 || nameEntered.Length > 30);

            nameEntered = nameEntered.Substring(0, 1).ToUpper() + nameEntered.Substring(1).ToLower();
            if ((nameEntered.All(c => char.IsLetter(c) || c.Equals(' '))))
            {
                Console.WriteLine($"--------------------------------\nHello, {nameEntered}");
            }



            Console.WriteLine("--------------------------------\nPlease enter your age:");
            int ageEntered;
            string ageInput = Console.ReadLine();
            while (!int.TryParse(ageInput, out ageEntered) || ageEntered < 0 || ageEntered > 100)
            {
                if (!int.TryParse(ageInput, out ageEntered))
                {
                    Console.WriteLine("--------------------------------\nYour age has invalid characters! Please enter your age:");
                }
                else
                {
                    Console.WriteLine("--------------------------------\nYour age is not in the 0 - 100 range! Please enter your age:");
                }
                ageInput = Console.ReadLine();
            }

            if (ageEntered >= 10 && ageEntered <= 100)
            {
                Console.WriteLine("--------------------------------\nWelcome to the Māori Quiz!");
                // Checks if the user is old enough to play the quiz
            }
            else
            {
                Console.WriteLine("--------------------------------\nAre you sure that this is your correct age? Y / N");
                string ageConfirm = Console.ReadLine().Trim();

                while (string.IsNullOrWhiteSpace(ageConfirm) || (!ageConfirm.Equals("Y") && !ageConfirm.Equals("y") && !ageConfirm.Equals("N") && !ageConfirm.Equals("n")))
                {
                    if (string.IsNullOrWhiteSpace(ageConfirm))
                    {
                        Console.WriteLine("--------------------------------\nYour choice cannot be empty! Please enter Y or N.");
                    }
                    else
                    {
                        Console.WriteLine("--------------------------------\nInvalid input! Please enter Y or N.");
                    }
                    ageConfirm = Console.ReadLine().Trim();
                }
                if (ageConfirm.Equals("Y") || ageConfirm.Equals("y"))
                {
                    Console.WriteLine("--------------------------------\nYou must be at least 10 years old to participate in the Māori Quiz.");
                    return;
                }
                else if (ageConfirm.Equals("N") || ageConfirm.Equals("n"))
                {
                    Console.WriteLine("--------------------------------\nPlease enter your correct age: ");
                    while (!int.TryParse(Console.ReadLine(), out ageEntered) || ageEntered < 10 || ageEntered > 100)
                    {
                        Console.WriteLine("--------------------------------\nYou are too young to play this quiz.");
                        return;
                    }
                    if (ageEntered >= 10)
                    {
                        Console.WriteLine($"--------------------------------\nWelcome to the Māori Quiz, {nameEntered}!");
                    }
                    else
                    {imranimran
                        Console.WriteLine("--------------------------------\nYou must be at least 10 years old to participate in the Māori Quiz.");
                        return;
                    }
                }
            }

                string retryChoice = "";

            do
            {
                Console.WriteLine("--------------------------------\nWhat difficulty would you like? Easy(e), Medium(m), Hard(h)");
                string choiceForDifficulty = Console.ReadLine();
                choiceForDifficulty = choiceForDifficulty.Trim();


                if (choiceForDifficulty.Equals("e") || choiceForDifficulty.Equals("E"))
                {
                    easyQuiz();
                    // If the user chooses easy difficulty, it calls the easyQuiz method
                }
                else if (choiceForDifficulty.Equals("m") || choiceForDifficulty.Equals("M"))
                {
                    mediumQuiz();
                    // If the user chooses medium difficulty, it calls the mediumQuiz method
                }
                else if (choiceForDifficulty.Equals("h") || choiceForDifficulty.Equals("H"))
                {
                    hardQuiz();
                    // If the user chooses hard difficulty, it calls the hardQuiz method
                }
                else
                {
                    while (string.IsNullOrWhiteSpace(choiceForDifficulty) || (!choiceForDifficulty.Equals("e") && !choiceForDifficulty.Equals("E") && !choiceForDifficulty.Equals("m") && !choiceForDifficulty.Equals("M") && !choiceForDifficulty.Equals("h") && !choiceForDifficulty.Equals("H")))
                    {
                        Console.WriteLine("--------------------------------\nInvalid input. Please enter E, M, or H.");
                        choiceForDifficulty = Console.ReadLine();
                        choiceForDifficulty = choiceForDifficulty.Trim();
                    }
                    if (choiceForDifficulty .Equals("e") || choiceForDifficulty .Equals("E"))
                    {
                        easyQuiz();
                    }
                    else if (choiceForDifficulty .Equals("m") || choiceForDifficulty .Equals("M"))
                    {
                        mediumQuiz();
                    }
                    else if (choiceForDifficulty .Equals("h") || choiceForDifficulty .Equals("H"))
                    {
                        hardQuiz();
                    }
                }

                Console.WriteLine("Would you like to retry the quiz? YES / NO");
                retryChoice = Console.ReadLine().Trim().ToUpper();

                while (string.IsNullOrWhiteSpace(retryChoice) || (!retryChoice.Equals("YES") && !retryChoice.Equals("NO")))
                {
                    if (string.IsNullOrWhiteSpace(retryChoice))
                    {
                        Console.WriteLine("--------------------------------\nYour choice cannot be empty! Please enter YES or NO.");
                    }
                    else
                    {
                        Console.WriteLine("--------------------------------\nInvalid answer! Please enter YES or NO.");
                    }
                    retryChoice = Console.ReadLine().Trim().ToUpper();
                }

                if (retryChoice .Equals("YES"))
                {
                    Console.WriteLine("--------------------------------\nRestarting the quiz...");
                }
                else if (retryChoice .Equals("NO"))
                {
                    Console.WriteLine("--------------------------------\nThank you for playing the Māori Quiz! Goodbye!");
                }

            } while (retryChoice .Equals("YES"));





            static void easyQuiz()
                {
                    String[] easyQuestions = { "1. What is the correct Māori word for \"water\"?\nA) Wai\nB) Kai\nC) Rā\nD) Ika", "2. If someone says \"Kia ora\", what is the best English translation?\nA) Good morning\nB) Hello / Cheers\nC) Goodbye\nD) Thank you", "3. What does the word \"Kai\" mean in Māori?\nA) To sleep\nB) To run\nC) Food\nD) Dog", "4. How do you say \"Goodbye\" to someone who is staying (when you are the one leaving)?\nA) Haere rā\nB) E noho rā\nC) Kia ora\nD) Mōrena", "5. Which of these numbers means \"Five\"?\nA) Tahi\nB) Waru\nC) Rima\nD) Tekau" };
                    // All easy questions and their choices

                    int userPoints = 0;
                    char[] easyAnswers = { 'A', 'B', 'C', 'B', 'C' };

                    Console.WriteLine("--------------------------------\nYou have chosen Easy difficulty!");

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"--------------------------------\n{easyQuestions[i]}");
                        Console.WriteLine("--------------------------------\nWhat is your answer? A, B, C, or D?");
                        string userAnswer = Console.ReadLine().ToUpper();

                        if (!userAnswer.Equals("A") && !userAnswer.Equals("B") && !userAnswer.Equals("C") && !userAnswer.Equals("D"))
                        {
                            Console.WriteLine("--------------------------------\nInvalid input. Please enter A, B, C, or D.");
                            i--;
                            continue;
                            // If the user inputs an invalid answer, it shows an error message and repeats the question
                        }

                        if (userAnswer .Equals(easyAnswers[i].ToString()))
                        {

                            Console.WriteLine("--------------------------------\nCorrect!");
                            userPoints++;
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------\nIncorrect! The correct answer was " + easyAnswers[i]);
                        }
                    }
                    Console.WriteLine("--------------------------------\nYour final score is " + userPoints + "/5");

                }


                static void mediumQuiz()
                {
                    String[] mediumQuestions = { "1. What is the English translation for the Māori word \"tupuna\"?\nA) Child\nB) Ancestor\nC) Friend\nD) Teacher", "2. Complete the sentence with the correct possessive pronoun: \"Kei hea ___ pene?\" (Where is your pen?)\nA) tāu\nB) tō\nC) tū\nD) tā", "3. Which of the following kupu (words) represents the direction \"north\" in Māori?\nA) Tonga\nB) Rāwhiti\nC) Te Raki\nD) Ururangi", "4. If someone says, \"Kei te hiakai au,\" how are they feeling?\nA) Tired\nB) Thirsty\nC) Hungry\nD) Happy", "5. What is the correct translation for \"Thank you\" when speaking to one person?\nA) Kia ora\nB) Tēnā koe\nC) Haere rā\nD) Ngā mihi" };
                    // All medium questions and their choices

                    int userPoints = 0;
                    char[] mediumAnswers = { 'B', 'A', 'B', 'C', 'B' };

                    Console.WriteLine("--------------------------------\nYou have chosen Medium difficulty!");

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"--------------------------------\n{mediumQuestions[i]}");
                        Console.WriteLine("--------------------------------\nWhat is your answer? A, B, C, or D?");
                        string userAnswer = Console.ReadLine().ToUpper();

                        if (!userAnswer.Equals("A") && !userAnswer.Equals("B") && !userAnswer.Equals("C") && !userAnswer.Equals("D"))
                        {
                            Console.WriteLine("--------------------------------\nInvalid input. Please enter A, B, C, or D.");
                            i--;
                            continue;
                            // If the user inputs an invalid answer, it shows an error message and repeats the question
                        }

                        if (userAnswer .Equals(mediumAnswers[i].ToString()))
                        {
                            Console.WriteLine("--------------------------------\nCorrect!");
                            userPoints++;
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------\nIncorrect! The correct answer was " + mediumAnswers[i]);
                        }
                        Console.WriteLine("--------------------------------\nYour final score is " + userPoints + "/5");
                    }
                }

                static void hardQuiz()
                {
                    String[] hardQuestions = { "1. Which of the following correctly translates to \"I have two, maybe four pairs of socks\"?\nA) E rua pea ōku tōkena, e whā rānei.\nB) E rua, e whā pea ōku tōkena.\nC) E rua pea aku tōkena, e toru pea.\nD) E whā pea ōku tōkena, e waru pea.", "2. In Māori grammar, possession is strictly categorized. Which of the following items requires an (O)-category possessive marker (e.g., ōku instead of āku)?\nA) Your food and drink\nB) Your clothes and shoes\nC) Your younger brother or sister\nD) Your parents or grandparents", "3. Complete this well-known whakataukī (proverb): \"Ehara taku toa i te toa takitahi, engari he toa...\"\nA) ...he toa rawa atu.\nB) ...he toa ki te whenua.\nC) ...he toa takitini.\nD) ...he toa ki te tangata.", "4. What is the correct English translation for the kīwaha (idiom) \"Ka mau te wehi!\"?\nA) Be quiet!\nB) Sit down!\nC) That's fantastic! / Awesome!\nD) You are very brave.", "5. What is the correct English translation for the directional sentence \"I kake te tangata ki te tihi o te maunga\"?\nA) The man climbed to the peak of the mountain.\nB) The man walked around the base of the mountain.\nC) The man fell from the top of the mountain.\nD) The man was looking at the mountain." };
                    // All hard questions and their choices

                    int userPoints = 0;
                    char[] hardAnswers = { 'A', 'D', 'B', 'C', 'A' };

                    Console.WriteLine("--------------------------------\nYou have chosen Hard difficulty!");

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"--------------------------------\n{hardQuestions[i]}");
                        Console.WriteLine("--------------------------------\nWhat is your answer? A, B, C, or D?");
                        string userAnswer = Console.ReadLine().ToUpper();

                        if (!userAnswer.Equals("A") && !userAnswer.Equals("B") && !userAnswer.Equals("C") && !userAnswer.Equals("D"))
                        {
                            Console.WriteLine("--------------------------------\nInvalid input. Please enter A, B, C, or D.");
                            i--;
                            continue;
                            // If the user inputs an invalid answer, it shows an error message and repeats the question
                        }

                        if (userAnswer .Equals(hardAnswers[i].ToString()))
                        {
                            Console.WriteLine("--------------------------------\nCorrect!");
                            userPoints++;
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------\nIncorrect! The correct answer was " + hardAnswers[i]);
                        }
                    }
                    Console.WriteLine("--------------------------------\nYour final score is " + userPoints + "/5");
                }
            }
            }
    }





