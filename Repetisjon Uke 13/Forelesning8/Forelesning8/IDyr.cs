namespace Forelesning8
{
    internal interface IDyr // Noe å tenke på: trenger vi egentlig IDyr?
    {
        int alderÅr { set; get; }
        float vektKG { set; get; }
        string Bråker();
        void Spiser(string mat);
        // hvis vi legger til den metoden "void Krangler();" og gjør Build, får vi feilmelding fra kompilatoren
    }
}