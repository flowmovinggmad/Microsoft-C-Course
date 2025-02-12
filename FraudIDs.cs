string[] IDs = ["B123", "A456", "B177", "C245", "B420"];

foreach (string id in IDs)
{
    if (id.StartsWith("B"))
    {
        Console.WriteLine(id);
    }
}

Console.WriteLine("\nThese are the fraudulent IDs.");

Console.ReadKey();
