using System;

public class Program
{
    static void Main()
    {
      Console.WriteLine("Total Memory cp_1:"+ GC.GetTotalMemory(false));
      
      for(int i=0;i<100;i++){
        var obj =new Program();
      }
      
      Console.WriteLine("The number of generations are: "+ GC.MaxGeneration);   
      
      GC.Collect(2);
      Console.WriteLine("Garbage Collection in Generation 0 is: "+ GC.CollectionCount(2));
      
      Console.WriteLine("Total Memory cp_2:"+ GC.GetTotalMemory(false));
      Console.WriteLine("Total Memory cp_3:"+ GC.GetTotalMemory(true));
    }
}
