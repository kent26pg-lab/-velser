Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());

if (age <= 15)
{
    Console.WriteLine("The ticket is free.");
}
else if (age > 15 && age <= 30)
{
    Console.WriteLine("The ticket price is 20.");
}
else if (age < 30 && age <= 65)
{
    Console.WriteLine("The ticket price is 30 ");
}
else
{
    Console.WriteLine("The ticket price is 15.");
}






