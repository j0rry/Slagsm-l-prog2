Fight();

static void Fight()
{
    int p1HP = 100;
    int p2HP = 100;
    string p1Name = "";
    string p2Name = "Kebab Kungen";

    while (string.IsNullOrEmpty(p1Name))
    {
        Console.Write("Ange namn på spelare 1: ");
        p1Name = Console.ReadLine();
    }

    while (p1HP > 0 && p2HP > 0)
    {
        int p1Damage = Random.Shared.Next(10, 25);
        int p2Damage = Random.Shared.Next(10, 25);

        p2HP -= p1Damage;
        p1HP -= p2Damage;

        Console.WriteLine($"{p1Name} gör {p1Damage} skada!");
        Console.WriteLine($"{p2Name} gör {p2Damage} skada!");
        Console.WriteLine($"{p1Name}: {Math.Max(p1HP, 0)} HP");
        Console.WriteLine($"{p2Name}: {Math.Max(p2HP, 0)} HP");
        Console.WriteLine("Tryck på Enter för nästa runda");
        Console.ReadLine();
    }

    if (p1HP > 0 && p2HP <= 0)
    {
        Console.WriteLine($"{p1Name} vann");
    }
    else if (p1HP <= 0 && p2HP > 0)
    {
        Console.WriteLine($"{p2Name} vann");
    }
    else
    {
        Console.WriteLine("Oavgjort!");
    }
}