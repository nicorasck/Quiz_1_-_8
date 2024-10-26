// See https://aka.ms/new-console-template for more information
namespace quiz6;

interface ImyInterface
{ // En interface med namn ImyInterface
        public int add(); // En metod som måste implementas när interface:en implementeras 
        public int x { get; set; } // En property som måste implementas
}

class Program
{
        static void Main()
        {
                Console.WriteLine("Quiz 6\n\n");
                Console.WriteLine("Q1");
                // Interface är ett kontrakt med ett löfte, så att man kan implementera en funktion eller datatyp på olika sätt, men ändå använda koden i ett större projekt.
                // Detta är det ena sättet interface används, som en typ av abstraktion.
                // Det andra är för att implementera egenskaper () för klasser, så som jämförelse (IComparable)
                //-Icomp

                Console.WriteLine("Q2");
                int a = 1;
                int[] array = { 1, 1 };
                int b = 1;
                methodA(a, array, out b);

                // A är en value type och kommer därför inte ändras, array är en refence type och kommer därmed att skrivas över med 2
                // B är en out-parameter och kommer därför få värdet 2 från metoden
                Console.WriteLine($"a: {a}, array[0]: {array[0]}, b: {b}"); // 1, 2, 2

                Console.WriteLine("Q3");

                Console.WriteLine("Q4");
                // Array är alltid en reference type
                int[] myarray1 = null;
                int[] myarray2 = new int[10];
                int[] myarray3 = new int[] { 1, 2, 3, 4, 5 };
                int[] myarray4 = { 6, 7, 8, 9 };

                Console.WriteLine($"{myarray1?.Length} {myarray1?[0]}"); // ' ' // Om '?' tas bort så får vi en Execption 
                Console.WriteLine($"{myarray2.Length} {myarray2[0]}"); // 10, 0
                Console.WriteLine($"{myarray3.Length} {myarray3[0]}"); // 5, 1
                Console.WriteLine($"{myarray4.Length} {myarray4[0]}"); // 4, 6

                Console.WriteLine("Q5");
                var myStruct = new StructA();
                // myStruct är en variabel på stacken == Sant
                // myStruct innehåller allokerat minne för en instans på stacken == Sant
                // new StructA() skapar en instans på heapen == Falskt
                // myStruct innehåller en referents till instansen på heapen == Falskt

                Console.WriteLine("Q6");
                // Falskt, struct stödjer ej arv
                // Sant, Class och record stödjer alla principer (inheritance, polymorphism, encapsulation)
                // Falskt, Struct stödjer både encapsulation och polymorphism
                // Falskt stödjer alla 3
                List<IL> poly; // Exemepel på polymorphism med structs och classes

                Console.WriteLine("Q7");
                // En field har endast typ och namn: int x
                // Properties har get/set/init: int x { get; init; }

                Console.WriteLine("Q8");
                // En struct används när vi har få members (mindre än 5-ish) och inte behöver arv

                Console.WriteLine("Q9");
                // En typ vars instans inte kan ändra värde efter initiering == Sant
                // En typ vars instans inte kan kopieras == Falskt
                // En typ där alla ändringar på en instans, genom dess metoder, måste returnera en ny instans där ändringarna är reflekterade == Sant?

                Console.WriteLine("Q10");
                // En record är en immutable class

        }

        static void methodA(int a, int[] array, out int b)
        {
                a = 2;
                array[0] = 2;
                b = 2;
        }

        //Q3
        // Här är våran metod, question3 är namnet, void är retur typen (inget här), int x är en parameter
        // Signaturen är: void question3(int x)
        // method overloading är när man deklarerar en method med samma namn fast olika parametrar
        static void question3(int x)
        {
                x = 7;
        }

        static void question3(int x, int y)
        { // Detta är en overloading
                x = 8;
                y = 9;
        }

        public struct StructA
        {
                DateTime aTime;
        }

        public interface IL
        {
                int x { get; set; }
        }

        public class csL : IL
        {
                public int x { get; set; }
        }

        public struct stL : IL
        {
                public int x { get; set; }
        }
}



