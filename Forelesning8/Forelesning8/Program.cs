using Forelesning8;

// Nå oppretter vi et objekt "elf" av Elefant og et objekt "lv" av Løve
Elefant elf = new Elefant();
Løve lv = new Løve();

// lager vi en liste "dyr" og legger objektene (elf og lv) inn li listen. Her er listen initialisert med 2 plasser
List<IDyr> dyr = new List<IDyr>(2);
dyr.Add(elf);
dyr.Add(lv);

// Her bruker vi foreach løkke og definerer vi idyr variabel av type IDyr som beholder verdien hentet fra dyr liste
foreach (IDyr idyr in dyr)
{
    // Her printer vi verdiene som idyr beholder etter metodekalling av Bråker()
    Console.WriteLine($"Dyret sier {idyr.Bråker()}");
}
