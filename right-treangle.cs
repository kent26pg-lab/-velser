int n = int.Parse(Console.ReadLine());

for (int y = 0; y < n; y++)
{
    int space_count = n - y - 1;
    int dot_count = y + 1;

    for (int x = 0; x < space_count; x++)
    {
        Console.Write(" ");
    }

    for (int x = 0; x < dot_count; x++)
    {
        Console.Write("#");
    }

    Console.WriteLine();
}