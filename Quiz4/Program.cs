using System;
namespace quiz4
{

    class program
    {


        struct struct8
        {
            public static int myStaticInt;
            public int myInt;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Q1");

            int[] arr = new int[] { 8, 9, 1, 21 };
            int minV = int.MaxValue; //Start med max value så att vi alltid hittar det lägsta värdet
            int maxV = 0;

            foreach (int i in arr)
            {
                if (i < minV)
                { //Om nuvarande värdet är mindre än min (som startar på max så denna är alltid sann första gången)
                    minV = i; //Om den är mindre så sprar vi i i min
                }
                if (i > maxV)
                { //Samma fast med max
                    maxV = i;
                }
            }
            Console.WriteLine(minV); // 1
            Console.WriteLine(maxV); // 21

            Console.WriteLine("Q2");
            /*
                    static gör att alla instanser (skapade kopior) utav en klass eller struct delar på en variabel
                    så att t.ex static string är en string som tillhör klassen och inte varje koipa
            */


            Console.WriteLine("Q3");

            struct8 sb1 = new struct8() { myInt = 8 }; //Gör en nu "struct8" med värdet 8
            struct8 sb2 = new struct8() { myInt = 10 }; //En till med värdet 10
            struct8.myStaticInt = sb1.myInt + sb2.myInt; //Sparar 8 + 10 i struct8.myStaticInt
            Console.WriteLine(sb1.myInt); //8
            Console.WriteLine(sb2.myInt); //10
            Console.WriteLine(struct8.myStaticInt); //18


            Console.WriteLine("Q4");
            int? myInt = null; // Gör en tom int
            var anotherInt = myInt ?? 10; // Ger another int värdet myInt om den inte är tom, annars 10, så här blir det 10
            Console.WriteLine(anotherInt); // 10

            myInt = 5;
            anotherInt = myInt ?? 10; // myInt är 5 så another blir 5 här
            Console.WriteLine(anotherInt); //5


            Console.WriteLine("Q5");
            string myString = "3 30 50 Hello 65 80";
            string[] myStringArray = myString.Split(' '); // split myString till en array [3, 30, 50, Hello, 65, 80]
            int[] myIntArray = new int[6]; //En ny array med 6 ints i

            int n = 0;
            foreach (var item in myStringArray) //Loopa igenom vår string array
            {
                if (int.TryParse(item, out myIntArray[n])) //Spara alla siffror (ej Hello) i myIntArray
                {
                    n++;
                }
            }

            foreach (var item in myIntArray)
            {
                Console.Write($"{item,4}"); //Printa ut vår int array (3, 30, 50, 65, 80, 0)
            }


            Console.WriteLine("Q6");
            int aNumber = 30;
            Console.WriteLine(AddFive(aNumber)); //printar return från AddFive (30 + 5)
            Console.WriteLine(aNumber); // printar aNumber som är 30 

            Console.WriteLine("Q7");
            int[][] matrix1 = { //Jagged array
                        new int[] { 5, 10, -2, 13 },
                        new int[] { 42, 15, 46, 17, -8, -9 },
                        new int[] { 100, 131 } };

            int[,] matrix2 = { //Multi-dimensional array
                        { 5, -1, 12 },
                        { 32, 24, 15 },
                        { 61, 72, 18 } };

