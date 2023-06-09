namespace RandomSentenceGenerator
{
    internal class Program
    {
        private static void Main(string[] args) //  [Who from where] [Action] [Detail] t
        {
            string[] names = { "Bobo", "Venci", "Niki", "Icsko", "Rado" };
            string[] places = { "Kirkovo", "Chekalo", "Zavoq", "Daskalo" };
            string[] verbs = { "eats", "cooks", "drinkins", "sleep" };
            string[] Nouns = { "doner", "cola", "vodka", "patatoes" };
            string[] Adverbs = { "slowly", "diligently", "warmly", "sadly", "fastly" };
            string[] Details = { "near the river", "at home", "in the park", "at popihouse", "bench" };
            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine("Welcome to your first ChatGpt sentence generator(Kurjaliiski metod)"); 
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                string randomName = RandomWords(names);
                string randomPlace = RandomWords(places);
                string randomVerb = RandomWords(verbs);
                string randomNoun = RandomWords(Nouns);
                string randomAdverb = RandomWords(Adverbs);
                string randomDetail = RandomWords(Details);
                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
                string sentance = $"{who} {action} {randomDetail}!";
                Console.WriteLine(sentance);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Press [Enter] to generate a new sentence!!");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                   
                }
            }
        }
        static string RandomWords(string[] words)
         {
             Random random = new Random();
             int randomIndex = random.Next(words.Length);
             string word = words[randomIndex];
             return word;
         }
    }
}