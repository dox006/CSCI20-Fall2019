//Dylan Cox
//October 17 2019
//Write a menu function that calls another function
using System;
class MethodDemo
{
  static int doit ()
  {
    Console.WriteLine("You have ordered fish");
  }

  public static void Main ()
  {
   Console.WriteLine("Select an item to order, 1 for fish");
   int choice;
   choice=Console.Read();
   if(choice=='1')
   {
     doit();
   }

  }
}
