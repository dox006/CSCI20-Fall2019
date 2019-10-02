//Dylan Cox
//9/26/19
//Use for loop to repeat string given number of times
using System;
namespace Loop
{
  class WhileLoop
  {
    public static void Main(string[]args)
    {
      int i;
      int age;
      Console.WriteLine("How many miles til Disneyland?");
      age = int.Parse(Console.ReadLine());
      for (i=1 ; i<=age ; i++) //define i, define i's end value, define i mutation
      {
        Console.WriteLine("Are we there yet?");
      }
    }
  }
}
