public class Kalkulator {
    // her brukte vi automatiske egenskaper
    public double Nummer1 {set; get;}
    public double Nummer2 {set; get;}
    public double Resultat {set; get;}

    public Kalkulator () {

    }

    public double CalcAddition(){
        Resultat = Nummer1 + Nummer2;
        return Resultat;
    }



     
}