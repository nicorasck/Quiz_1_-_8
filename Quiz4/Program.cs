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