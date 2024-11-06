string[] lines = File.ReadAllLines("przyklad.txt");

// Zadanie 4.1
int count = 0;
string firstMatch = "";

for (int i = 0; i < lines.Length; i++)
{
    string line = lines[i];
    string checkLine = line;
    if (checkLine[0] == checkLine[checkLine.Length - 1])
    {
        count++;
        if (firstMatch == "")
        {
            firstMatch = checkLine;
        }
    }
}

Console.WriteLine($"{count} {firstMatch}");

