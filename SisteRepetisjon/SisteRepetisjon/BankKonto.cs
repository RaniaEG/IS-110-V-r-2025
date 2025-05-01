using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisteRepetisjon
{
    internal class BankKonto
    {
        public readonly string kontoNummer;
        public decimal Saldo { get; set; } /// vi kan sette Saldo som private variabel (i klassen) 
        // Eller kan sette Saldo som readonly (i konstruktøren)
        // public Beløp TaUtPenger(decimal antall){   }
        // public Beløp SettInnPenger(decimal antall){     }

        public BankKonto(string kontonummer)
        {
            Saldo = 0;
            kontoNummer = kontonummer;
        }

        /* Hvis begge variablene har samme navn, for å unngå semantisk feil i programmet så bruker vi "this"
         * public BankKonto(string kontoNummer)
        {
            Saldo = 0;
            this.kontoNummer = kontoNummer;
        }

        // Det skal fungere greit siden Saldo som egenskap starter med stor bokstav 
        // og saldo som parameter starter med liten bokstav
        // Dette her er et eksempel på konstruktør overloading (samme signatur men forskjellig antall parametere
        public BankKonto(string kontoNummer, decimal saldo)
        {
            Saldo = saldo;
            this.kontoNummer = kontoNummer;
        }
         */

        public BankKonto(string kontoNummer, decimal saldo)
        {
            Saldo = saldo;
            this.kontoNummer = kontoNummer;
        }
    }
}
