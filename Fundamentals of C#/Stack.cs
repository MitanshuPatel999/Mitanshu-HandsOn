using System;
using System.Collections.Generic;

class Program{
  static void Main(){
    Stack<int> numStack=new Stack<int>();
    numStack.Push(10);
    numStack.Push(20);
    numStack.Push(30);
    numStack.Push(40);
    numStack.Push(50);

    Console.WriteLine(numStack.Peek());
    Console.WriteLine("LIFO:");
    
    

    for(int i=0;i<3;i++){
      Console.WriteLine(numStack.Pop());   
      }
    numStack.Push(60);
    Console.WriteLine(numStack.Count);   

  }
}