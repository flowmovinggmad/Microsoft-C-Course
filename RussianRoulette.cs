//Russian Roulette

Random revolver = new Random();
Console.WriteLine("1 in 6 chance of dying.\n\n");
int revolverTurn = revolver.Next(0, 7);
int i = 0;
bool on = true;

do
{
    revolverTurn = revolver.Next(0, 7);
    i++;

    Console.WriteLine($"Turn {i}: {revolverTurn}");

    if (revolverTurn == 6)
    {
        Console.WriteLine("You are dead.");
        on = false;

    } else if (revolverTurn != 6)
    {
        Console.WriteLine("Another Turn.\n");
    }
} while (on == true);

Console.ReadKey();
