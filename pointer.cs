using System;

class MainClass {

public static void Main () {

int[] a = new int[5] { 10, 20, 30, 40, 50 };

unsafe //main.cs(9,1): error CS0227: Unsafe code requires the `unsafe' command line option to be specified
{

fixed (int* p = &a[0])
{
int* p2 = p;
Console.WriteLine(*p2);

p2 += 1;
Console.WriteLine(*p2);
p2 += 1;
Console.WriteLine(*p2);
Console.WriteLine("--------");
Console.WriteLine(*p);

*p += 1;
Console.WriteLine(*p);
*p += 1;
Console.WriteLine(*p);
}
}

Console.WriteLine("--------");
Console.WriteLine(a[0]);
}

}
