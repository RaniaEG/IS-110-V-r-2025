public class Bil {
// instansvariabler
private string merke;
private string modell;
private string år;

public string Merke {set; get;}

// konstruktør
public Bil(){

}

// set/get metoder til Merke
public void SetMerke(string bilMerke){
    merke = bilMerke;
}
public string GetMerke(){
    return merke;
}

// set/get metoder til Modell
public void SetModell(string bilModell){
    modell = bilModell;
}
public string GetModell(){
    return modell;
}

// set/get metoder til År
public void SetÅr(string bilÅr){
    år = bilÅr;
}
public string GetÅr(){
    return år;
}



}