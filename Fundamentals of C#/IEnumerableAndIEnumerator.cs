using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
      List<int> nums= new List<int>(){1,2,3,4,5,6,7,8,9,10};

      IEnumerator<int> enumr=nums.GetEnumerator();

      while(enumr.MoveNext()){
        Console.WriteLine(enumr.Current);
      }

        Console.WriteLine(GC.GetTotalMemory(false));
        
    }
}
