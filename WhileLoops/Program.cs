
using System.Reflection.Metadata;

Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while(loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess: Entar a number 1-3");
    int userInput = Int32.Parse(Console.ReadLine());
    if (userInput == cpuRandom)
    {
        Console.WriteLine("You Won");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Oops. try again");
    }
}
