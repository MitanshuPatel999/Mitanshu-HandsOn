using System;

namespace Enums{
  public class Program
  {
    enum Days{Monday,Tuesday,Wednesday,Thursday,Friday,Saturday};
    public static void Main()
    {
      int wstart=(int)Days.Monday;
      int wend=(int)Days.Friday;

      Console.WriteLine($"Monday:{wstart}");
      Console.WriteLine($"Monday:{wend}");
      
      Console.ReadKey();

    }
  }
}
