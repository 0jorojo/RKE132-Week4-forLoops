int sum = 0;

for(int i=1; i<11; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current count: {sum}");
    sum = sum + i; // sum += i
}

Console.WriteLine($"Final total {sum}");