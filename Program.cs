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
        int valg;
        while (!exit)
        {
            Console.WriteLine("Velg en handling:");
            Console.WriteLine("1. Mate hesten");
            Console.WriteLine("2. Stelle med hesten");
            Console.WriteLine("3. Meld på hesten til hesteløp");
            Console.WriteLine("4. Start hesteløp");
            Console.WriteLine("5. Avslutt");

            while (!int.TryParse(Console.ReadLine(), out valg))
            {
                Console.WriteLine("Ugyldig inntasting. Vennligst skriv inn et gyldig tall for valget ditt.");
            }

            switch (valg)
            {
                case 1:
                    Console.WriteLine("Hvilken hest vil du mate?");
                    stall.ShowHorsesList();
                    int tilMat;
                    while (!int.TryParse(Console.ReadLine(), out tilMat))
                    {
                        Console.WriteLine("Ugyldig inntasting. Vennligst skriv inn et gyldig tall for valget ditt.");
                    }
                    stall.GiMat(tilMat - 1);
                    break;
                case 2:
                    Console.WriteLine("Hvilken hest vil du stelle med?");
                    stall.ShowHorsesList();
                    int tilStelle;
                    while (!int.TryParse(Console.ReadLine(), out tilStelle))
                    {
                        Console.WriteLine("Ugyldig inntasting. Vennligst skriv inn et gyldig tall for valget ditt.");
                    }
                    stall.StellHest(tilStelle - 1);
                    break;
                case 3:
                    Console.WriteLine("Hvilken hest vil du melde på hesteløp?");
                    stall.ShowHorsesList();
                    int tilHesteLøp;
                    while (!int.TryParse(Console.ReadLine(), out tilHesteLøp))
                    {
                        Console.WriteLine("Ugyldig inntasting. Vennligst skriv inn et gyldig tall for valget ditt.");
                    }
                    stall.RegisterHorseForRace(tilHesteLøp - 1);
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


