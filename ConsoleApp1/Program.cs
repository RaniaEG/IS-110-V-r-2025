// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");

// Opprettet et objekt "Rania" av Type "Person" ved bruk av nøkkel ord "new" og konstruktøren "Person()"
Person Rania = new Person();

// Setter verdi til "Navn" som er automatisk implementert engenskap
Rania.Navn = "Rania";

// Kaller "Spise()" og "Kjøpe()" metodene på "Rania" objektet
Rania.Spise();
Rania.Kjøpe();

Rania.SkriveUt();
//Rania.SumTall();
//Rania.DivideTall();

Welcome1 w = new Welcome1();
w.SkrivUtTekst(); */

/*--------------- Uke 3 øvelser ---------------*/
/*  Øvelse 2  */
// opprette et objekt
Bil minbil = new Bil();

// sette verdier 
minbil.SetMerke("Mercedes");
minbil.SetModell("S-Class");
minbil.SetÅr("1998");

// hente verdier
string minBilMerke = minbil.GetMerke();
string minBilModell = minbil.GetModell();
string minBilÅr = minbil.GetÅr();

// skrive ut verdier
Console.WriteLine($"Min bil har merke: {minBilMerke}, modell: {minBilModell}, år: {minBilÅr}");

/*  Øvelse 1  */
int x, y, z, resultat;
Console.WriteLine("Please enter value for first integer: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter value for second integer: ");
y = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter value for third integer: ");
z = int.Parse(Console.ReadLine());

resultat = x * y * z;
Console.WriteLine($"Multiplikasjonsresultatet er: {resultat}");

/*  Øvelse 3  */
Kalkulator kalk = new Kalkulator();
Console.WriteLine("Please enter value for first number: ");
kalk.Nummer1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter value for second number: ");
kalk.Nummer2 = double.Parse(Console.ReadLine());

kalk.Resultat = kalk.CalcAddition();
Console.WriteLine($"Addisjon resultatet er: {kalk.Resultat}");