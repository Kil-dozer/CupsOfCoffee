using System;

namespace CupsOfCoffee
{
  class Program
  {
    static void Main(string[] args)
    {
      var numberOfCupsOfCoffee = 7;
      var fullName = "Rob Kilduff";
      var today = "10th";
      Console.WriteLine(fullName + " drank " + numberOfCupsOfCoffee + " cups of coffee on the " + today);
      Console.WriteLine("Greetings, what is your name?");
      var user = Console.ReadLine();
      Console.WriteLine("Hello " + user);
      Console.WriteLine("Please input two numbers");
      var operand1 = Console.ReadLine();
      var operand2 = Console.ReadLine();
      int num1 = Int32.Parse(operand1);
      int num2 = Int32.Parse(operand2);
      Console.WriteLine("number one is " + operand1 + " number two is " + operand2);
      string s = (operand1 + operand2);
      var sum = ((num1 + num2));
      Console.WriteLine("The sum of these numbers is " + sum);
      var difference = ((num1 - num2));
      Console.WriteLine("The difference of these numbers is " + difference);
      var quotient = ((num1) / (num2));
      Console.WriteLine("The quotient of these numbers is " + quotient);
      var product = ((num1) * (num2));
      Console.WriteLine("The product of these numbers is " + product);
    }
  }
}