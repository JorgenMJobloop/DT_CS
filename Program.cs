using System;
using System.Runtime.CompilerServices;
public struct Koordinater
{
    public double X;
    public double Y;
}

// Klasse, fra C++/Java/Simula etc. Standard OOP notasjon

public class Person {
    // properties/innhold
    public string Navn {get; set;}
    public int Alder {get; set;}
    // constructor/byggstener
    public Person(string navn, int alder) {
        Navn = navn;
        Alder = alder;
    }
    // method(også referert som funksjon i noen språk)
    public void GiNavnOgAlder() {
        System.Console.WriteLine($"Personens navn er {Navn}. Og de er {Alder} år gamle!");
    }
}


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello!");

             // Array
            List<int> numberList = new List<int>() {1,2,3,4,5};
            // Lambda funksjon
            numberList.AddRange([6,7,8,9,10]);
            numberList.ForEach(number => Console.WriteLine(number));

            int[] numberArray = {1,2,3,4,5};

            for(int i = 0; i < numberArray.Length; i++) {
                Console.WriteLine(numberArray[i]);
            }

            // for(int i = 0; i < numberArray.Length; i++) {
            //     Console.WriteLine(numberArray[i]);
            // }

            // List
            List<string> myStrings = new List<string>();
            // Legger til en verdi i listen
            myStrings.Add("Hello World!");
            // skriver ut selve listen til konsollen
            System.Console.WriteLine(myStrings.First());
            // Tuple
            var newTuple = Tuple.Create("25", 5);
            // Skriver ut informasjon om Tuple strukturen til
            System.Console.WriteLine($"{newTuple.Item2} er en faktor i {newTuple.Item1}");
            // Kall til struct
            Koordinater x_y = new Koordinater{X = 1.5, Y = 2.5};

            System.Console.WriteLine($"X koordinater: {x_y.X}, Y koordinater: {x_y.Y}");
            // kall til den offentlige klassen i programmet.

            // initialiserer klassen med et nytt objekt

            Person nyPerson = new Person("Ola Nordmann" ,99);

            // henter ut method og skrive ut informasjon til konsollen.
            nyPerson.GiNavnOgAlder();

            // Dictionary datatypen
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                {"Anakin", 8},
                {"Obi-Wan", 25},
                {"Qua-Gon", 40}
            };
            foreach(var myKeyValuePair in ages) 
            {
                Console.WriteLine($"{myKeyValuePair.Key}: {myKeyValuePair.Value}");
            }
        }
    }
}

