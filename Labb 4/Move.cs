using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_4
{
    class Move
    {
        Player p = new Player(); // skapar en instansvariabel för att få tillgång till Player klassens inventory
        Föremål item = new Föremål(); // skapar en instansvariabel för att spara värdet på alla föremål(int)
        public static Coordinate Hero { get; set; } // Egenskap med namnet Hero
        public int count = 0;  // räknar antal drag

        public static void Karta() // Kartmetod
        {
            string[,] karta = // 2D Array
        {
           { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#"},
           {"#", ".", ".", ".", ".", "#", ".", ".", ".", ".", "#", ".", ".", ".", "#"},
           {"#", ".", ".", "#", "#", "#", "#", "#", ".", ".", "#", ".", "#", "#", "#"},
           {"#", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#"},
           {"#", "#", "#", "#", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#"},
           {"#", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#"},
           {"#", ".", ".", "#", ".", ".", ".", "#", ".", ".", ".", ".", "#", ".", "#"},
           {"#", "#", "#", "#", ".", ".", ".", "#", ".", ".", ".", "#", "#", "#", "#"},
           {"#", ".", ".", ".", ".", ".", ".", "#", ".", ".", ".", ".", ".", ".", "#"},
           {"#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#"}
        };

            Console.SetCursorPosition(52, 0); // SetCursorPosition sätter positionen för cursorn
            Console.WriteLine("HÄR ÄR DIN KARTA:");
            int h = 2;
            int b = 53;
            // loopar igenom 2D Arrayen (Kartan)
            for (int i = 0; i <= karta.GetUpperBound(0); i++) // GetUpperBound får värdet av antalet rader i 2D arrayen - i detta fall 10 (från rad 0 till 9)
            {
                Console.SetCursorPosition(b, h); // börjar från den koordinaten

                h++; // ökar h med 1 --> skriver ut på nästa rad --> just för att det är en array behövs 'h++'
                string s1 = karta[i, 0]; // i = 0, skriver ut tecknet på [0,0], i = 1, skriver ut tecknet på [1,0] osv.
                string s2 = karta[i, 1];
                string s3 = karta[i, 2];
                string s4 = karta[i, 3];
                string s5 = karta[i, 4];
                string s6 = karta[i, 5];
                string s7 = karta[i, 6];
                string s8 = karta[i, 7];
                string s9 = karta[i, 8];
                string s10 = karta[i, 9];
                string s11 = karta[i, 10];
                string s12 = karta[i, 11];
                string s13 = karta[i, 12];
                string s14 = karta[i, 13];
                string s15 = karta[i, 14];

                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}", s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15); // {0} får s1 värdet, {1} får s2 värdet osv

                Console.SetCursorPosition(54, 8);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Rutor.N); // skriver ut enum på den koordinaten från Föremål klassen 
                Console.ResetColor();

                Console.SetCursorPosition(56, 7);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Rutor.D);
                Console.ResetColor();

                Console.SetCursorPosition(66, 8);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(Rutor.Y);
                Console.ResetColor();

                Console.SetCursorPosition(64, 4);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(Rutor.U);
                Console.ResetColor();

                Console.SetCursorPosition(64, 5);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(Rutor.M);
                Console.ResetColor();

                Console.SetCursorPosition(57, 3);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(Rutor.V);
                Console.ResetColor();

                Console.SetCursorPosition(59, 3);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(Rutor.V);
                Console.ResetColor();

                Console.SetCursorPosition(66, 10);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(Rutor.V);
                Console.ResetColor();
            }
        }
        public void intro()
        {
            Karta(); // en metod i en metod
            Console.SetCursorPosition(0, 2);
            p.Pstats(); // Anropar spelar metoden med referensvariablen 'p'

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 14); // Börja från att skriva ut från den positionen och skriv andra meningar på nästa rad
            Console.Write("'@'");
            Console.ResetColor();
            Console.WriteLine("är din Karaktär.");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("'U'");
            Console.ResetColor();
            Console.WriteLine("är Utgången för att vinna spelet.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("'N'");
            Console.ResetColor();
            Console.WriteLine("är Nyckeln för att låsa upp Utgången.");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("'D'");
            Console.ResetColor();
            Console.WriteLine("är en Dörr.");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("'Y'");
            Console.ResetColor();
            Console.WriteLine("är en Yxa för att ta sönder Dörren.");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("'M'");
            Console.ResetColor();
            Console.WriteLine("är ett Monster");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("'V'");
            Console.ResetColor();
            Console.WriteLine("är ett vapen för att använda mot Monstret");

            Console.Write("'#'");
            Console.ResetColor();
            Console.WriteLine("är en Vägg.");

            Console.WriteLine("- Använd pilarna för att börja röra på din karaktär...");
        }
        public void Movement()
        {
            //Move command

            ConsoleKeyInfo keyInfo;

            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape && Föremål.nyckel != 2) // loopa igenom gå-kommandot så länge villkoret är true
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:

                        MoveHero(0, -1); // anropar metoden och minskar y koordinaten med 1
                        Console.SetCursorPosition(77, 14);
                        Console.WriteLine("Dessa saker har du i ditt inventory:");
                        if (Hero.x == 55 && Hero.y == 7) // ger en yxa för att kunna gå ut genom dörren efter man har plockat upp nyckeln
                        {
                            Föremål.yxa++;
                        }
                        if (Hero.x == 64 && Hero.y == 4) // koordinat för utgång
                        {
                            if (Föremål.nyckel >= 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition(70, 19);
                                Console.WriteLine("Du använde din nyckel för att låsa upp utgångnen!");
                                Console.ResetColor();
                                Console.SetCursorPosition(70, 20);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Du vann spelet!!!                                "); // tar bort texten "yxan togs bort från ditt inventory"
                                Console.SetCursorPosition(0, 22);
                                Console.WriteLine("Tryck på valfri tangent för att fortsätta...           ");
                                Console.SetCursorPosition(77, 15);
                                Console.WriteLine("            "); // tar bort nyckeln texten
                                Föremål.nyckel++; // gör så att item.nyckel == 2, gå ut ur loopen (undvika error ifall man råkade ta upp nyckeln i rummet igen)
                            }
                        }
                        count++;
                        Console.SetCursorPosition(0, 6);
                        Console.WriteLine("Antal drag gjorda: " + count);
                        break;

                    case ConsoleKey.RightArrow:

                        MoveHero(1, 0); // anropar metoden och ökar x koordinaten med 1
                        Console.SetCursorPosition(77, 14);
                        Console.WriteLine("Dessa saker har du i ditt inventory:");
                        if (Hero.x == 55 && Hero.y == 7) // ger en yxa för att kunna gå ut genom dörren efter man har plockat upp nyckeln
                        {
                            Föremål.yxa++;
                        }
                        if (Hero.x == 57 && Hero.y == 3) // koordinat för vapen
                        {
                            Föremål.vapen++;
                            p.inventory.Add(item);
                            p.Openinventory();
                        }
                        if (Hero.x == 66 && Hero.y == 10) // koordinat för vapen
                        {
                            Föremål.vapen++;
                            p.inventory.Add(item);
                            p.Openinventory();
                        }
                        count++;
                        Console.SetCursorPosition(0, 6);
                        Console.WriteLine("Antal drag gjorda: " + count);
                        break;

                    case ConsoleKey.DownArrow:

                        MoveHero(0, 1);
                        Console.SetCursorPosition(77, 14);
                        Console.WriteLine("Dessa saker har du i ditt inventory:");
                        if (Hero.x == 66 && Hero.y == 8) // koordinat för yxa
                        {
                            Föremål.yxa++; ; // öka yxa (int) med 1.
                            p.inventory.Add(item); // lägger till ett item i Player inventory
                            p.Openinventory(); // anropar metoden (metod i en metod)
                        }

                        if (Hero.x == 54 && Hero.y == 8) // koordinat för nyckel
                        {
                            Föremål.nyckel++; // öka nyckel(int) med 1
                            p.inventory.Add(item); // lägger till ett item i inventory när man tar upp nyckeln
                            p.Openinventory();
                        }
                        count++;
                        Console.SetCursorPosition(0, 6);
                        Console.WriteLine("Antal drag gjorda: " + count);
                        break;

                    case ConsoleKey.LeftArrow:

                        MoveHero(-1, 0);
                        Console.SetCursorPosition(77, 14);
                        Console.WriteLine("Dessa saker har du i ditt inventory:");
                        if (Hero.x == 54 && Hero.y == 8) // koordinat för nyckel
                        {
                            Föremål.nyckel++;
                            p.inventory.Add(item);
                            p.Openinventory();
                        }
                        if (Hero.x == 59 && Hero.y == 3) // koordinat för vapen
                        {
                            Föremål.vapen++;
                            p.inventory.Add(item);
                            p.Openinventory();
                        }

                        if (Hero.x == 56 && Hero.y == 7) // koordinat för dörrren
                        {
                            if (Föremål.yxa > 0) // om man har tagit upp en yxa så att det blir 1, gör det här;
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition(73, 19);
                                Console.WriteLine("Du använde din Yxa för att slå sönder dörren!");
                                Console.SetCursorPosition(73, 20);
                                Console.WriteLine("- Yxan togs bort från ditt inventory");
                                Console.ResetColor();
                                p.inventory.Remove(item); // ta bort ett item från inventory
                                Föremål.yxa--; // minska yxa med 1 då man tar bort den när man går genom dörren
                                Console.SetCursorPosition(77, 15);
                                Console.WriteLine("            "); // suddar bort 'yxa' texten och skriv ut på samma ställe vid den koordinaten
                            }
                        }
                        count++;
                        Console.SetCursorPosition(0, 6);
                        Console.WriteLine("Antal drag gjorda: " + count);
                        break;
                }
            }
        }
        static void MoveHero(int x, int y)
        {
            Coordinate newHero = new Coordinate()
            {
                x = Hero.x + x, // om x är 1 och y är 0 --> 1 = Hero.x(Gubbens startposition) + 1, gubben gick höger
                y = Hero.y + y
            };

            if (CanMove(newHero))
            {
                RemoveHero(); // anropar metoden som tar bort det föregående tecknet efter förflyttning

                Console.SetCursorPosition(newHero.x, newHero.y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("@"); // skriv ut tecknet på gubben
                Console.ResetColor();
                Hero = newHero; // Hero = newHero
            }
        }
        static void RemoveHero()
        {
            Console.SetCursorPosition(Hero.x, Hero.y); // skriver ut en punkt i gubbens nuvarande position
            Console.Write("."); // suddar bort det gamla '@' och skriver ut en punkt på kartan
        }
        static bool CanMove(Coordinate c) // om klassen elr metoden är statisk måste alla medlemmar också vara statiskta. 
                                          // Man kan ha statiska medlemmar i en icke statisk klass/metod
                                          // Collison detection för vägg
        {
            if (c.x < 54 || c.x > 66 || (c.x == 54 && c.y == 6) || (c.x == 55 && c.y == 6) || (c.x == 56 && c.y == 6))
            {
                return false;
            }
            if (c.y < 3 || c.y >= 11 || (c.x == 54 && c.y == 9) || (c.x == 55 && c.y == 9) || (c.x == 56 && c.y == 9) || (c.x == 56 && c.y == 8))
            {
                return false;
            }
            if ((c.x == 60 && c.y == 10) || (c.x == 60 && c.y == 9) || (c.x == 60 && c.y == 8))
            {
                return false;
            }
            if ((c.x == 58 && c.y == 3) || (c.x == 58 && c.y == 4) || (c.x == 57 && c.y == 4) || (c.x == 56 && c.y == 4) || (c.x == 59 && c.y == 4) || (c.x == 60 && c.y == 4))
            {
                return false;
            }
            if ((c.x == 63 && c.y == 4) || (c.x == 65 && c.y == 4) || (c.x == 66 && c.y == 4) || (c.x == 63 && c.y == 3))
            {
                return false;
            }
            if ((c.x == 66 && c.y == 9) || (c.x == 65 && c.y == 9) || (c.x == 64 && c.y == 9) || (c.x == 65 && c.y == 8))
            {
                return false;
            }
            if (c.x == 56 && c.y == 7) // Koordinat dörr
            {
                if (Föremål.yxa < 1) // Kollar om man har tagit upp en yxa, då kan man gå genom dörren
                {
                    Console.SetCursorPosition(72, 5);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Du kan inte gå genom dörren utan en Yxa...");
                    Console.ResetColor();
                    return false;
                }
                else
                {
                    Console.SetCursorPosition(72, 5);
                    Console.WriteLine("                                          "); // suddar bort 'du kan inte gå genom...
                }
            }
            if (c.x == 64 && c.y == 4) // Koordinat Utgång
            {
                if (Föremål.nyckel != 1) // Kollar om man har tagit upp en nyckel, då kan man gå genom Utgången
                {
                    Console.SetCursorPosition(72, 6);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Du kan inte gå genom Utgången utan en Nyckel...");
                    Console.ResetColor();
                    return false;
                }
                else
                {
                    Console.SetCursorPosition(72, 6);
                    Console.WriteLine("                                                "); // suddar bort 'du kan inte gå genom...
                    return true;
                }
            }
            if (c.x == 64 && c.y == 5) // Koordinat Monster
            {
                if (Föremål.vapen < 1) // Kollar om man har vapen för att ta sig förbi monster
                {
                    Console.SetCursorPosition(72, 7);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Du behöver något vapen för att ta dig förbi");
                    Console.ResetColor();
                    return false;
                }
                else
                {
                    Console.SetCursorPosition(72, 7);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Du skrämde bort Monstret med knallpulvret...");
                    Console.ResetColor();
                }
            }
            return true;
        }
        public static void InitGame()
        {
            Hero = new Coordinate() // Hero namnet är en instansobject till classen coordinate
            {
                x = 54, //  gubbens startposition, ger värdet på egenskaperna x och y i coordinate klassen
                y = 10
            };
            MoveHero(0, 0); // en del av startpositionen, sätt alltid 0,0 för att gubben ska utgå från startpositionen vid koordinaten ovanför ^^
        }
    }
    class Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }
    }

}