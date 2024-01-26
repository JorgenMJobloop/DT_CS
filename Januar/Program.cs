namespace DT24
{
    internal class Program
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        // static void main() er selve programmet , her kjøres all koden og her må all koden kalles fra/til.
        static void Main(string[] args)
        {
            // code goes here
            // kall til Sum metoden
            Console.WriteLine(Sum(1, 3));
            int x = 5;
            double y = 3.2;
            float z = 1;
            Console.WriteLine(x + y + z);

            string helloWorld = "Hello World!";

            // vi legger til [] square brackets, for å signalisere at det er et string array
            string[] myArray = { "Hello", "World", "From", "A", "C#", "Array!" };

            int[] myIntArray = { 1, 2, 3 };

            Console.WriteLine(helloWorld);

            // foreach loops
            foreach (string arrays in myArray)
            {
                Console.WriteLine(arrays);
            }


            foreach (int myNumber in myIntArray)
            {
                Console.WriteLine(myNumber);
            }

        }
    }

}
