using System;

namespace WhileDoWhile
{
    public class Program
    {
        public static void Main()
        {
            int i = 5, hero = 10, monster = 10, roll;
            while (i > 0)
            {
                Console.Write("##");
                i--;
            }
            i = 5;
            Console.Write(" HERO VS MONSTER \n");
            while (i > 0)
            {
                Console.Write("##");
                i--;
            }
            Console.ReadLine();

            Random dice = new Random();
            do
            {
                roll = dice.Next(1, 7);
                monster -= roll;
                Console.WriteLine($"Monster was damaged {roll} hp and now has {monster} hp health !!!");
                Console.WriteLine("\n--------------------\n");
                roll = dice.Next(0, 7);
                hero -= roll;
                Console.WriteLine($"Hero was damaged {roll} hp and now has {hero} hp health !!!");
                Console.ReadLine();
            } while (hero > 0 && monster > 0);

            Console.WriteLine(hero>monster? "Hero wins!!!":"Monster wins!!!");
        }
    }
}