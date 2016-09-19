using System;
using System.Linq;
class SplitAlphabet
{
   static void Main()
   {
      string[] words = {"antelope", "turtle", "cat", "dolphin", "puppy", "dog",
                        "elephant", "lamb", "rabbit", "whale", "spider",
                        "frog", "giraffe", "hippopotamus", "iguana", "jaguar",
                        "kitten", "llama", "moose", "okapi"};
      var wrds =
          from w in words
          group w by String.Compare(w, "n") < 0;
      foreach (var grp in wrds)
      {
          Console.WriteLine("Word is in first half of alphabet is {0}", grp.Key);
          foreach(var w in grp)
             Console.WriteLine("   {0}", w);
          Console.WriteLine("--Count for this group is {0}", grp.Count());
          Console.WriteLine();
      }
   }
}