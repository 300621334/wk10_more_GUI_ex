using System;
using System.Linq;
class LinqDoubles
{
   static void Main()
   {
      int x;
      double[] array = new double[15];      
      for(x = 0; x < array.Length; ++x)
      {
         Console.Write("Enter a number >> ");
         if(!double.TryParse(Console.ReadLine(), out array[x]))
         {
            Console.Write("    Please renter. ");
            --x;
         }
      }
       var nums =
           from n in array
           orderby -n
           select n;
       Console.WriteLine("In descending order: ");
       foreach (var n in nums)
           Console.Write("{0} ", n);
       Console.WriteLine();
   }
}