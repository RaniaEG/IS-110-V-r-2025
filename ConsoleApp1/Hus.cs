public class Hus {
    public int AntallRom {set; get;}
    public string Adresse {set; get;} = "";
    public int AntallEtasjer {set; get;}
    public int AntallVegger {set; get;}
    public bool HarTak {set; get;}
    public int ByggeÅr {set; get;}


    // KlarForSalg er en metode som returnerer en boolsk verdi
    public bool KlarForSalg() {
        // erKlar er en lokal variabel  
        bool erKlar = true;
        if(AntallVegger < 4){
            erKlar = false;
        }
        if(AntallRom < 5){
            erKlar = false;
        }
        if(AntallEtasjer < 1){
            erKlar = false;
        }
        if(Adresse == string.Empty){
            erKlar = false;
        }
        if(!HarTak){
            erKlar = false;
        }
        if(ByggeÅr == 0){
            erKlar = false;
        }

        return erKlar;
    }

    public void ByggHus(int etasjer, string adresse){
        while (AntallVegger < 4){
            AntallVegger = AntallVegger + 1;
            Console.WriteLine("Vi har satt opp en vegg!");
        }

        while(AntallEtasjer < etasjer){
            AntallEtasjer = AntallEtasjer + 1; // eller AntallEtasjer++;
            Console.WriteLine("Vi har satt opp en etasje!");
        }
    }







}