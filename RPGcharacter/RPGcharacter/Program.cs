using System;

namespace RPGcharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Rpgcharacter hero = new Rpgcharacter(999, 9999, "cloudstrife");
            Console.WriteLine(hero.name);
            Console.WriteLine(hero.str);
            Console.WriteLine(hero.hp);
            Console.WriteLine();
        }
        internal class Rpgcharacter
        {
            internal readonly string name;
            internal int str;
            internal int hp;
            internal Rpgcharacter(int hp, int str, string name)
            {
                this.hp = hp;
                this.str = str;
                this.name = "cloudstrife";

            }
        }
    }
}
