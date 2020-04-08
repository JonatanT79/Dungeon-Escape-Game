using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_4
{
    public abstract class Stats // Abstrakt klass
    {
        public virtual void Pstats() {
            Console.WriteLine("tja");
        }
        public void hej()
        {
            Console.WriteLine("tja");
        }
    }

    class Player : Stats // en klass för spelaren
    {
        public static string Name { get; set; }

        public List<Föremål> inventory = new List<Föremål>(); // skapa en list med alla Föremål klassens medlemmar (egenskaper, variablar)
        
        public override void Pstats() // Metod för att skriva ut statsen för spelaren
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Namn: " + Name);
            Console.ResetColor();
        }
        public void Openinventory()
        {
            foreach (Föremål f in inventory) // för varje item som har lagts till i inventoryt, gör det här:  (man kan säga f = item, foreach item in inventory gör det här:)
            {
                if (Föremål.yxa >= 1) // kollar om man har tagit upp en yxa,
                {
                    Console.SetCursorPosition(77, 15);
                    Console.WriteLine("- Yxa");
                }

                if (Föremål.nyckel >= 1)
                {
                    Console.SetCursorPosition(77, 15);
                    Console.WriteLine("- Nyckel");
                }
                if (Föremål.vapen >= 1)
                {
                    Console.SetCursorPosition(77, 16);
                    Console.WriteLine("- Knallpulver");
                }


            }

        }
    }
}