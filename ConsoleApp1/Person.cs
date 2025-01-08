
public class Person {
    //Instans variabler og de er synlige kun for alle metodene i "Person" klassen
    private string navn;
    private string handelliste;

    // Her kan dere prøve å leke med C# sine automatisk implementerte egenskaper
    public string Navn {get; set;}

    

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
}