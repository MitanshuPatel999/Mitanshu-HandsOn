using System;

namespace Casting
{
    public class Program
    {
        public static void Main()
        {
            int first = 2;
            string second = "3";

            Console.WriteLine(first + second + " //first is converted to string implicitly by compiler");

            int i = 3;
            Console.WriteLine($"int:{i}");
            decimal d = i;
            Console.WriteLine($"decimal:{d} //implicit casting");

            decimal de = 3.14m;
            int ide = (int)de;
            Console.WriteLine($"int:{ide} //explicit casting");

            decimal myDecimal = 1.23456789m;
            float myFloat = (float)myDecimal;

            Console.WriteLine($"Decimal: {myDecimal}");
            Console.WriteLine($"Float  : {myFloat} //narrowing conversion");

            string message = first.ToString() + second;
            Console.WriteLine(message + "// with ToString");

            string value1 = "5";
            string value2 = "7";
            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result + " with Convert class");

            int v1 = (int)1.5m; // casting truncates
            Console.WriteLine(v1);

            int v2 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(v2);

            string name = "5";
            Console.WriteLine(int.Parse(name));

            string n1 = "5.11";
            Console.WriteLine(decimal.Parse(n1));

            string name1 = "5";
            Console.WriteLine(int.TryParse(name1, out int r) + "//re turns bool for checking possibility of conversion");
        }
    }
}