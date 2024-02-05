// 
Random rnd = new Random();
int myRando;
int ranSum = 0;

for (int i = 0; i < 3; i++) // repeat x3
{
    myRando = rnd.Next(0, 11);  // 0...10
    ranSum = ranSum + myRando;
    Console.WriteLine($"Generated number {myRando}");
}
Console.WriteLine($"Sum is {ranSum}");