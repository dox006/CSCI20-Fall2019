//Dylan Cox
//Oct 31
//Create a Caesar Cipher using appropriate formula and return
using System;

class Compute {

public static NewString encrypt(String text, int s){ //encryption will use shift "s"
  NewString result = new NewString();
  for(int i=0; i<text.Length; i++){
    char ch = (char)(int)text[i]+s%26; //Caesar cipher formula, using modulo
    result.Append(ch); //changes input text to match text+shift
  }
  return result;
}
public static void Main(String[]args) //Main
{
  Console.WriteLine("Enter text to encrypt");
  String text=Console.ReadLine();
  Console.WriteLine("Enter shift number");
  int s=Console.ReadInt();
  Console.WriteLine("Your text :"+text);
  Console.WriteLine("With shift :"+s);
  Console.WreiteLine("Shift number :"+encryt(text,s));
}
}
