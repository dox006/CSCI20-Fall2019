//Dylan Cox
//October 9 2019
//Create a game of pig using random number generation
using System;
class MethodDemo
{
  static int doit ()
  {
    Random random = new Random(); //Creating a method for rolling the dice and displaying the end result
    int dice = random.Next(1, 7);
    Console.WriteLine(dice);
    return dice;
  }
  static int turn (int i) //Method for turn order
  {
    i = i + 1;
    return i;
  }
  public static void Main ()
  {
   int res;
   res = turn(0); //Determines we start at turn 0+1
   Console.WriteLine("You rolled a : ");
   doit();
   Console.WriteLine(res + "turns have passed");
   Console.WriteLine("Roll again? (y)es or (n)o");

  }
}
