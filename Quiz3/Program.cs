// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Draw a stack heap visualization diagram for below code sequences
//Sequence 1
int i1 = 10;
int j1 = i1;
i1 = 20;

//Sequence 2
string s2 = "Hello";
string t2 = s2;
s2 = "Goodbye";

//Sequence 3
int[]  ints3 = { 1,2,3,4,5,6,7,8};
int[] ints4 = ints3;
ints3[0] = 15;


//Sequence 4
stA v1 = new stA() { val = 10};
stA v2 = v1;
v2.val = 20;

csA r1 = new csA() { val = 10};
csA r2 = r1;
r2.val = 20;

//Sequence 5
stA[] stAs = new stA[] { v1, v1, v1};
stAs[0].val = 20;
stAs[1].val = 30;
stAs[2].val = 40;

csA[] csAs = new csA[] { r1, r1, r1};
csAs[0].val = 20;
csAs[1].val = 30;
csAs[2].val = 40;



public struct stA {
    public int val {get; set;}
}
public class csA {
    public int val {get; set;}
}


/*

    Quiz 3 Svar
    
    1.
    Typen är int,float, string osvVärdet det du sätter: 3, defaultVariablerna börjar med my
    tex myIntConst är string och där försvinner variabeln.
    (Ändrar man värdet i en gammal variabel så försvinner det värdet)
    
    2.
    Int, long, unsigned(kan inte va negativ, likadant med UL), unsigned long, float,decimal,m(decimal,money),
    string , bool.

    uint (unsigned int) -> kan ej vara negativ
    ulong (unsigned long) -> kan e vara negativ
    
    3.
    Implicit Type Casting:
    Sker automatiskt när det inte finns risk för dataförlust,
    exempelvis från int till double.

    Explicit Type Casting:
    Krävs när du omvandlar mellan oförenliga typer eller
    från en större typ till enmindre, exempelvis från double till int.
    Tex i project part när du omvandlar priset till en decimal fast det kan va en int.
    
    4.
    Console.WriteLine($"{int.MinValue}{int.MaxValue");
    Samma princip med dom andra typerna.
    
    5.
    3 första med int är Aritmetiska, bool och if satsen är logiska
    
    6.
    Value type lagras på stacken, referensen på heapen.
    
    Exempel:
    Referencetyp = Class
    Value type Int =
    
    int y = 10;
    int x = y;
    x = 10;
    
    Lagras på stacken tex. Memory Location Stored in the stack.
    Reference stored in the stack, object in heap.Copies Assigning copies the value(independent).
    Assigning copies the reference (points tosame data).FunctionParametersPassed by value (copy ofdata).
    Passed by reference (pointer todata).ExampleTypesPrimitive types (e.g., int, float,bool).Objects, arrays, strings (non-primitivetypes).
    
    7.
    1. CW: An inxpensive book, -20 radavstånd,      $70.00 med två decimaler, 10 radavstånd
    2. CW: A expensive book, -20 radavstånd,        $600.00 , 10 radavstånd
    
    C2 = dollar med två decimaler
    
    8.
    Loopen visar 5 siffror med ett radavstånd på 4 och ny sen rad. Loopen ileterar.
    
    9.
    Loopen visar samma men om variabeln men hoppar över alltså skriver inte ut i CW siffrorna3,8,13 eller 18.
    Så då blir outputen bara 4 kolumner ist för 5.
    
    10.
    Using system gör att du kan skriva ut consolewriteline, namespace gör det lättare att hålla ordning påkoden.
    The using System; statement allows you to reference the Console class without writingSystem.Console.WriteLine().
    Instead, you can just write Console.WriteLine().

*/
