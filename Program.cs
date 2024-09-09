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

double sandwhichCost = 0;
sandwhichCost = COST_OF_SANDWHICH * numberOfSandwhiches;

double toppingCost = 0;
toppingCost = COST_OF_TOPPING * numberOfToppings;

double cost = 0;
cost = sandwhichCost + toppingCost;

double order = 0;
order = cost - (cost * DISCOUNT_AMOUNT);

Console.WriteLine("Your total cost is: " + order);



