using System;

namespace CoinFlip{
    public class Program{
        public static void Main()
        {
            Random coin =new Random();
            int flip=coin.Next(0,2);
            int amount=9;
            Console.WriteLine(flip);
            Console.WriteLine((flip==0)?"heads":"tails");
            int value=amount>=10?10:20;
            Console.WriteLine(value);
        }
    }
}