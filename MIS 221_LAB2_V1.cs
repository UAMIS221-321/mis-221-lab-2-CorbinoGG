
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
//define constant processing items
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.1;

System.Console.WriteLine("Welcome to Sherlenthia's Sandwich Shop!");
System.Console.WriteLine(); //spacing

//input
System.Console.WriteLine("How many sandwhiches would you like?");
int numberOfSandwiches = int.Parse(Console.ReadLine());

System.Console.WriteLine("How many toppings would you like to add?");
int numberOfToppings = int.Parse(Console.ReadLine());

System.Console.WriteLine("Please enter your tip amount (e.g. 00.00):");
double tip = double.Parse(Console.ReadLine());

//processing
double totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
double totalToppingCost = COST_OF_TOPPING * numberOfToppings;
double baseCost = totalSandwichCost + totalToppingCost;
double orderCost = (tip + baseCost) * (1 - DISCOUNT_AMOUNT);

//output
System.Console.WriteLine(); //spacing
System.Console.WriteLine("Your total today is: $"+ orderCost);