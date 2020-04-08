using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_4
{
    // *** plus antal drag beroende på vilket monster man stöter på, ta bort attack och hp ***
    public interface Monster // interface
    {
        string Name { get; set; }

        int Attack { get; set; }

        int Hp { get; set; }

        void skriv();
    }
    class Slime : Monster
    {
        public string Name { get; set; }

        public int Attack { get; set; }

        public int Hp { get; set; }

        public void skriv()
        {
            Name = "Slime";
            Attack = 2;
            Hp = 6;
            Console.WriteLine("En " + Name + " kommer fram till dig med " + Attack + " Attack och " + Hp + " Liv");
        }
    }
    class Varg : Monster
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Hp { get; set; }

        public void skriv()
        {
            Name = "Varg";
            Attack = 3;
            Hp = 4;
            Console.WriteLine("En " + Name + " kommer fram till dig med " + Attack + " Attack och " + Hp + " Liv");
        }
    }
}

