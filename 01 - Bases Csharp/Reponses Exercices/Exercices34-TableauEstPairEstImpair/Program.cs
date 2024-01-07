Console.WriteLine("--Pair or Impair--");
Console.WriteLine("Combien de chiffre contiendra le tableau ?");
int nombreTab = Convert.ToInt32(Console.ReadLine());

Console.Write("Assignation auto....");
Random aleatoire = new Random();

for (int i = 0; i < nombreTab; i++)
    ints[i] = aleatoire.Next(1, 51);

Console.Write("test" + aleatoire + nombreTab);






