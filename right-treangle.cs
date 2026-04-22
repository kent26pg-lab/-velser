Console.WriteLine("Enter total bill amount:");
double total = double.Parse(Console.ReadLine());

Console.WriteLine("Enter number of people:");
int people = int.Parse(Console.ReadLine());

double finalAmount = (total) / people;
Console.WriteLine("Each person owes: kr " + finalAmount);