/*
----------------------------------- QUIZ 6 -----------------------------------

1. Förklara vad ett gränssnitt (interface är). Vilka är de två huvudanvändningsområdena?

    Interface är ett kontrakt med ett löfte, så att man kan implementera en funktion eller datatyp
    på olika sätt, men ändå använda koden i ett större projekt.

    Det ena sättet interface används, som en typ av abstraktion. Man kan inte implementera ett arv.
    Allt måste vara public, Methods, Properties, INdexers, Events

    Det andra är för att implementera egenskaper () för klasser, så som jämförelse (IComparable)
    -Icomp
    Notering: .NET kräver IComparable för att kunna lösgöra .NETs funktionalitet, för att jämföra
_____________________________________________________________________________
2. Givet nedan metod: 

    Static void MethodA (int a, int[] array, out int b)
    {
        a = 2;
        array[0] = 2;
        b = 2;    
    }

    Betrakta nedan kod och svara på frågorna 

    int a = 1;
    int[] array = {1, 1};
    int b = 1;

    MethodA(a, array, out b):

    Console.WriteLine($"a: {a}, array[0], b: {b}");

Vad skrivs ut?

    A är en value type och kommer därför inte ändras, array är en refence type och kommer därmed
    att skrivas över med 2.
    B är en out-parameter och kommer därför få värdet 2 från metoden

    Output:
    a: 1, array[0], b: 2
_____________________________________________________________________________
3. Deklarera en Metod 
• Förklara metodens signatur
• Vad är Metod overloading och när kan man göra det?

    Här är våra metod, question3 är namnet, void är retur-typen (inget här), int x är en parameter
    Signaturen är: void question3(int x) => metodens namn och parametrar
    
    Method overloading är när man deklarerar en method med samma namn fast olika parametrar
    (måste ha samma returtyp)

    static void question3(int x)
    {
            x = 7;
    }

    static void question3(int x, int y)
    { // Detta är en overloading
            x = 8;
            y = 9;
    }
_____________________________________________________________________________
4. Är en array en referens-typ (reference type) eller värde-typ (value type)? 

    - Array är alltid en reference type.

Vad kommer att skrivas ut i nedan kod? 

    Console.WriteLine("Q4");
    int[] myarray1 = null;
    int[] myarray2 = new int[10];
    int[] myarray3 = new int[] { 1, 2, 3, 4, 5 };
    int[] myarray4 = { 6, 7, 8, 9 };

    Console.WriteLine($"{myarray1?.Length} {myarray1?[0]}"); // ' ' // Om '?' tas bort så får vi en Execption 
    Console.WriteLine($"{myarray2.Length} {myarray2[0]}"); // 10, 0
    Console.WriteLine($"{myarray3.Length} {myarray3[0]}"); // 5, 1
    Console.WriteLine($"{myarray4.Length} {myarray4[0]}"); // 4, 6

    Output:
    Q4
    " " //blir null, dvs inget alls
    10 0
    5 1
    4 6
    
Vad händer om utskriften av myarray1 ovan ändras till 
Console.WriteLine($"{myarray.Length} {myarray[]}");
_____________________________________________________________________________
5. Givet nedan typ:

public struct StructA
{
    DateTime aTime; // detta värde allokeras på stacken eftersom struct är en value type
}

Betrakta nedan kod och svara på frågorna. 

var myStruct = new StructA();

    Vilka påstående är sanna? 
    § myStruct är en variabel på stacken  
    - Sant, struct är en värdetyp

    § myStruct innehåller allokerat minne för en instans på stacken 
    - Sant, eftersom det är en värdetyp så skapas det en "box" på stacken.

    § new StructA() skapar en instans på heapen 
    - Falskt
    
    § myStruct innehåller en referents till instansen på heapen 
    - Falskt, struct är ingen reference typ och hamnar därför ej på heapen.
_____________________________________________________________________________
6. Vilka påstående är sanna  

    § class, record class och struct stöder alla tre OOP principerna 
    - Falskt, class och record class stöder men inte struct (kan ej ärva)
    
    § class och record stöder alla tre OOP principerna 
    - Sant, Class och record stödjer alla principer (inheritance, polymorphism, encapsulation)

    § struct stödjer enbart Inkapsling (Encapsulation) 
    - Falskt, Struct stödjer både encapsulation och polymorphism

    § class stödjer enbart Inkapsling (Encapsulation) 
    - falskt stödjer alla 3
    
    List<IL> poly; // Exemepel på polymorphism med structs och classes
_____________________________________________________________________________
7. Förklara skillnaden mellan fält (Fields) och attribut (Properties)

    Properties har { get; set; } / { get; init; }
    Field har endast typ, en variabel, och namn: int x

    Ex. Interface får ej ha fields men properties
_____________________________________________________________________________
8. Förklara när man ska använda typen struct i stället för typen class? 

    I struct används färre members så som fields eller properties.
    Tex färre än fem och ej använder sig av arv.
    Struct är en bastyp!

    Notering: Man kan ej ha en array i en struct eftersom struct är en reference type.
_____________________________________________________________________________
9. Vad är sant avseende en ”immutable type”? 

    § En typ vars instans inte kan ändra värde efter initiering 
    - Sant.

    § En typ vars instans inte kan kopieras 
    -  Falskt

    § En typ där alla ändringar på en instans, genom dess metoder, måste 
    returnera en ny instans där ändringarna är reflekterade 
    - Sant??? Det måste skapas en ny individ
_____________________________________________________________________________
10. Vad är sant avseende typen record (class). 


    § En record är en immutable class 
    - Sant. En record är en immutable class!

    § En record är en mutable class 
    - Falskt.

    § En record är en immutable struct 
    - Falskt.

    § En record är en mutable struct 
    - Falskt.
_____________________________________________________________________________

*/



