// generate number 1...3, ask for user to guess, generate new

Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a guess, enter a number 1-3");
    int userNum = Int32.Parse(Console.ReadLine());

    if (userNum == cpuRandom)
    {
        Console.WriteLine("Congratulations!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("That's the wrong number!");
    }
}
Console.WriteLine("You're out of the loop.");