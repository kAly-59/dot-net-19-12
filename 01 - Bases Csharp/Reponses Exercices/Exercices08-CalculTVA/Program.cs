Console.Write("Entrez le prix HT (en euro) : ");
float prixHT = float.Parse(Console.ReadLine());
Console.Write("Entrez le taux de TVA (en %) : ");
float tva = float.Parse(Console.ReadLine());

float sommeTVA = prixHT * (tva/100);
float prixTTC = prixHT + sommeTVA;

Console.WriteLine("La TVA est de : " + sommeTVA + " Euros");
Console.WriteLine("Le prix TTC est de : " + prixTTC+ " Euros");