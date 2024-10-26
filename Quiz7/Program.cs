namespace Quiz7;

public class Bird // Question 5
{
        public bool ICanFly { get; } = true; // Public property // Question 5
        public virtual bool ICanFly2 { get; } = true; // Public virutal property (Kan overrideas) // Question 6
}

public class Duck : Bird { }

public class Ostrich : Bird
{
        public new bool ICanFly { get; } = false; // Här används new för att dölja propertien i Bird // Question 5
        public override bool ICanFly2 { get; } = false; // Här används override för att ersätta Birds property // Question 6
}

class Program
{
        static void Main()
        {
                Console.WriteLine("Q1");
                // Ett logiskt uttryck är ett uttryck som resulterar i true eller false
                // Till exempel 3 < 5 eller 7 == x

                // Ett Matematiskt uttryck är ett uttryck som resulterar i ett värde (en siffra)
                // Till exempel 5 + 2 eller 7 * x


                Console.WriteLine("Q2");

                // Referens-likhet jämför om två saker är samma objekt
                // Värde-likhet jämför om två saker har samma värde


                Console.WriteLine("Q3");

                // En rectangular array har samma mängd värden i varje rad
                /*
                 [
                  [ 1, 2, 3 ]
                  [ 4, 5, 6 ]
                  [ 7, 8, 9 ]
                  [ 1, 2, 3 ]
                  ]
                */

                // En jagged array kan ha olika mängder värden på varje rad
                /*
                [
                [ 1, 2,]
                [ 3, 4, 5, 6 ]
                [ 7, 8, 9, 0 ]
                ]
                */


                Console.WriteLine("Q4");

                // En virtual metod / property är en metod som kan overrideas av en child-implementaion


                Console.WriteLine("Q5");

                Bird duck = new Duck();
                Bird ostrich = new Ostrich();

                Console.WriteLine($"Duck can fly? {duck.ICanFly}");
                Console.WriteLine($"Ostrich can fly? {ostrich.ICanFly}"); // Kommer printa true eftersom varibeln är av typen bird och inte ostrich


                Console.WriteLine("Q6");

                Console.WriteLine($"Duck can fly? {duck.ICanFly2}");
                Console.WriteLine($"Ostrich can fly? {ostrich.ICanFly2}");


                Console.WriteLine("Q7");

                // En mutable typ är en typ som kan ändras, så som en int eller array
                // en immutable typ är en typ som inte kan ändras, till exempel record och string, eller readonly variabler

                // String och record är immutable referens typer


                Console.WriteLine("Q8");

                /* 
                 * Förälderklassen (parent class) övertar alla egenskaper från dess barn (derived class) == Falskt
                 * Ett barn (derived class) ärver alla publika (public) och skyddade (protected) egenskaper från förälderklassen (parent class) == Sant
                 * I en instans av ett barn kan man använda base och this C# keywords för att skilja på användning av förälderns och barnets members == Sant
                 * Virtuella metoder är ett sätt att anropa barnets implementation av en metod som föräldern också har implementerat. == Sant
                 */


                Console.WriteLine("Q9");

                // En indexer används för att kunna komma åt en class array / list direkt från referensen
                // var zoo = new csZoo();
                // zoo[0] istället för zoo.ListOfAnimals[0] är ett exempel på hur en indexer används

                // public csAnimal this[int idx] { get => ListofAnimals[idx]; } hade man kunnat skriva en indexer för csZoo


                Console.WriteLine("Q10");

                csBook[] books = new csBook[]{
                        new csBook { Title = "The Adventures of Tom Sawyer", Author = "Mark Twain"},
                        new csBook { Title = "The Alchemist", Author = "Paulo Coelho"}};

                csBook[] booksCopy = new csBook[2];

                /*
                // Copy 1
                booksCopy = books; // booksCopy är en referens till books
                booksCopy[0].Title = "Frankenstein"; // Ändrar värdet på stacken som båda pekar på
                Console.WriteLine(books[0].Title); // Prints Frankenstein

                booksCopy[0] = null;
                Console.WriteLine(books[0].Title); // Crashes with NullReferenceException
                */

                /*
                // Copy 2
                Array.Copy(books, booksCopy, books.Length); // Skapar en shallow-copy, en ny array men värdena på heapen är delade mellan books och booksCopy
                booksCopy[0].Title = "Frankenstein"; // Ändrar båda
                Console.WriteLine(books[0].Title); // Prints Frankenstein

                booksCopy[0] = null; // Sätter endast booksCopy's referens till null, men inte books referens
                Console.WriteLine(books[0].Title); // Prints Frankenstein
                */

                // Copy 3

                // Skapar en deep-copy (en ny araray med likadana värden)
                for (int i = 0; i < books.Length; i++)
                {
                        booksCopy[i] = new csBook(books[i]);
                }

                booksCopy[0].Title = "Frankenstein"; // Ändrar bara i booksCopy
                Console.WriteLine(books[0].Title); // Printar The Adventures of Tom Sawyer

                booksCopy[0] = null;
                Console.WriteLine(books[0].Title); // Printar The Adventures of Tom Sawyer
        }
}

public class csBook // Question 10
{
        public string Title { get; set; }
        public string Author { get; set; }

        public csBook() { }
        public csBook(csBook org)
        {
                Title = org.Title;
                Author = org.Author;
        }
}