const double COST_OF_SANDWHICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = .1;

int numberOfSandwhiches = 0;
int numberOfToppings = 0;
double tip = 0;

Console.WriteLine("Enter number of sandwhiches");
numberOfSandwhiches = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number of toppings");
numberOfToppings = int.Parse(Console.ReadLine());

Console.WriteLine("Enter tip amount:");
tip = double.Parse(Console.ReadLine());

double totalSandwhichCost = 0;
totalSandwhichCost = COST_OF_SANDWHICH * numberOfSandwhiches;

double totalToppingCost = 0;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;

double baseCost = 0;
baseCost = totalSandwhichCost + totalToppingCost;

double orderCost = 0;
orderCost = tip + baseCost * (1 - DISCOUNT_AMOUNT);

Console.WriteLine("Your total cost is: " + orderCost);



