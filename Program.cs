namespace MaoriQuizqqeqe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] easyQuestions = { "1. What is the correct Māori word for \"water\"?\nA) Wai\nB) Kai\nC) Rā\nD) Ika", "2. If someone says \"Kia ora\", what is the best English translation?\nA) Good morning\nB) Hello / Cheers\nC) Goodbye\nD) Thank you", "3. What does the word \"Kai\" mean in Māori?\nA) To sleep\nB) To run\nC) Food\nD) Dog", "4. How do you say \"Goodbye\" to someone who is staying (when you are the one leaving)?\nA) Haere rā\nB) E noho rā\nC) Kia ora\nD) Mōrena", "5. Which of these numbers means \"Five\"?\nA) Tahi\nB) Waru\nC) Rima\nD) Tekau" };

            String[] mediumQuestions = { "1. What is the English translation for the Māori word \"tupuna\"?\nA) Child\nB) Ancestor\nC) Friend\nD) Teacher", "2. Complete the sentence with the correct possessive pronoun: \"Kei hea ___ pene?\" (Where is your pen?)\nA) tāu\nB) tō\nC) tū\nD) tā", "3. Which of the following kupu (words) represents the direction \"north\" in Māori?\nA) Tonga\nB) Rāwhiti\nC) Te Raki\nD) Ururangi", "4. If someone says, \"Kei te hiakai au,\" how are they feeling?\nA) Tired\nB) Thirsty\nC) Hungry\nD) Happy", "5. What is the correct translation for \"Thank you\" when speaking to one person?\nA) Kia ora\nB) Tēnā koe\nC) Haere rā\nD) Ngā mihi" };

            String[] hardQuestions = { "1. Which of the following correctly translates to \"I have two, maybe four pairs of socks\"?\nA) E rua pea ōku tōkena, e whā rānei.\nB) E rua, e whā pea ōku tōkena.\nC) E rua pea aku tōkena, e toru pea.\nD) E whā pea ōku tōkena, e waru pea.", "2. In Māori grammar, possession is strictly categorized. Which of the following items requires an (O)-category possessive marker (e.g., ōku instead of āku)?\nA) Your food and drink\nB) Your clothes and shoes\nC) Your younger brother or sister\nD) Your parents or grandparents", "3. Complete this well-known whakataukī (proverb): \"Ehara taku toa i te toa takitahi, engari he toa...\"\nA) ...he toa rawa atu.\nB) ...he toa ki te whenua.\nC) ...he toa takitini.\nD) ...he toa ki te tangata.", "4. What is the correct English translation for the kīwaha (idiom) \"Ka mau te wehi!\"?\nA) Be quiet!\nB) Sit down!\nC) That's fantastic! / Awesome!\nD) You are very brave.", "5. What is the correct English translation for the directional sentence \"I kake te tangata ki te tihi o te maunga\"?\nA) The man climbed to the peak of the mountain.\nB) The man walked around the base of the mountain.\nC) The man fell from the top of the mountain.\nD) The man was looking at the mountain." };

            Console.WriteLine("################################\nWelcome To The Maori Quiz!\n");
            Console.WriteLine("################################\nWhat's your name?");
            string nameEntered = Console.ReadLine();

            bool isValid = nameEntered.All(c => char.IsLetter(c) || c == ' ');

            if (isValid)
            {
                Console.WriteLine($"Hello, {nameEntered}");
            }
            else
            {
                Console.WriteLine("Your name has invalid characters!");
                return;
            }

            bool nameLengthIsOver1 = nameEntered.Length < 2;

            if (nameLengthIsOver1)
            {
                Console.WriteLine("Your name has to be over 1 character long!");
                return;
            }

            bool nameLengthIsUnder30 = nameEntered.Length > 30;

            if (nameLengthIsUnder30)
            {
                Console.WriteLine("Your name has to be under 30 characters!");
                return;
            }

            Console.WriteLine("\n################################\nWhat difficulty do you want to select?\n Easy(e) - Medium(m) - Hard(h)");
            char diffucultySelector = Convert.ToChar(Console.ReadLine());
        }
        }
    }
