using Forelesning8;

// Nå oppretter vi et objekt "elf" av Elefant og et objekt "lv" av Løve
Elefant elf = new Elefant();
Løve lv = new Løve();
elf.alderÅr = 80;
elf.vektKG = 6000;

lv.alderÅr = 15;
lv.vektKG = 189;

// lager vi en liste "dyr" og legger objektene (elf og lv) inn li listen. Her er listen initialisert med 2 plasser
List<IDyr> dyr = new List<IDyr>(2);
dyr.Add(elf);
dyr.Add(lv);

// Her bruker vi foreach løkke og definerer vi idyr variabel av type IDyr som beholder verdien hentet fra dyr liste
foreach (IDyr idyr in dyr)
{
    // Her printer vi verdiene som idyr beholder etter metodekalling av Bråker()
    Console.WriteLine($"Dyret sier {idyr.Bråker()}"); // Vi vet ikke hvilken metode blir kjørt (lav coupling)
}

// LINQ spørring på hvor mye du vil
var spørring = from gamleDyr in dyr
               where gamleDyr.alderÅr > 50
               select gamleDyr;

// reslutat beholder verdier vi henter gjennom spørringen (enumerering)
var resultat = spørring.ToList();

// foreach løkke for å gå gjennom resultat
foreach(IDyr idyr in resultat)
{
    Console.WriteLine($"Dyrer som sier {idyr.Bråker()} er over 50 år");
}