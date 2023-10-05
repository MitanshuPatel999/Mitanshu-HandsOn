using System;
using System.Collections;

class Program{
  static void Main(){
    ArrayList mixedL=new ArrayList();
    mixedL.Add("hello");
    mixedL.Add(10);
    mixedL.Add(1661.112);
    mixedL.Add(true);
    mixedL.Add(new int[]{1,2,3,4,5});

    foreach(var i in mixedL){
      Console.WriteLine(i);
    }
    Console.WriteLine(((int[])mixedL[4])[0]);

  }
}