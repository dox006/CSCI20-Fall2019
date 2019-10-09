//Dylan Cox
//Oct 8 2019
//Using file input/output to read info from a file and print it in the console
using System;
using System.IO;
class FileWriteDemo
{
 public static void Main()
 {
   string path;
   path = @"C:\\Users\\Dilbutt\\Downloads\\songs\\names.txt"; //define exact file location
StreamReader reader = new StreamReader(path); //open new reader stream
string line = reader.ReadLine();
Console.WriteLine("Enter a baby name for its popularity since 1880");
string entry=Console.ReadLine();
string entry=reader.ReadLine();
Console.WriteLine(entry);
reader.Close();

 }
}
