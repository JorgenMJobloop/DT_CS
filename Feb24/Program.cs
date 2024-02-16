namespace ConsoleApp_Feb24
{

    public class MyMethods
    {

        public string SplitStrings(string inputString)
        {
            // i subStrings lager vi et array av strengen vi holder i myString
            // og vi bryter den opp i flere substrings som tilhører et array
            string[] outputString = inputString.Split(" ");
            foreach (string outputs in outputString)
            {
                Console.WriteLine(outputs);
            }
            return outputString.ToString();
        }

    }

    public class Player
    {
        public string? Name { get; set; }
        public int? Life { get; set; }

        public int? Damage { get; set; }


        public void UserInput()
        {
            Console.WriteLine("Hello, what do I call you? ");
            Name = Console.ReadLine();
            Console.WriteLine($"Hello {Name}");
        }

        public void TakeDamage()
        {
            Life = 100;
            if (Life == 100)
            {
                Console.WriteLine($"{Name} took {Life - Damage} damage and has {Life} lives remaining!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // vi assigner en string til myString!
            string myString = "Hello from a string!";
            var myMethods = new MyMethods();
            myMethods.SplitStrings(myString);

            Console.WriteLine("\n");

            var newPlayer = new Player();

            int? life = newPlayer.Life;
            newPlayer.UserInput();

            newPlayer.TakeDamage();
        }
    }
}
