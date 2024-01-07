Console.WriteLine("--WHERE IS MY NUMBER--");
Random numbers = new Random();
int[] arrayNumbers = new int[10];

for (int i = 0; i < arrayNumbers.Length; i++)
{
    arrayNumbers[i] = numbers.Next(1, 51);
}

int index01 = arrayNumbers[0];

Console.WriteLine("Avant le tri :");
foreach (var number in arrayNumbers)
{
    Console.WriteLine(number);
}

Array.Sort(arrayNumbers);

Console.WriteLine("Après le tri (ordre croissant) :");
foreach (var number in arrayNumbers)
{
    Console.WriteLine(number);
}

int index02 = Array.IndexOf(arrayNumbers, index01);

Console.WriteLine($"Le nombre {index01} se trouvait à l'index 0 avant le tri.");
Console.WriteLine($"Il se trouve à l'index {index02} après le tri.");
