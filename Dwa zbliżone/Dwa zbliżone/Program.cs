
using System;

class Program
{
    static void Main()
    {
        int[,] tablica = {
{1, 2, 3},
{4, 5, 6},
{7, 8, 9},
{10, 11, 12}
};

        int[] najblizszeWiersze = ZnajdzNajblizszeWiersze(tablica);
        Console.WriteLine($"Najbardziej zbliżone wiersze: {najblizszeWiersze[0]}, {najblizszeWiersze[1]}");
        Console.ReadLine();
    }

    static int[] ZnajdzNajblizszeWiersze(int[,] tablica)
    {
        int iloscWierszy = tablica.GetLength(0);
        int minRoznica = int.MaxValue;
        int[] najblizszeWiersze = new int[2];

        for (int i = 0; i < iloscWierszy - 1; i++)
        {
            for (int j = i + 1; j < iloscWierszy; j++)
            {
                int roznica = ObliczRozniceWierszy(tablica, i, j);
                if (roznica < minRoznica)
                {
                    minRoznica = roznica;
                    najblizszeWiersze[0] = i;
                    najblizszeWiersze[1] = j;
                }
            }
        }

        return najblizszeWiersze;
    }

    static int ObliczRozniceWierszy(int[,] tablica, int wiersz1, int wiersz2)
    {
        int iloscKolumn = tablica.GetLength(1);
        int roznica = 0;

        for (int k = 0; k < iloscKolumn; k++)
        {
            int aik1 = tablica[wiersz1, k];
            int aik2 = tablica[wiersz2, k];
            roznica += (aik1 - aik2) * (aik1 - aik2);
        }

        return roznica;
    }
}

