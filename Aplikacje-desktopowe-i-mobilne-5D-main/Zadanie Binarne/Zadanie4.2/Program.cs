
    string[] lines = File.ReadAllLines("przyklad.txt");

    List<int> rozkladNaCzynniki(int num)
    {
        List<int> dzielniki = new List<int>();
        int i = 2;
        while (num != 1)
        {
            while (num % i == 0)
            {
                num /= i;
                dzielniki.Add(i);
            }
            i++;
        }
        return dzielniki;
    }

    int ilosc_dzielnikow = -1;
    int maks_ilosc_dzielnikow = -1;
    string maks_liczba = " ";
    int ilosc_dzielnikow_rozne = -1;
    int maks_ilosc_dzielnikow_rozne = -1;
    string maks_liczba_rozne = " ";

    for (int i = 0; i < lines.Length; i++)
    {
        string wiersz = lines[i];
        string line = wiersz;
        ilosc_dzielnikow = rozkladNaCzynniki(int.Parse(line)).Count;
        ilosc_dzielnikow_rozne = new HashSet<int>(rozkladNaCzynniki(int.Parse(line))).Count;

        if (ilosc_dzielnikow > maks_ilosc_dzielnikow)
        {
            maks_ilosc_dzielnikow = ilosc_dzielnikow;
            maks_liczba = line;
        }
        if (ilosc_dzielnikow_rozne > maks_ilosc_dzielnikow_rozne)
        {
            maks_ilosc_dzielnikow_rozne = ilosc_dzielnikow_rozne;
            maks_liczba_rozne = line;
        }
    }

    Console.WriteLine($"{ maks_liczba} {maks_ilosc_dzielnikow} {maks_liczba_rozne} {maks_ilosc_dzielnikow_rozne}");

