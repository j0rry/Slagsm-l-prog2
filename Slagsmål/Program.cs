Fight();

static void Fight()
{

    int p1HP = 100;
    int p2HP = 100;

    string p1Name = "Alex";
    string p2Name = "Calin";


    while (p1HP > 0 && p2HP > 0)
    {
        Console.WriteLine($"{p1Name}: {p1HP}");
        Console.WriteLine($"{p2Name}: {p2HP}");
        p2HP -= Random.Shared.Next(10, 25);
        p1HP -= Random.Shared.Next(10, 25);
        Console.ReadLine();
    }

    if (p1HP > 0)
    {
        Console.WriteLine($"{p1Name} vann");
    }

    if (p1HP <= 0 && p2HP <= 0)
    {
        Console.WriteLine($"Oavgjort!");
    }

    if (p2HP > 0)
    {
        Console.WriteLine($"{p2Name} vann");
    }

}