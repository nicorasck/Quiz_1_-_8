// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




/*

1. Förklara Operator overloading och varför används det? 

    En klass eller en sruktur kan ha en anpassad implementering av operators i fall en eller båda är av samma typ.
    ==
    !=
    villkorliga operatorer, såsom "+", "-", "+=", "!=" till konsumenten av typen.

                                                                                  Detta stycke kallas för Tuple!
    public static bool operator ==(RectangleClass r1, RectangleClass r2) => (r1.Width, r1.Height) == (r2.Width, r2.Height);
    public static bool operator !=(RectangleClass r1, RectangleClass r2) => (r1.Width, r1.Height) != (r2.Width, r2.Height);

    - jämför om två klasser är lika eller ej lika
    - kan definieras om så att man kan slå ihop två strängar.

-------------------------------------------------------------------------------------------------------------------------------

2. Förklara skillnaden mellan Property och Field i en class eller struct 
• Varför använder man properties istf fields? 

    Field -         
                    Field är en variabel av någon sorts typ som är deklarerad i 
                    en class eller struct (ex.int eller string).
                    Fields är members som innehåller dess typ.
                    OBS! När det är i en class rekommenderas det att använda en 
                    get; set;
                    
    Properties -    ex. public int nrOfCars { get; set; }
                    (här innehåller den properties där man kan sätta ett värde 
                    med get och få ut ett värde med set)

-------------------------------------------------------------------------------------------------------------------------------

3. Förklara designmetodologin ”Backing Field” 

• När använder man ”Backing Field” metodologin? 

    public long Height
    {
        get {return _height}
        {
        set
        (if value < 0 throw new ArgumentException("Height cannot be negative");
        Height = Value;
        }
    }
    
    - SKRIV EN FÖRKLARING YO!

-------------------------------------------------------------------------------------------------------------------------------

4. Förklara skillnaden mellan en static member och en non-static member i in 
class eller struct. 

    -   En static gör att man kan nå membern i resten av programmet.
        ex. int x = 10; // Non-static variabel'

    -   Non-static kan enbart nås innanför scopet.
        ex. static int x = 10; // static variabel

-------------------------------------------------------------------------------------------------------------------------------

5. Vad är en instans av en class? 

    -   Man skapar en ny instans av en redan deklarerad variabel.
        ex. csCar car1 = new csCar(); // skapat en ny instans med 'new csCar'

        Objektet som har skapats av ritningen i en class (ligger alltså på heapen).

6. Vad är en class constructor? 

    • Hur deklareras en class constructor? 
    - ex. 'public csCar (int Year, string Name, string Color)' // det som ör innanför '()' kallas för parametrar -> skapar en contructor.

    • Varför använder man en constructor? 
    -   I constructorn initierar man instansen -> för att man ska kunna hämta constructorn, det vill säga metoden man har skapat,
        in till sitt program när man kör.


    • Förklara relationen mellan en constructor och object initiering 

    constructorn är för att skapa objectet och object initieringen är för att sätta värdet när man skapar objectet, ex: csCar c1 = new csCar(){}
    En metod är ett agerande hur ett objekt ska visas.
    ex. var a3 = new csAnimal(enAnimalKind.Eagle, enAnimalMood.Lazy, rnd.Next(1, 100), rnd.PetName);
    (du skapar en ny instans av något, initierar instansen med de värden som har skapats i classen/strukten)

-------------------------------------------------------------------------------------------------------------------------------

7. Förklara begreppen, instantiering, variabel, referens till en instans, heap, 
stack, constructor, object initiering med nedan två koder.  

    • PlayingCard card = new PlayingCard(); 
    PlayingCard är typen som hamnar på stacken, card är variabeln (innehållet i variabeln är en referens som pekar mot hepaen),
    new PlayingCard är initieringen som också hamnar på heapen och i detta fall är constructorn tom.

    • PlayingCard card = new PlayingCard () { Value = 2}; 
    object initiering är {value = 2}

-------------------------------------------------------------------------------------------------------------------------------

8. OOP bygger på 3 principer, Encapsulation (inkapsling), Inheritance (Arv), 
Polymorphism (Polymorfism). Förklara de 3 begreppen

Encapsulation - det är själva classen

Inheritance -   ärver attributen i 'barn-noden', till exempel om man har skapat en string med värdet "Gammal" så förs det vidare
                nästa. Gäller även metoder - man ärver innehåll från en klass till en annan klass.

Polymorphism -  det är när 'föräldern' använder 'barn-nodens' attribut/implentering, som en tvist på originalet.
                ex. ToString är den mest vanliga metoden i Polymorphism.





*/