            foreach (var item in matrix1)
            {
                foreach (var item2 in item)
                {
                    Console.Write($"{item2} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine();
            }



            Console.WriteLine("Q8");

            var a = new stA(); //Ny struct a (värde typ)
            a.myVal = 10;
            var b = a; //Kopia av a, som ett ny variabel
            b.myVal = 20; //B blir 20, a är fortfarande 10

            Console.WriteLine(a.myVal); //10
            Console.WriteLine(b.myVal); //20

            var c = new csA(); //Ny klass c (reference)
            c.myVal = 10; //C == 10

            var d = c; //D är en ny reference till c, så två namn för samma sak
            d.myVal = 20; //både c och d blir 20

            Console.WriteLine(c.myVal); //20
            Console.WriteLine(d.myVal); //20
        }

        public static int AddFive(int anumber) //Del av Q6
        {
            anumber += 5;
            return anumber;
        }

        struct stA //Del av Q8
        {
            public int myVal;
        }

        class csA
        {
            public int myVal;
        }
    }
}

/*

------------------- QUIZ 4 -------------------

1.  Du har en array av heltal och din uppgift är att hitta högsta och lägsta
    talen. 

    Förklara hur du löser detta i C#. 

    int [] array = new int [8,9,1,21]

    int minValue = int.maxValue;
    int maxValue= o;

    foreach (var item in array)
    {
        if (i < min Value)
        {
            minValue = i;
        }
        if (i < maxValue)
        {
            maxValue = i;
        }
        return
    }


2.  Förklara skillnaden mellan static och non-static members i en struct eller 
    class. 

    - Static tillhör typen och gör så att det bara finns en kopia av den.
    - Non-static gör så att man måste ha en kopia i varje instans.
    
    ex. 'skola' med elever, där alla elever tillhör 'skola'. Alltså, skriver man
    la' i en string kommer alla elever upp.


3.  Givet nedan typ:

    struct structB
    {
        public static int myStaticInt;
        public int myInt;
    }

    - vad kommer att skrivas ut?

    structB sb1 = new structB {myInt = 8}
    structB sb2 = new structB {myInt = 10}
    structB.myStaticInt = sb1.myInt + sb2.myInt:    myStaticInt tillhör typen, inte value.
    Console.WriteLine(sb1.myInt);
    Console.WriteLine(sb2.myInt);
    Console.WriteLine(structB.myStaticInt);         (finns ingen instans bakom)

    output: 8
            10
            18 (tillhör structen -> 'myStaticInt', man kommer åt allt utanför tillskillnad från 'myInt')



4.  Vad kommer att skrivas ut i nedan kod? 

    int? myInt = null;
    var anotherInt = myInt ?? 10;
    Console.WriteLine(anotherInt);
    output: 10
    - printar ut 10 eftersom myInt är null (har inget värde)


    myInt = 5;
    anotherInt = myInt ?? 10;       operatorn ?? tittar på de båda värdena (null och 10)
    Console.WriteLine(anotherInt);
    output: 5
    - printar ut 5 eftersom myInt är 5



5.  Vad kommer att skrivas ut i nedan kod? 

    string myString = "3 30 50 Hello 65 80";
    string[] myStringArray = myString.Split(' ');
    int[] myIntArray = new int[6];

    int n = 0;
    foreach (var item in myStringArray)
    {
        if (int.TryParse(item, out myIntArray[n]))
        {
            n++;
        }
    }

    foreach (var item in myIntArray)
    {
        Console.Write($"{item, 4}");
    }
    
    output: Hello, World!
            3  30  50  65  80   0



6.  Givet nedan metod: 

    public static int AddFive(int aNumber)
    {
        aNumber += 5;
        return aNumber;
    }

    - Vad skrivs ut i nedan kod?
    
    int aNumber = 30;
    Console.WriteLine(AddFive(aNumber));
    Console.WriteLine(aNumber);

    output: 35      -> skicka
    output: 30



7.  Betrakta nedan kod och svara på frågorna.  - 
    Vad heter de två olika array strukturerna i C#? - - 
    Vad är den fundametala skillnaden? 
    Hur loopar jag igenom och skriver ut alla talen i array? 

    int [][] matrix1 = {new int [] {5,10,-2,13},
                        new int [] {42,15,46,17,-8,-9},
                        new int [] {100,131};
                        }

    1. jaggedArray                                  ex. int [][]

    ex.
    System.Console.WriteLine(matrix1[0][3]);
    output: 13      eftersom det är i första arrayen,
                    sedan fjärde pos. till höger

    int [,] matrix2 =   {{5,-1,12}
                        {32,24,15}
                        {61,72,18}};
                    
    2. multidimensionalArray / rectangularArray     ex.int [,]
    ex.
    System.Console.WriteLine(matrix2[1,1]);
    output: 24      eftersom det är i andra arrayen, pos,
                    pos 2 till höger.


    
8.  Betrakta nedan kod och svara på frågorna.
    - vad skrivs ut?

    struct stA
    {
        public int myVal;
    }
    class csA
    {
        public int myVal;
    }

    var a = new new stA();
    a.myVal = 10;

    var b = a;
    b.myVal = 20;

    Console.WriteLine(a.myVal);     // 10
    Console.WriteLine(b.myVal);     // 20

    var c = new csA();
    c.myVal = 10;

    var d = c;
    d.myVal = 20;

    Console.WriteLine(c.myVal);     // 20
    Console.WriteLine(d.myVal);     // 20

    STACK               HEAP
    --------           -----
    | a  10|            (a och b ligger endast på stacken eftersom
    --------            de är struct)
    | b  20|    
    --------
    | c    |   ---->    20 (c, d kopieras på heapen från c
    --------                och får därför samma väre)
    | d    |
    --------



*/

