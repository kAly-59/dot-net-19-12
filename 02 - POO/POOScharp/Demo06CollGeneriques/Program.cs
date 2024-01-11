// Les Listes 
List<string> mesStrings = new();

// On peut ajouter des éléments dans une liste
mesStrings.Add("John");

// En supprimer via la valeur
mesStrings.Remove("John");

// Chercher un élément correspondant à un critère donné
var trouve = mesStrings.Find(x => x.StartsWith('J'));

// Accéder aux éléments via leur index
var firstElement = mesStrings[0];

// Supprimer les éléments via l'index
mesStrings.RemoveAt(0);

// Ajouter une autre série de valeurs pour étendre notre liste
mesStrings.AddRange(new List<string>() { "Albert", "John" });

// Trouver l'index d'un élément
int index = mesStrings.IndexOf("Albert");

// Vider la liste
mesStrings.Clear();

// Trier la liste
mesStrings.Sort();


// Pour réaliser des retour multiples ou rassembler des valeurs (jusquà 7 valeurs max), on peut utiliser un type générique qui est déjà disponible et prévu à cet effet: les Tuple<>

// Il existe une ancienne syntaxe pour réaliser cela : 
Tuple<int, int, int, double> Calcul(int a, int b) {
    return new Tuple<int, int, int, double>(a + b, a - b, a * b, a / b);
}

Tuple<int, int, int, double> mesResultats = Calcul(2, 6);
int laSomme = mesResultats.Item1;
int leReste = mesResultats.Item2;


// Et une syntaxe plus moderne:
(int, int, int, double) CalculModerne(int a, int b) {
    return (a + b, a - b, a * b, a / b);
}


// Qui nous permet l'extraction des valeurs via les propriétés .ItemX comme avant
(int, int, int, double) mesResultatsALAncienne = CalculModerne(2, 6);
int laSommeALancienne = mesResultats.Item1;
int leResteALancienne = mesResultats.Item2;

// Ou l'initialisation des variables directement via un unpacking du tuple
var (somme, reste, produit, quotient) = CalculModerne(2, 6);

// Le Dictionnaire est une collection permettant de stocker via un ensemble clé-valeur des données. La clé sera généralement une chaine de caractère et la valeur un type référence, mais ceci est libre. 

Dictionary<string, Contact> mesContacts = new();

// Lorsque l'on veut ajouter un élément à notre dictionnaire, on peut également utiliser la méthode .Add(), mais celle-ci fonctionne différemment pour le dictionnaire. Il nous faudra indiquer la clé en amont de la valeur à ajouter
mesContacts.Add("John DUPONT", new()
{
    Nom = "DUPONT",
    Prenom = "John",
    Telephone = "+33 123 456 789",
    Email = "j.dupont@example.com",
    Age = 21
});

// Pour accéder à la valeur, il est possible dans un dictionnaire de faire appel à l'indexeur (notation crochets), qui fonctionne cette fois-ci via la clé et non l'index numérique (emplacement dans la collection) telle que la liste
Console.WriteLine(mesContacts["John DUPONT"].Telephone);