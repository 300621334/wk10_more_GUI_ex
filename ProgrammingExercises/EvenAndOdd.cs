using System;
using System.Linq;
class EvenAndOdd
{
   static void Main()
   {
      int x;
      int group = 0;
      int[] array = new int[8];
      string firstGroup, secondGroup;
      for(x = 0; x < array.Length; ++x)
      {
         Console.Write("Enter an integer > ");
         array[x] = Convert.ToInt32(Console.ReadLine());
      }
      if (array[0] % 2 == 0)
      {
          firstGroup = "Even > ";
          secondGroup = "Odd > ";
      }
      else
      {
          firstGroup = "Odd > ";
          secondGroup = "Even > ";
      }
        var nums =
           from n in array
           group n by n % 2;
        Console.WriteLine();
       foreach (var grp in nums)
       {
           if(group == 0)
           {
               Console.Write(firstGroup);
               group = 1;
           }
           else
               Console.Write(secondGroup);
           foreach (var n in grp)
               Console.Write("{0} ", n);
           Console.WriteLine();
       }

   }
}