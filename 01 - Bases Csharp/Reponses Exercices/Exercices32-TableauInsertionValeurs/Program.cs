Console.WriteLine("Insertion des valeurs du tableau");

double[] valeurs = new double[5];
var tab = "";

for (int i = 0; i < valeurs.Length; i++)
{
    Console.Write($"Saisir la valeur {i + 1}:  ");
    valeurs[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine($"Afficher les valeurs du tab : ");

foreach (double valeur in valeurs)
{
    Console.WriteLine($"{tab}{valeur}");
    tab += "\t";
}