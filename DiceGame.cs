Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! You get 6 bonus points!");
    total += 6;
} else if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
    {
        Console.WriteLine("You got 2 bonus points for getting a double!");
        total += 2;
    }


if (total >= 16) {
    Console.WriteLine("You win a car!");
} else if (total >= 10) {
    Console.WriteLine("You win a new laptop!");
} else if (total == 7) {
    Console.WriteLine("You win a trip to Japan!");
} else {
    Console.WriteLine("You win a kitten!");
}

Console.WriteLine($"Final Score: {total}");
