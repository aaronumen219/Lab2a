using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the name of item");
    string name = Console.ReadLine();
    
  
    Console.WriteLine("Enter the quantity");
    int quantity = Convert.ToInt32(Console.ReadLine());
   
    Console.WriteLine("Enter the price");
    double cost = Convert.ToDouble((Console.ReadLine()));
    Console.WriteLine("Total price of " + name + " = " + quantity * cost);
  }
}