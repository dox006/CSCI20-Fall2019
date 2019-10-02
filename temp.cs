//Dylan Cox
//Sep 10 2019
//Converting input Fahrenheit temp to Celsius and Kelvin

using System;
class MainClass {
  public static void Main (string[] args)
  {

  Console.WriteLine("Enter a temperature in Fahrenheit");
  double F_temp=double.Parse(Console.ReadLine());
  double C=(F_temp-32)*(5/9);
  double K=(F_temp-32)*(5/9)+273.15;
  Console.WriteLine("The temperature in Fahrenheit you entered was"+F_temp+"which comes to"+C+"in Celsius, and"+K+"in Kelvin");
  }
}
