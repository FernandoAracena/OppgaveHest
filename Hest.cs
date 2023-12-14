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
            Distance += Speed; // Adjust the distance based on the horse's speed
            Console.WriteLine($"{Name} har nå løpt {Distance} mts.");

            // Check if the horse has completed 1 lap (100 meters)
            if (Distance >= 100 && Distance < 200)
            {
                Console.WriteLine($"{Name} har fullført 1 runde");
            } else if (Distance >= 200 && Distance < 300)
            {
                Console.WriteLine($"{Name} har fullført 2 runder");
            }

            // Check if the horse has completed the race
            if (Distance >= 300)
            {
                Console.WriteLine($"{Name} HAR FULLFØRT LØPET!");
            }
        }
        else
        {
            Console.WriteLine($"{Name} er ikke meldt på hesteløpet og kan ikke løpe.");
        }
    }
}
