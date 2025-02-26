void multiplication(int number)
{
    Console.WriteLine();

    for (int i = 1; i < 11; i++)
    {
        int result = i * number;

        Console.WriteLine($"{i} X {number} = {result}");
    }

    Console.WriteLine();
}

multiplication(9);
