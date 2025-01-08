// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Opprettet et objekt "Rania" av Type "Person" ved bruk av nøkkel ord "new" og konstruktøren "Person()"
Person Rania = new Person();

// Setter verdi til "Navn" som er automatisk implementert engenskap
Rania.Navn = "Rania";

// Kaller "Spise()" og "Kjøpe()" metodene på "Rania" objektet
Rania.Spise();
Rania.Kjøpe();