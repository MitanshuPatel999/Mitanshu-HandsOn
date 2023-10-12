using System;
using System.Collections.Generic;


namespace IComparable{
  public class Person
  {
    public string name{get;set;}=null!;
    public int age{get;set;}
    public int weight{get;set;}
  }

  public class AgeComparer: IComparer<Person>
  {
    public int Compare(Person x,Person y)
    {
      return x.age-y.age;
    }
  }

  public class Program
  {
    public static void Main()
    {
      List<Person> people=new List<Person>{
        new Person{name="aaa",age=28,weight=70},
        new Person{name="aab",age=20,weight=60},
        new Person{name="aac",age=22,weight=65},
        new Person{name="aad",age=18,weight=55},
        new Person{name="aae",age=33,weight=68}
      };
      people.Sort(new AgeComparer());

      foreach(var i in people)
      {
        Console.WriteLine($"{i.name} is {i.age} years old having weight {i.weight}KG.");
      }
    }
  }
}
