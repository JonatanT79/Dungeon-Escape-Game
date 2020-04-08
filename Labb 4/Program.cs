using System;

namespace Labb_4
{
    class Program
    {

        static void Main(string[] args)
        {
            int oldhighscore = 100; // Highscore
            int score = 80;
            string answer;
            
            do
            {
                Console.WriteLine("Spelet går ut på att finna en väg ut på så få drag som möjligt");
                Console.WriteLine("Varje förflyttning eller fight kostar drag");
                Console.WriteLine("Skriv in ditt namn");

                Player.Name = Console.ReadLine();

                while (Player.Name.Length <= 0)
                {
                    Console.WriteLine("Du måste skriva in ett namn");
                    Player.Name = Console.ReadLine();
                }

                Console.WriteLine("");
                Console.WriteLine(Player.Name + ", nu är det dags att finna en väg ut...");
                Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                Console.ReadKey();
                Console.Clear();

                // metod för att förflytta objektet (Kartan visas)

                Move m = new Move();
                Console.WriteLine("Highscore: " + oldhighscore);
                m.intro();
                linedivide(); // LineDivide
                Move.InitGame(); // Metod för att visa gubben på kartan
                m.Movement(); // Metod för att röra gubben
                Console.SetCursorPosition(0, 24);
                Console.WriteLine("Du klarade på " + m.count + " Drag!");
                score = m.count; // sätter det nya highscoret == antalet drag man gjort

                if (score < oldhighscore) // kontrollerar om det nya highscoret är mindre än det gamla highscoret
                {
                    Console.SetCursorPosition(0, 25);
                    Console.WriteLine("Du fick ett nytt highscore!");
                    Console.SetCursorPosition(0, 0); // skriver ut det nya highscoret längst upp om det är mindre än det gamla
                    Console.WriteLine("Highscore: " + score + " ");
                    oldhighscore = score;
                }

                //Highscore
                //1. Johan 56
                //2.Sara 64
                //3.Tuva 66

                Console.SetCursorPosition(0, 27);
                Console.WriteLine("Vill du spela igen? Ja/Nej");
                answer = Console.ReadLine();
                do
                {

                    if (answer.ToUpper() != "JA" && answer.ToUpper() != "NEJ")
                    {
                        Console.ResetColor();
                        Console.WriteLine("Du måste skriva ja eller nej");
                        answer = Console.ReadLine();
                    }

                    if (answer.ToUpper() == "JA")
                    {
                        Föremål.yxa = 0;
                        Föremål.nyckel = 0;
                        Föremål.vapen = 0;
                        m.count = 0;
                        Console.Clear();
                        Console.ResetColor();
                    }
                    else if (answer.ToUpper() == "NEJ")
                    {

                    }

                } while (answer.ToUpper() != "JA" && answer.ToUpper() != "NEJ"); //gör detta så länge answer inte är JA eller NEJ

            } while (answer.ToUpper() == "JA"); // gör detta sålänge 'answer = "JA"'




        }
        public static void linedivide()
        {
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        }
    }
}

