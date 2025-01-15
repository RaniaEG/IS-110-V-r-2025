
public class Person {
    //Instans variabler og de er synlige kun for alle metodene i "Person" klassen
    private string? navn;
    private string? handelliste;



    // Her kan dere prøve å leke med C# sine automatisk implementerte egenskaper
    public string? Navn {get; set;}

    

    // Konstruktøren får alltid samme navn so klassens navn, men med metode paranteser "Person()" for å kunne opprette objekter av type Person
    public Person() {
        // Initialisere verdiene til navn og handelliste
        navn = "";
        handelliste = "";

    }

    // Metoder
    public void Spise() {
        // "mat" er en lokal variabel og den er synlig kun for "Spise()" metoden
        string mat = "kjøtt";
        Console.WriteLine($"Hei {Navn}, Du spiser nå "+ mat);
    }
    public void Kjøpe() {
    handelliste = "egg, melk, ost, brød";
    Console.WriteLine("Din vanlig handel liste er: "+ handelliste);

    // Hvis du prøver å bruke "mat" variabelen i "Kjøpe()" metoden så får du kjeft fra C# kompilatoren at den varabelen finnes ikke i konteksten av denne metoden "Kjøpe"
    // Den følgende linjen vil ikke kjøres
    // Console.WriteLine("Din vanlig handel liste er: "+ mat);

    }

    public void SkriveUt(){
        Console.WriteLine("Welcome \n to \nC# Programming!");
    }

    public void SumTall(){
        int nummer1;
        int nummer2;
        int sum;
        Console.WriteLine("nummer1 verdi:");
        nummer1 = int.Parse(Console.ReadLine());

        Console.WriteLine("nummer2 verdi:");
        nummer2 = int.Parse(Console.ReadLine());

        sum = nummer1 + nummer2;
        Console.WriteLine($"Summen er: {sum}");

    }

    public void DivideTall(){
        double n1;
        double n2;
        double result;
        Console.WriteLine("nummer1 verdi:");
        n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("nummer2 verdi:");
        n2 = double.Parse(Console.ReadLine());

        result = n1 / n2;
        Console.WriteLine($"Resultatet er: {result}");

    }
}