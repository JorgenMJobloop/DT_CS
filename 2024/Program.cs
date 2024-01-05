using System;
using System.IO;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if we use a type of dynamic CLI solution, that takes user input in a variable and opens up the I/O system dialog.
            // we can then prompt the user to give a full path of the file that is to be read.
            

            Console.WriteLine("Give a filepath: ");
            string filePath = Console.ReadLine();
            Console.WriteLine("Filename: ");
            string fileName = Console.ReadLine();
            
            try {

                string fullPath = Path.Combine(filePath, fileName);
                using (StreamWriter newWriter = new StreamWriter(fullPath)) {
                    newWriter.WriteLine("l1: Hello from C#!");
                    newWriter.WriteLine("l2: Access to path denied?");
                }
                Console.WriteLine("Written to file");

                // try to read the content of the file
                string fileContent = File.ReadAllText(filePath + "\\" + fileName);
                Console.WriteLine(fileContent);

            }

            catch(IOException e) {
                Console.WriteLine(e);
            }
        }
    }
}
