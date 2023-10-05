using System;

namespace MyApplication{
  
  class Program
  {
    static void Main (string[] args) 
    {
      Vehicle myVehicle= new Vehicle();
      myVehicle.Type="Car";
      myVehicle.Year=2023;
      myVehicle.Seats=5;
      myVehicle.Start();
      
      Vehicle[] varr=new Vehicle[3];
      varr[0]=new Vehicle(); //Constructor overloading
      varr[1]=new Vehicle("Bus"); //Constructor overloading with one parameter
      varr[2]=new Vehicle("Bus",Seats:30,Year:2022); //Constructor overloading with multiple and jumbled parameters
      Console.WriteLine(varr[2].Year);
  
      Vehicle yamaha=new TwoWheeler();
      yamaha.Start();
      
      GC.Collect(0);
      Console.WriteLine("Garbage Collection in Generation 0 is: "+ GC.CollectionCount(0));
      Program obj = new Program();
      Console.WriteLine("The generation number of object obj is: "+ GC.GetGeneration(obj));
      Console.WriteLine("Total memory before garbage collection:"+ GC.GetTotalMemory(false));
    } 
  }

// Parent class
  public class Vehicle {
      public string Type{ get; set;}
      public int Year{ get; set;}
      public int Seats;

      public void SetSeats(int Seats){
        if(Seats>0)
          this.Seats=Seats;
      }

      public int GetSeats(){
        return Seats;
      }

      public Vehicle(){
        Console.WriteLine("Parameterless Constructor!");
      }

      public Vehicle(string Type){
        Console.WriteLine(Type+" initialized!");
      }
      
      ~Vehicle(){
      	Console.WriteLine("Destructor called!");
      }
    
      public Vehicle(string Type,int Year,int Seats){
        this.Type=Type;
        this.Year=Year;
        this.Seats=Seats;        
      }
    
      public virtual void Start(){
        Console.WriteLine("Starting Vehicle");
      }   
    }
  
  // Child class
  public class TwoWheeler : Vehicle{
    public TwoWheeler(){
      Console.WriteLine("Constructor of TwoWheeler !");
    }
    public override void Start(){//overriding parent method
      Console.WriteLine("Starting TwoWheeler!");
    }  
  }
}