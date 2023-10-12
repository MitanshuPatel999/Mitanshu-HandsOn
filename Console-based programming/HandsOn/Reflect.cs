using System;
using System.Reflection;

namespace Reflect{
    public class Program{
        public static void Main()
        {
            Assembly assembly = Assembly.LoadFrom("C:/Users/patelmi/HandsOn/bin/Debug/net7.0/HandsOn.dll");

             Type[] types = assembly.GetTypes();

            Console.WriteLine("Types in the assembly:");
            foreach (Type type in types)
            {
                Console.WriteLine(type.FullName);
            }

        }
    }
}