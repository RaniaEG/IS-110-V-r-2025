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
// Console.WriteLine($"Min bil har merke: {minBilMerke}, modell: {minBilModell}, år: {minBilÅr}");

/*  Øvelse 1  */
/* int x, y, z, resultat;
Console.WriteLine("Please enter value for first integer: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter value for second integer: ");
y = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter value for third integer: ");
z = int.Parse(Console.ReadLine());

resultat = x * y * z;
Console.WriteLine($"Multiplikasjonsresultatet er: {resultat}"); */

/*  Øvelse 3  */
/* Kalkulator kalk = new Kalkulator();
Console.WriteLine("Please enter value for first number: ");
kalk.Nummer1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter value for second number: ");
kalk.Nummer2 = double.Parse(Console.ReadLine());

kalk.Resultat = kalk.CalcAddition();
Console.WriteLine($"Addisjon resultatet er: {kalk.Resultat}"); */

/////////////////// Hus eksempel //////////////////////
// opprette et objekt av type Hus og sette verdier til det objektet
Hus etHus = new Hus();
etHus.Adresse = "Gimlemoen";
etHus.AntallEtasjer = 2;
etHus.AntallRom = 1;
etHus.AntallVegger = 3;
etHus.ByggeÅr = 2000;

// kalle metodene og sjekke om at huset er klar for salg eller ikke
etHus.ByggHus(1, "Nodeland"); // her har vi ikke gjort noe med adressen enda!
if(etHus.KlarForSalg() == false){
    Console.WriteLine("Huset er ikke klar for salg!");
}
else{
    Console.WriteLine("Huset er klar for salg!");
}
