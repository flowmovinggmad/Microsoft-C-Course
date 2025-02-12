int[] inventory = {200, 450, 700, 175, 200};

int sum = 0;
int bin = 0;

foreach (int items in inventory) 
{
    bin++;
    sum += items;

    Console.WriteLine($"Bin: {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine(" ");
Console.WriteLine($"We have {sum} items in inventory.");

