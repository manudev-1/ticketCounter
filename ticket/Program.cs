using System;

namespace ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Modello Dati
            char sel;
            int n, tot = 0;
            decimal p = 0m, prezzo_unitario = 0m;
            const decimal BAMBINI=6.5m;
            const decimal ANZIANI=5.9m;
            const decimal STUDENTI=5.7m;
            const decimal ALTRI=8m;
            // Elaborazione
            do
            {
                Console.WriteLine("----------------------\nMenù Biglietteria:\nBambini(B)   : 6,50euro\nAnziani(A)   : 5,90 euro\nStudenti(S)  : 5,70 euro\nAltri(O)     : 8 euro\nResoconto(R) : Restituisce il prezzo finora da pagare\nFine(F)      : Termina il programma\n\nScegli unìopzione scrivendo la lettera presente tra parentesi...");
                sel = char.Parse(Console.ReadLine());
                sel = char.ToUpper(sel);
                switch (sel)
                {
                    case 'B': prezzo_unitario = BAMBINI; break;
                    case 'A': prezzo_unitario = ANZIANI; break;
                    case 'S': prezzo_unitario = STUDENTI; break;
                    case 'O': prezzo_unitario = ALTRI; break;

                    case 'R':
                        Console.WriteLine($"\nIl Conto al momento ammonta a: {p:N2} con {tot} biglietti");
                        break;

                    case 'F': 
                        Console.WriteLine($"\nIl Prezzo totale ammonta a {p:N2} con {tot} biglietti");
                        break;

                    default:
                        Console.WriteLine("Non capisco il carattere che hai inserito, Ritenta:");
                        break;
                }
                while (sel.Equals('B') || sel.Equals('A') || sel.Equals('S') || sel.Equals('O'))
                {
                    Console.WriteLine($"\nInserisci il numero di {sel} di cui desideri comprare il/i biglietto/i:");
                    n = int.Parse(Console.ReadLine());
                    tot += n;
                    p += n * prezzo_unitario;
                    break;
                }
            } while (!(sel.Equals('F')));



        }// Fine Programma
    }
}
