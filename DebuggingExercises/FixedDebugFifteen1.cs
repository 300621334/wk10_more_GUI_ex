/// This program sorts and displays 20 integers.
// It also displays statistics about the array.
using System;
using System.Linq;
class FixedDebugFifteen1
{
   static void Main()
   {
      int[] array = {23, 45, 67, 78, 98, 76, 55, 33, 11, 24,
            3, 97, 100, 4, 6, 64, 81, 12, 44, 5};      
       var nums =
           from n in array
           orderby n
           select n;
       Console.WriteLine("In order: ");
       foreach (var n in nums)
           Console.Write("{0} ", n);
       Console.WriteLine();
       Console.WriteLine("Highest number is {0}", nums.Max());
       Console.WriteLine("Lowest number is {0}", nums.Min());
       Console.WriteLine("Average number is {0}", nums.Average());
   }
}