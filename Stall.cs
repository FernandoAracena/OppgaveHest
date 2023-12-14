using System.Xml.Linq;

class Stall
{
    private List<Hest> horses = new List<Hest>();

    public void AddHest(Hest horse)
    {
        horses.Add(horse);
    }

    public void ShowHorsesList()
    {
        Console.WriteLine("Horses in the stall:");
        for (int i = 0; i < horses.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {horses[i].Name}");
        }
    }
    public void GiMat(int index)
    {
        if (index >= 0 && index < horses.Count)
        {
            Console.WriteLine($"{horses[index].Name} ble matet.");
        }
        else
        {
            Console.WriteLine("Ugyldig hestevalg.");
        }
    }

    public void StellHest(int index)
    {
        if (index >= 0 && index < horses.Count)
        {
            Console.WriteLine($"{horses[index].Name} blir stelt med.");
        }
        else
        {
            Console.WriteLine("Ugyldig hestevalg.");
        }
    }

    public void RegisterHorseForRace(int index)
    {
        if (index >= 0 && index < horses.Count)
        {
            horses[index].RegisterForRace();
        }
        else
        {
            Console.WriteLine("Ugyldig hestevalg.");
        }
    }

    public void HesteLøp()
    {
        if (horses.Any(horse => horse.IsRegisteredForRace))
        {
            int rounds = 3;
            bool raceCompleted = false;
            int i = 1;

            while (!raceCompleted)
            {
                Console.WriteLine();

                foreach (var horse in horses)
                {
                    horse.Løp();

                    if (horse.Distance >= 300)
                    {
                        raceCompleted = true;
                        break;
                    }
                }

                i++;
            }

            Hest winner = horses.OrderBy(h => h.Distance).Last();
            Console.WriteLine();
            Console.WriteLine($"HESTEN {winner.Name} VANT HESTELØP!!!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Ingen hester er meldt på hesteløpet. Start avlyst.");
        }
    }
}
