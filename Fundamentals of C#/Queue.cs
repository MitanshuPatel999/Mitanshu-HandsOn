using System;
using System.Collections.Generic;

class Program{
  static void Main(){
    Queue<string> strQ=new Queue<string>();
    strQ.Enqueue("Q");
    strQ.Enqueue("U");
    strQ.Enqueue("E");
    strQ.Enqueue("U");
    strQ.Enqueue("E");

    Console.WriteLine(strQ.Peek());
    Console.WriteLine("FIFO:");
    for(int i=0;i<2;i++){
      Console.WriteLine(strQ.Dequeue());   
      }
    Console.WriteLine(strQ.Count);   
  }
}