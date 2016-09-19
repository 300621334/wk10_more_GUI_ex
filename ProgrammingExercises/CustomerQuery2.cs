using System;
using System.Linq;
class Customer
{
    public Customer(string name, string zip, double balance)
    {
       Name = name;
       Zip = zip;
       Balance = balance;
    }
    public string Name { get; set; }
    public string Zip { get; set; }
    public double Balance { get; set; }
}

class CustomerQuery2
{
   static void Main()
   {
       Customer[] collection = {new Customer("Smith", "54984", 144.99),
                              new Customer("Jones", "60103", 56.75),
                              new Customer("Brown", "54984", 100.00),
                              new Customer("Greene", "60018", 23.95),
                              new Customer("Davis", "54984", 25.00),
                              new Customer("Cooper", "40090", 200.00),
                              new Customer("Adams", "60103", 44.75),
                              new Customer("Baker", "54984", 250.00),
                              new Customer("Walton", "60103", 0.00),
                              new Customer("Lee", "60018", 220.00)     };
       
       var customers =
           from c in collection
           orderby c.Zip, c.Name
           group c by c.Zip;
       foreach (var grp in customers)
       {
          Console.WriteLine("\nZip: " + grp.Key);
          foreach (var c in grp)
              Console.WriteLine("   {0, -10} {1, 8}", c.Name, c.Balance.ToString("C"));
          Console.WriteLine();
      }
   }
}
