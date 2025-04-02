
using System.Reflection.Metadata.Ecma335;

int a = 10;
int b = 0;
int c;

try // try skal alltid kjøres
{
    // Inn i try-blokken legger vi koden som vi vil sjekke om den skal kjøre med eller uten feil
    c = a / b; // Dere kan prøve å gjøre det med IF-betingelse og throw new exception som her:https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/creating-and-throwing-exceptions
}

catch (Exception ex)  // catch skal kun kjøres når det er feil
{
    // melding som er skrevet av utvikleren
    Console.WriteLine("Du kan ikke gjøre divisjon med null!");

    // melding som kommer fra System.Exception klasse
    Console.WriteLine($"Feilmelding: {ex.Message}");
}

finally  // finally skal kjøres uansett det feil eller ikke
{
    Console.WriteLine("Programmet stopper nå!");
}


// En try og to catch
string[] navn = new string[3];
navn[0] = "Anna";
navn[1] = null;
navn[2] = "Ola";

try
{
    for (int i = 0; i <= navn.Length; i++)
    {
        // IF-en gjorde at løkken fortsetter til å kjøre og da kunne vi oppdage IndexOutOfRangeException
        if (navn[i] == null)
        {
            Console.WriteLine("Du kan ikke ha null verdi i arrayen");
        }
        else
        {
            Console.WriteLine(navn[i].ToUpper());
        }
        
    }


}

// Husk at catch blokkene kjøres ikke nødvendigvis samtidig!
catch (NullReferenceException ex)
{
    Console.WriteLine($"Feilmelding: {ex.Message}");
}

catch(IndexOutOfRangeException ex)
{
    Console.WriteLine($"Feilmelding: {ex.Message}");
}











































