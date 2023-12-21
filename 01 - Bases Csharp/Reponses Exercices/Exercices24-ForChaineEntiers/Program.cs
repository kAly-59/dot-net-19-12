Console.WriteLine("Exercice 24 - Somme entiers chaînés");

Console.Write("Entrez un nombre : ");
int nombre = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Les chaines possibles sont {nombre} :");
for (int start = 1; start <= nombre; start++)
{
    int sum = 0;
    for (int i = start; i <= nombre; i++)
    {
        sum += i;
        if (sum == nombre)
        {
            for (int j = start; j <= i; j++)
            {
                Console.Write(j);
                if (j != i)
                    Console.Write(" + ");
            }
            Console.WriteLine();
        }
        else if (sum > nombre)
        {
            break;
        }
    }
}



