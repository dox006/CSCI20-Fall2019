//Dylan Cox
//Oct 3
//Reversing directions with array tools
using System;
namespace Loop
{
  class ForLoop
  {
    public static void Main(int [] arr, int start, int end)
    {
        int directions;
        arr[] = {"Broadway"; "I hate this class street"; "3rd Ave";};  
        while (start < end)
        {
            directions = arr[start];
            arr[start] = arr[end];
            arr[end] = directions;
            start++;
            end--;
        printArray(arr, 6);
        reverseArray(arr, 0, 5);
        Console.Write("Reversed array is \n");
        printArray(arr, 6);
        }
    }
  }
}
