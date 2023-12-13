using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stall stall = new Stall();

        stall.AddHest(new Hest("Hest1", 25));
        stall.AddHest(new Hest("Hest2", 30));
        stall.AddHest(new Hest("Hest3", 35));

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Velg en handling:");
            Console.WriteLine("1. Mate hesten");
            Console.WriteLine("2. Stelle med hesten");
            Console.WriteLine("3. Meld på hesten til hesteløp");
            Console.WriteLine("4. Start hesteløp");
            Console.WriteLine("5. Avslutt");

            int valg = Convert.ToInt32(Console.ReadLine());

            switch (valg)
            {
                case 1:
                    Console.WriteLine("Hvilken hest vil du mate?");
                    stall.ShowHorsesList();
                    int tilMat = Convert.ToInt32(Console.ReadLine()) - 1;
                    stall.GiMat(tilMat);
                    break;
                case 2:
                    Console.WriteLine("Hvilken hest vil du stelle med?");
                    stall.ShowHorsesList();
                    int tilStelle = Convert.ToInt32(Console.ReadLine()) - 1;
                    stall.StellHest(tilStelle);
                    break;
                case 3:
                    Console.WriteLine("Hvilken hest vil du melde på hesteløp?");
                    stall.ShowHorsesList();
                    int tilHesteLøp = Convert.ToInt32(Console.ReadLine()) - 1;
                    stall.RegisterHorseForRace(tilHesteLøp);
                    break;
                case 4:
                    stall.HesteLøp();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Ugyldig valg. Prøv igjen.");
                    break;
            }
        }
    }
}


