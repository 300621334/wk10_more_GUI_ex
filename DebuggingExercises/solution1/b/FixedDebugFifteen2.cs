// Program declares an array of names
// Lists all names in alphabetical order
// Then lists in two groups
//   -- those that start with a vowel and those that do not 
using System;
using System.Linq;
class FixedDebugFifteen2
{
    static void Main()
    {
        string[] names = {"Andrea", "Audrey", "Danielle", "Brooke", "Eric",
                          "Brittany", "Lindsay", "Geoffrey",
                          "Abby", "Carly", "Emily", "Robin", "Carmen", "Dustin",
                          "Roger", "Ryan", "Stacy", "Tim", "Marcia",
                          "Annette", "Steve", "Sue", "Rich", "Ruth",
                          "Bob", "Helen", "Butch", "Carol", "Jim",
                          "Karen", "Gladys", "Kathy", "Cheryl", "Scott",
                          "Savannah", "Dylan", "Gabby", "Jann", "Olivia", "Edward",
                          "Eamon", "Iris"};

        int namesInALine = names.Length / 5;
        int count = 0;
        var orderedNames =
            from n in names
            orderby n
            select n;
        Console.WriteLine("All names in aphabetical order:\n");
        foreach (var n in orderedNames)
        {
            Console.Write("   " + n);
            ++count;
            if (count == namesInALine)
            {
                Console.WriteLine();
                count = 0;
            }
        }
        Console.WriteLine();

        //p-738: "group 'e' by e.Department " will gp by depts. while "group e by e.Department == 1" will make 2 gps True-gp & false-gp
        //A query body must end with a  select clause or a  group clause. Therefore, if you combine  'orderby' and  'group' ,  orderby must come  first and group must come last. e.g:
        /*var stus = from s in cartmanCollegeDataSet.tblStudents
        orderby s.LastName
        group s by (int)s.GradePointAverage;*/


        Console.WriteLine("\n\nNames grouped by whether starting letter is a vowel:");
        var lettterGroup =
             from n in orderedNames
             group n by n.StartsWith("A") || n.StartsWith("E") ||
                n.StartsWith("I") || n.StartsWith("O") || n.StartsWith("U");
        foreach (var grp in lettterGroup)
        {
            Console.WriteLine("\nStarts with a vowel: " + grp.Key);
            count = 0;
            foreach (var n in grp)
            {
                Console.Write("   " + n);
                ++count;
                if (count == namesInALine)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
            Console.WriteLine();
        }
    }
}