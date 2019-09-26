//Dylan Cox
//9/26/19
//Use nested for loops to reproduce Pascal's Triangle
using System;
namespace Loop
{
  class ForLoop
  {
    public static void Main(string[]args)
    {
      int i, val=1, bank, j;
      int rows=int.Parse(Console.ReadLine("Declare number of rows"));
      for (i=0; i<rows; i++){ //declares how many rows the triangle will have
        for (blank=1; blank<=rows-i; blank++)
          Console.Write("");
        for(j=0; j<=i; j++){ //declares the values printed inside the triangle
          if (j==0||i==0)
            val=1;
          else
            val=val*(i-j+1)/j;
          Console.Write(val+"");
          Console.WriteLine();
        }
      }
    }
  }
}
