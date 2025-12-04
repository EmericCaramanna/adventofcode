// constraints dial is between 0 and 99 (inclusive)
// if dial goes below 0 it wraps around to 99
// if dial goes above 99 it wraps around to 0

int dial = 50;

string[] lines = File.ReadAllLines("input.txt");
int count = 0;
foreach (var line in lines)
{
    char command = line[0];
    int value = int.Parse(line[1..]);
    if (command == 'L')
    {
        for (int i = 0; i < value; i++)
        {
            dial--;
            if (dial < 0)
            {
                dial = 99;
            }
            if (dial == 0)
            {
                count++;
            }
        }
    }
    else if (command == 'R')
    {
        for (int i = 0; i < value; i++)
        {
            dial++;
            if (dial > 99)
            {
                dial = 0;
            }
            if (dial == 0)
            {
                count++;
            }
        }
    }
    Console.WriteLine($"{command}{value} -> {dial}");
}
Console.WriteLine($"Dial {dial}");
Console.WriteLine($"Count {count}");
