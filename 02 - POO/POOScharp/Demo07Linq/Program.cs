using Demo07Linq;

var mesNombres = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var mesNombresAuCarre = Enumerable.Range(1, 10).Select(n => n * n);

foreach (var n in mesNombres)
{
    Console.WriteLine(n);
}

Console.WriteLine("\n=====\n");

foreach (var n in mesNombresAuCarre)
{
    Console.WriteLine(n);
}

string maChaine = "john dupont";
Console.WriteLine(maChaine.ToUpper());
Console.WriteLine(maChaine.ToLower());

//string ToCapitalized(string value)
//{
//    string returnValue = "";
//    foreach (var mot in value.Split(" "))
//    {
//        returnValue += mot.Substring(0, 1).ToUpper() + mot.Substring(1).ToLower(); 
//    }
//    return returnValue;
//}

Console.WriteLine(maChaine.ToCapitalized());

int nbA = 24;

int somme = nbA.Add(10);

List<int> nombresPairs = new();

foreach(int n in mesNombres)
{
    if (n % 2 == 0) nombresPairs.Add(n);
}

var lesNombresPairs = mesNombres.Where(x => x % 2 == 0).ToDictionary(x => x.ToString());

List<Personne> mesPersonnes = new()
{
    new() { Nom = "DUPONT", Prenom = "John"},
    new() { Nom = "SCHMIT", Prenom = "Martha"},
    new() { Nom = "DUPONT", Prenom = "Chloée"},
    new() { Nom = "MARTEZ", Prenom = "Clark"}
};

// Pour trouver un élément dans une collection, on peut utiliser la fonction 
Personne? chloee = mesPersonnes.Find(x => x.Prenom == "Chloée");


// Mais avec Linq, on peut optimiser la chose via trois méthodes possédant chacune une variante retournant la valeur par défaut en cas de condition non remplies ou de non trouvaille

// On peut chercher dans le listing à partir du début
Personne chloeeAvecLinq = mesPersonnes.First(x => x.Prenom == "Chloée");
Personne chloeeAvecLinqSecurise = mesPersonnes.FirstOrDefault(x => x.Prenom == "Chloée") ?? new() { Nom = "DUPONT", Prenom = "Chloée" };

// A partir de la fin
Personne chloeeAPartirDeLaFin = mesPersonnes.Last(x => x.Prenom == "Chloée");
Personne chloeeAPartirDeLaFinSecurise = mesPersonnes.LastOrDefault(x => x.Prenom == "Chloée") ?? new() { Nom = "DUPONT", Prenom = "Chloée" };

// A partir du début et s'assurer des non doublons de notre critère
Personne laSeuleEtUniqueChloee = mesPersonnes.Single(x => x.Prenom == "Chloée");
Personne? laSeuleEtUniqueChloeeSecure = mesPersonnes.SingleOrDefault(x => x.Prenom == "Chloée");