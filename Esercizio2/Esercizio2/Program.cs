using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int scelta;

            // do
            // {
                // MENU 
                Console.WriteLine("==============MENU==============");
                Console.WriteLine("1: Coca Cola 150 ml (€ 2.50)");
                Console.WriteLine("2: Insalata di pollo (€ 5.20)");
                Console.WriteLine("3: Pizza Margherita (€ 10.00)");
                Console.WriteLine("4: Pizza 4 Formaggi (€ 12.50)");
                Console.WriteLine("5: Pz patatine fritte (€ 3.50)");
                Console.WriteLine("6: Insalata di riso (€ 8.00)");
                Console.WriteLine("7: Frutta di stagione (€ 5.00)");
                Console.WriteLine("8: Pizza fritta (€ 5.00)");
                Console.WriteLine("9: Piadina vegetariana (€ 6.00)");
                Console.WriteLine("10: Panino Hamburger (€ 7.90)");
                Console.WriteLine("11: Stampa conto finale e conferma");
                Console.WriteLine("========================================");
                // FINE MENU
                // Legge l'input dell'utente
               // string input = Console.ReadLine(); // valore dell'input
                
              //  if (int.TryParse(input, out scelta)) // parse di input -> scelta
               /* {
                    switch (scelta)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:

                            break;
                        case 11:

                        default:
                            Console.WriteLine("Scelta non valida.");
                            break;
                    }
                   } else
                    {
                        Console.WriteLine("Input non valido. Inserisci un numero!");
                    }
                } while (" "); // Continua fino a stop
        }
    }
}
