using System;

class Program
{
    static int LiczenieBloki(string liczba_str)
    {
        int iloscBlokow = 0;
        int cyfraPoprzednia = ' ';

        for (int i = 0; i < liczba_str.Length; i++)
        {
            int cyfra = liczba_str[i];
            if (cyfra != cyfraPoprzednia)
            {
                iloscBlokow += 1;
            }
            cyfraPoprzednia = cyfra;
        }
        return iloscBlokow;
    }

    static string ZmianaNaBinarny(int n)
    {
        string wynik = "";
        while (n > 0) {
            int reszta = n % 2;
            wynik = reszta + wynik;
            n /= 2;
        }
        return wynik;
    }

    static void Main()
    {
        int n = 245;
        string liczbaBinarna = ZmianaNaBinarny(n);

        int liczbaBlokow = LiczenieBloki(liczbaBinarna);
        Console.WriteLine(liczbaBlokow);
    }
}

