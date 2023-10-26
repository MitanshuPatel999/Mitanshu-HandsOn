using System;

namespace Switch
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter Stock Keeping Unit in type-color-size format");
            string sku = Console.ReadLine();
            string[] product = sku.Split("-");
            string t = "", c = "", s = "";

            switch (product[0])
            {
                case "01":
                    t = "Sweat-Shirt";
                    break;
                case "02":
                    t = "T-Shirt";
                    break;
                case "03":
                    t = "Sweat-Pant";
                    break;
                default:
                    t = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    c = "Black";
                    break;
                case "RD":
                    c = "Red";
                    break;
                case "DB":
                    c = "Dark-Blue";
                    break;
                default:
                    c = "White";
                    break;
            }

            switch (product[2])
            {
                case "S":
                    s = "Small";
                    break;
                case "M":
                    s = "Medium";
                    break;
                case "L":
                    s = "Large";
                    break;
                default:
                    s = "Universal";
                    break;
            }

            Console.WriteLine($"{t} {c} {s}");
        }
    }
}