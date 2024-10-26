﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quiz 1!");

string _var1 = "Hello";
int _var2 = 10;
decimal _var3;
float _var4 = 10F;

_var3 = 23M;

Console.WriteLine("Enter price");
string _sinput = Console.ReadLine();
decimal _dinput = decimal.Parse(_sinput);

_dinput *= 10;
string s = $"The price is {_dinput} Sek";
System.Console.WriteLine(s);


int i = int.MaxValue;
System.Console.WriteLine(i);

i++;
System.Console.WriteLine(i);

i++;
System.Console.WriteLine(i);


//Implicit type casting
int a = 3;
long l = a;
l = int.MaxValue;
System.Console.WriteLine(l);

//Explicit type casting
long b = long.MaxValue;
int c = (int) b;

System.Console.WriteLine(c);


string s1 = "3";
int i1 = int.Parse(s1);
System.Console.WriteLine(i1);

/*
------------------------------- Quiz1 -------------------------------

1. Skapa en Console Application i Visual Studio Code. 

    Starta VSC -> View Command Pallette -> New Project -> Console App -> [mapp]
    Det finns två viktiga filer som man måste ha för att kunna bygga programmet.
    1. csProj-filen, den talar om för programmet vad som ska köras.
    2. sln-filen (solution) - har man flera projekt mergar den ihop projekten.
______________________________________________________________________
2. Deklarera variabler av typerna string, int, decimal, float. Tilldela dessa 
värden och skriv ut till konsolen. 

    Man tilldelar typen ett variabelnamn och sedan initierar man ett värde till
    höger om '='. Se nedan exempel.

    string _var1 = "Hello";
    int _var2 = 10;
    decimal _var3;
    float _var4 = 10F;
______________________________________________________________________
3. Läs in ett decimal tal 3,67 från tangentbordet. Multiplicera talet med 10 och 
skriv ut till konsolen. 

    Console.WriteLine("Enter price");
    string _sinput = Console.ReadLine(); // användaren får mata in ett decimaltal
    decimal _dinput = decimal.Parse(_sinput);

    _dinput *= 10; // användarens decimaltal multiplcieras med 10
    string s = $"The price is {_dinput} Sek";
    System.Console.WriteLine(s); // skriver ut frasen samt svaret.
______________________________________________________________________
4. I din Applikation, skapa en ”git repository” lokalt på din dator. Gör en 
ändring i koden, följt av en ”git commit”, samt lägg upp koden på ditt Github 
konto. 

    Man trycker på Source Control (CTRL+SHIFT+G), sedan skriver man initial commit,
    därefter kan man publicera sitt projekt på GitHub, antingen private eller public.
______________________________________________________________________
5. Beskriv med dina egna ord begreppet ”string interpolation”. - 
Hur skriver man ”string interpolation” i C# 

    Man skriver ett '$' framför "" och när man gör det kan man hämta 
    den variabel man har initierat genom att sätta {} utanför variabeln.
    Se nedan exempel där variabeln är _dinput

    _dinput *= 10;
    string s = $"The price is {_dinput} Sek";
    System.Console.WriteLine(s);
______________________________________________________________________
6. Vilket är det största värdet som en variabel av typen int kan innehålla? - 
Deklarera en variabel, i, av typen int och tilldela den the största värdet. - 
Öka i med ett. Vad kommer i att ha för värde? 

    int i = int.MaxValue;
    System.Console.WriteLine(i);

    i++;            // ökar med 1
    System.Console.WriteLine(i);

    i++;            // ökar med 1 igen
    System.Console.WriteLine(i);

    Output:
    2147483647      // MaxValue av int
    -2147483648     // ökar man med 1 blir det negativt
    -2147483647     // ökar man med 1 igen börjar den räkna igen

    När man gör på detta vis, att öka med 1 över MaxValue kallas det för "Overflow".
______________________________________________________________________
7. I C# finns det ett begrepp som heter ”type casting”. Vad innebär detta?  - 
Ge exempel på en situation där C# kan själv göra en ”type cast” så 
kallad ”implicit type cast”, samt en situation där C# behöver din hjälp att 
göra en ”type cast”, så kallad ”explicit type cast”  

    //Implicit type casting. Tex från int till long
    int a = 3;
    long l = a;
    l = int.MaxValue;
    System.Console.WriteLine(l);
    Output: 2147483647

    //Explicit type casting. Tex från long till int
    long b = long.MaxValue;
    int c = (int) b;        // här tvingar man b att bli en int (fungerar ej
    annars)
    System.Console.WriteLine(c);
    Output: -1
______________________________________________________________________
8. Du har en variabel, s, av typen string som innehåller värdet ”3”. Nu vill du 
skapa en variabel av typen integer som innehåller talet från variabeln s, dvs 
3. Hur gör du?

    string s1 = "3";
    int i1 = int.Parse(s1);
    Output: 3
______________________________________________________________________
*/