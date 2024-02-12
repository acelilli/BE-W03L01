using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    internal class Piatto
    {
        //Tutte le proprietà del piatto
        public int NumMenu { get; set; }
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }

        // COSTRUTTORE
        public Piatto(int numMenu, string nome, decimal prezzo)
        {
            NumMenu = numMenu;
            Nome = nome;
            Prezzo = prezzo;
        }

        // Creazione del menù array utilizzando il costruttore
        public static Piatto[] Menu { get; } = new Piatto[]
    {
        new Piatto(1, "Coca Cola 150 ml", 2.50m),
        new Piatto(2, "Insalata di pollo", 5.20m),
        new Piatto(3, "Pizza Margherita", 10.00m),
        new Piatto(4, "Pizza 4 Formaggi", 12.50m),
        new Piatto(5, "Pz patatine fritte", 3.50m),
        new Piatto(6, "Insalata di riso", 8.00m),
        new Piatto(7, "Frutta di stagione", 5.00m),
        new Piatto(8, "Pizza fritta", 5.00m),
        new Piatto(9, "Piadina vegetariana", 6.00m),
        new Piatto(10, "Panino Hamburger", 7.90m)
    };

        // METODI:
        //1. 
    }
}
