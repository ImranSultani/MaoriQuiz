namespace MaoriQuizqqeqe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] easyquestions = { "1. What is the correct Māori word for \"water\"?\nA) Wai\nB) Kai\nC) Rā\nD) Ika", "2. If someone says \"Kia ora\", what is the best English translation?\nA) Good morning\nB) Hello / Cheers\nC) Goodbye\nD) Thank you", "3. What does the word \"Kai\" mean in Māori?\nA) To sleep\nB) To run\nC) Food\nD) Dog", "4. How do you say \"Goodbye\" to someone who is staying (when you are the one leaving)?\nA) Haere rā\nB) E noho rā\nC) Kia ora\nD) Mōrena", "5. Which of these numbers means \"Five\"?\nA) Tahi\nB) Waru\nC) Rima\nD) Tekau" };

            Console.WriteLine("################################\nWelcome To The Maori Quiz!\n");
            Console.WriteLine("################################\nWhat's your name?");
            string nameEntered = Console.ReadLine();

            Console.WriteLine("\n################################\nWhat difficulty do you want to select?\n Easy(e) - Medium(m) - Hard(h)");
            char diffucultySelector = Convert.ToChar(Console.ReadLine());
            switch
        }
    }
}
