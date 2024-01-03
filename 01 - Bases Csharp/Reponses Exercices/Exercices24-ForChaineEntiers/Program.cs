Console.WriteLine("--- Les suites chaînées de nombres ---\n");

Console.Write("Merce de saisir un nombre : ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Les chaînes possibles sont :");
int midNumber = number / 2 + 1;

for (int i = 1; i <= midNumber; i++)
{
    int sum = 0;
    bool validChain = false;
    int maxChain = 0;
    for (int j = i; j <= midNumber; j++)
    {
        sum += j;
        if (sum == number)
        {
            validChain = true;
            maxChain = j;
        }
        if (sum >= number)
            break;
    }
    if (validChain)
    {
        Console.Write($"{number} = {i}");
        for (int j = i + 1; j <= maxChain; j++)
        {
            Console.Write("+" + j);
        }
        Console.WriteLine();
    }
}



