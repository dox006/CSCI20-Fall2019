//Dylan Cox
//Oct 31
//Use formula to determine windchill with functions and returns
using System;

class Compute {

public static double WindChill(double t, double v){
  WindChill result = new WindChill();
  (35.74+0.6215*(t)-35.75*(v**0.16)+0.4275*(t)*(v**0.16))/t;
  return result //finding only WindChill, formula adapted to get variable alone on one side
}
public static double OldChill(double t, double v){
  OldChill result = new OldChill();
  (0.0817*(3.71*(v**0.5)+5.81-0.25*(v)*(t-91.4)+91.4));
  return result
}
public static void Main(string[]args)
{
  Console.WriteLine("Enter temperature in Fahrenheit");
  double t=Console.ReadLine();
  Console.WriteLine("Enter wind speed in MPH");
  double v=Console.ReadLine();
  Console.WriteLine("Wind chill is"+WindChill);
  Console.WriteLine("Wind chill with old formula is"+OldChill);
}
}
