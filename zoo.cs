//Dylan Cox
//Nov 12
//The Boston Zoo keeps track of information for every animal that is kept there. For each animal, they store its name, species, age, breakfast hour, and dinner hour (if they don't get fed twice a day, they try to eat the visitors...) using structures
using System;
  enum AnimalType
  {
    Mammal,
    Bird,
    Reptile
  };
  struct Animal
  {
    public string Name;
    public string Species;
    public int Age;
    public int BreakfastHour;
    public int DinnerHour;
  }
  struct Keeper
  {
    public string KeeperName;
    public Animal Type;
  }
  class MainClass {
  public void PrintAnimal (Animal Lion){
    Console.WriteLine("Name: "+Lion.Name);
    Console.WriteLine("Age: "+Lion.Age);
    Console.WriteLine("Breakfast Hour: "+Lion.BreakfastHour);
    Console.WriteLine("Dinner Hour: "+Lion.DinnerHour);
  }

  public static void Main ()
  {
    Animal Lion;
    Lion.Name = "Fred";
    Lion.Age = 29;
    Lion.BreakfastHour = 1700;
    Lion.DinnerHour = 2100;
    }
  }
