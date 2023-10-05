using System;
using System.Collections;

class Program{
  static void Main(){
    Hashtable HT=new Hashtable();
    HT["A"]=1;
    HT["B"]=2;
    HT["C"]=3;
    HT["D"]=4;
    HT[1]="E";
    HT[1.2]=true;


    foreach(var key in HT.Keys){
      Console.WriteLine($"{key}:{HT[key]}");
    }
   
  }
}