
const int N = 10000;
bool[] sito = new bool[N];

for (int i = 0; i < N; i++)
    sito[i] = true;
sito[0] = true;
sito[1] = false;

for (int i = 2; i < Math.Sqrt(N); i++)
{
    if (sito[i] == true) {
        for (int j = i + i; j < N; j = j + i) 
        {
            sito[j] = false;
        }
    }
}

//for (int i = 2; i < N; i++) 
//{
//    if (sito[i]) 
//    {
//        Console.WriteLine(i);
//    }
//}
    
//zadanie 3.2
int count = 0;
StreamReader sr = new StreamReader("liczby_przyklad.txt");
string? strNumber;
while ((strNumber = sr.ReadLine())!=null) 
{
    if (int.TryParse(strNumber, out int number))
    {
        if (sito[number - 1])
        {
            count++;
        } 
    }
}

//Console.WriteLine($"Ilość liczb do zadania 3.2 to: {count}");

//zadanie 3.3

sr = new StreamReader("liczby_przyklad.txt");
int maxCount = 0;
int maxNumber = 0;
int minCount = int.MaxValue;
int minNumber = 0;
while ((strNumber = sr.ReadLine()) != null)
{
    if (int.TryParse(strNumber, out int number))
    {
        count = 0;
        for (int j = number - 1; j>=number / 2; j--)
        {
            if (sito[j] == true
                && number - j > 1
                && sito[number -j])
                count++;

        }

        if (count > maxCount) 
        {
            maxCount = count;
            maxNumber = number;
        }
        if (count < minCount)
        {
            minCount = count;
            minNumber = number;
        }

    }
}

Console.WriteLine($"{maxNumber} {maxCount} {minNumber} {minCount}" );

sr.Close();

//zadanie 3.4
int[] counterDigit = new int[16];

sr = new StreamReader("liczby_przyklad.txt");

while ((strNumber = sr.ReadLine()) != null)
{
    if (int.TryParse(strNumber, out int number))
    {
        do
        {
            int rest = number % 16;

            counterDigit[rest]++;


            number /= 16;
        }
        while (number != 0);
    }
}

Console.WriteLine($"Dla zdania 3.4: ");

for(int i = 0; i < counterDigit.Length; i++)
{

    Console.WriteLine($"{i.ToString("X")} : {counterDigit[i]}a");
}

sr.Close();