class Hest
{
    public string Name { get; }
    public int Speed { get; }
    public int Distance { get; private set; }
    public bool IsRegisteredForRace { get; private set; }

    public Hest(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public void RegisterForRace()
    {
        if (IsRegisteredForRace)
        {
            Console.WriteLine($"{Name} er allerede meldt på hesteløpet.");
        }
        else
        {
            Console.WriteLine($"{Name} er meldt på hesteløpet.");
            IsRegisteredForRace = true;
        }
    }

    public void Løp()
    {
        if (IsRegisteredForRace)
        {
            Distance += Speed;
            Console.WriteLine($"{Name} har nå løpt {Distance} km.");
        }
        else
        {
            Console.WriteLine($"{Name} er ikke meldt på hesteløpet og kan ikke løpe.");
        }
    }
}
