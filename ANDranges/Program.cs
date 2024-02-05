// temp <= 0 - freezing; temp >0 AND <=10 - cold; temp >10 AND <=15 - chilly; temp >=15 AND <20 - warm; temp >=20 AND <30 - hot; temp >=30 - scorching

Console.WriteLine("Please enter temperature [C]: ");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("It's scorching.");
}
else if (temp <30 &&  temp >=20)
{
    Console.WriteLine("It's hot.");
}
else if (temp <20 && temp >=15)
{
    Console.WriteLine("It's warm.");
}
else if (temp <15 && temp >=10)
{
    Console.WriteLine("It's chilly.");
}
else if (temp <10 && temp >0)
{
    Console.WriteLine("It's cold.");
}
else
{
    Console.WriteLine("It's freezing.");
}