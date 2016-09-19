using System;
using System.Linq;
class ShortWords
{
   static void Main()
   {
      string[] words = {"antelope", "bear", "cat", "dolphin", "elephant",
                        "frog", "giraffe", "hippopotamus", "iguana", "jaguar",
                        "kitten", "llama"};
      int length;
      Console.Write("Enter a maximum word length > ");
      while(!int.TryParse(Console.ReadLine(), out length))
      {
         Console.WriteLine("Invalid entry. Please enter an integer.");
      }
      var shortWords =
         from w in words
         where w.Length < length
         select w;
      if (shortWords.Count() == 0)
         Console.WriteLine("There are no words under {0} letters long", length);
      else
         Console.WriteLine("The short words include: ");
      foreach (var w in shortWords)
      {
         Console.WriteLine("   " + w);
      }
   }
}