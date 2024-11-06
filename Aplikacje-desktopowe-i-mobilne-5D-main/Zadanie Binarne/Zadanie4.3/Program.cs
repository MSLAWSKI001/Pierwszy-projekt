using System;
using System.Collections.Generic;
using System.IO;

        var plik = File.ReadAllLines("przyklad.txt");
        List<int> liczby = new List<int>();
        foreach (var wiersz in plik)
        {
            liczby.Add(int.Parse(wiersz));
        }
        List<List<int>> dobre_trojki = new List<List<int>>();
        for (int i = 0; i < liczby.Count - 1; i++)
        {
            int x = liczby[i];
            for (int j = 0; j < liczby.Count - 1; j++)
            {
                if (j == i) continue;
                int y = liczby[j];
                if (y % x == 0)
                {
                    for (int k = 0; k < liczby.Count - 1; k++)
                    {
                        if (k == j) continue;
                        int z = liczby[k];
                        if (y % x == 0 && z % y == 0)
                        {
                            dobre_trojki.Add(new List<int> { x, y, z });
                        }
                    }
                }
            }
        }
        List<List<int>> dobre_piatki = new List<List<int>>();
        for (int i = 0; i < liczby.Count - 1; i++)
        {
            int n1 = liczby[i];
            for (int j = 0; j < liczby.Count - 1; j++)
            {
                if (j == i) continue;
                int n2 = liczby[j];
                if (n2 % n1 == 0)
                {
                    for (int k = 0; k < liczby.Count - 1; k++)
                    {
                        if (k == j) continue;
                        int n3 = liczby[k];
                        if (n3 % n2 == 0)
                        {
                            for (int l = 0; l < liczby.Count - 1; l++)
                            {
                                if (l == k) continue;
                                int n4 = liczby[l];
                                if (n4 % n3 == 0)
                                {
                                    for (int m = 0; m < liczby.Count - 1; m++)
                                    {
                                        if (m == l) continue;
                                        int n5 = liczby[m];
                                        if (n5 % n4 == 0)
                                        {
                                            dobre_piatki.Add(new List<int> { n1, n2, n3, n4, n5 });
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(dobre_trojki.Count);
        Console.WriteLine(dobre_piatki.Count);