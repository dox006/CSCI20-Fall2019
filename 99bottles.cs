//Dylan Cox
//9/26/19
//Use for loop to repeat string given number of times
using System;
namespace Loop
{
  class ForLoop
  {
    public static void Main(string[]args)
    {
      int i;
      Console.WriteLine("How many lines do you want to sing?");
      int bottles=int.Parse(Console.ReadLine());
      for (i=1 ; i>=bottles ; i--) //define i, define i's end value, define i mutation, this time declining
      {
        Console.Write((bottles)+"bottles of beer on the wall"+(bottles)+"of beer, take one down pass it around");
      }
    }
  }
}
