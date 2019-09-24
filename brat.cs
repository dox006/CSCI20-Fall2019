//Dylan Cox
//9/24/19
//Use while loop to repeat string given number of times
using System;
namespace Loop
{
  class WhileLoop
  {
    public static void Main(string[]args)
    {
      int i=1 //Starts the count at 1
      int age=int.Parse(Console.ReadLine("How old is your child?"))
      while (i<=age) //Will not go past the given age number
      {
        Console.WriteLine("Are we there yet?");
        i++;
      }
    }
  }
}
