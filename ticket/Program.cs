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
            decimal p = 0m;

            // Elaborazione
            do
            {
                Console.WriteLine("----------------------\nMenù Biglietteria:\nBambini(B)   : 6,50euro\nAnziani(A)   : 5,90 euro\nStudenti(S)  : 5,70 euro\nAltri(O)     : 8 euro\nResoconto(R) : Restituisce il prezzo finora da pagare\nFine(F)      : Termina il programma\n\nScegli unìopzione scrivendo la lettera presente tra parentesi...");
                sel = char.Parse(Console.ReadLine());
                switch (sel)
                {
                    case 'B':
                        Console.WriteLine("\nInserisci il numero di Bambini di cui desideri comprare il/i biglietto/i:");
                        n = int.Parse(Console.ReadLine());
                        tot += n;
                        p += n * 6.5m;
                        break;

                    case 'A':
                        Console.WriteLine("\nInserisci il numero di Anziani di cui desideri comprare il/i biglietto/i:");
                        n = int.Parse(Console.ReadLine());
                        tot += n;
                        p += n * 5.9m;
                        break;

                    case 'S':
                        Console.WriteLine("\nInserisci il numero di Studenti di cui desideri comprare il/i biglietto/i:");
                        n = int.Parse(Console.ReadLine());
                        tot += n;
                        p += n * 5.7m;
                        break;
                    
                    case 'O':
                        Console.WriteLine("\nInserisci il numero di Altri di cui desideri comprare il/i biglietto/i:");
                        n = int.Parse(Console.ReadLine());
                        tot += n;
                        p += n * 5.7m;
                        break;

                    case 'R':
                        Console.WriteLine($"\nIl Conto al momento ammonta a: {p} con {tot} biglietti");
                        break;

                    case 'F': 
                        Console.WriteLine($"\nIl Prezzo totale ammonta a {p} con {tot} biglietti");
                        break;

                    default:
                        Console.WriteLine("Non capisco il carattere che hai inserito, Ritenta:");
                        break;
                }
            } while (!(sel.Equals('F')));



        }// Fine Programma
    }
}
