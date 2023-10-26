using System;

namespace WwArray
{
    public class Program
    {
        public static void Main()
        {
            string[] arr = { "h3", "h1", "b2", "a1", "d4", "a2", "a4" };
            Console.WriteLine("\nCurrent array ------>");

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            Array.Sort(arr);
            Console.WriteLine("\nSorted array ------>");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            Array.Reverse(arr);
            Console.WriteLine("\nReversed array ------>");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Array.Clear(arr, 2, 2);
            Console.WriteLine("Length" + arr.Length);
            foreach (var i in arr)
            {
                Console.WriteLine("->" + i);
            }
            Console.WriteLine();

            Array.Resize(ref arr, 9);
            arr[7] = "x0";
            arr[8] = "z0";
            foreach (var i in arr)
            {
                Console.WriteLine("->" + i);
            }
            Console.WriteLine();

            string value = "abc123";
            char[] varr = value.ToCharArray();
            Array.Reverse(varr);
            string r2 = new string(varr);
            Console.WriteLine(r2);
            string r3 = String.Join("-----", varr);
            Console.WriteLine(r3);
            string[] items = r3.Split("-----");
            foreach (string item in items)
            {
                Console.Write(item);
            }

            int[][] numj = new int[3][];
            numj[0] = new int[] { 1, 2, 3 };
            numj[1] = new int[] { 4, 5 };
            numj[2] = new int[] { 6, 7, 8, 9 };

            Console.WriteLine();

            for (int i = 0; i < numj.Length; i++)
            {
                for (int j = 0; j < numj[i].Length; j++)
                {
                    Console.Write($"[{numj[i][j]}]");
                }
                Console.WriteLine();
            }

            int[,] num = new int[3,3]{{1,2,3},{4,5,6},{7,8,9}};

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{num[i,j]}]");
                }
                Console.WriteLine();

            }
        }
    }
}