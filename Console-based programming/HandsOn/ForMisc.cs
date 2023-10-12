using System;
using System.Globalization;

namespace ForMisc{
    public class Program{
        public static void Main(){
            for(int i=10,j=10;i>5&&j<15;i--,j+=2){
                Console.WriteLine($"{i}<=====>{j}");
            }
        }
    }
}