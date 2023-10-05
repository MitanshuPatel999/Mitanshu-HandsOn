namespace MyNamespace
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        internal static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

      public static int Sub(int a, int b)
        {
            return a - b;
        }

      public static int Mul(int a, int b)
        {
            return a * b;
        }

      public static int Div(int a, int b)
        {
            return a / b;
        }
    }
}
