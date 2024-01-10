using Demo05Interfaces.Classes;
using Demo05Interfaces.Interfaces;

Oiseau monOiseau = new("Coco");
Chien monChien = new("Rex");
Avion monAvion = new();

Animal monAnimal;

monAnimal = new Chien("Bernie");

Animal FaireNaissance()
{
    return new Oiseau("Coco");
}

Oiseau coco = (Oiseau) FaireNaissance();

// Il est possible de regrouper des éléments dans une série ou un type de variable via l'utilisation des classes parents (abstraites ou non)

List<Animal> mesAnimaux = new()
{
    monChien,
    monOiseau
};

// Il est possible de regrouper des éléments dans une série ou un type de variable via l'utilisation des interfaces également

List<IVolant> mesVolants = new()
{
    monOiseau,
    monAvion
};

/* 
 * Il serait possible de regrouper tout type d'élément dans une liste, peu importe son type car tout type hérite d'object
 * 
 * Cependant, en faisant cela, on va perdre toute information de ce que l'élément est capable de faire et on va devoir faire un casting pour obtenir de nouveau ces infos
 */


//List<object> mesObjects = new()
//{
//    monAvion,
//    monChien,
//    monOiseau
//};

//foreach(object obj in mesObjects)
//{
//    if (obj is Oiseau) ((Oiseau)obj).MakeSound();
//}

monAvion.Senvoler();

//Chat unChat = new();
//unChat.Age = -22;


// On peut créer des objets avec la syntaxe suivante, en utilisant les propriétés qui doivent avoir la possibilité de set les valeurs des champs internes de la classe

ContactDTO monContact = new() // 0x5fa475155
{
    Prenom = "Albert",
    Age = 21
};

// Quand on change la valeur d'une variable référence, on va changer la case mémoire qui stocke la nouvelle valeur. Le garbage collector va ensuite libérer les cases non utilisés par défaut
monContact = new() // 0x5fa47515165
{
    Nom = "MARTEZ"
};


// Si l'on se sert d'un record, le fonctionnement est différent, la case mémoire est conservée et lorsque l'on change la valeur de notre variable, on écrase l'ancienne valeur présente à cette case mémoire (on évite ainsi d'avoir besoin du garbage collector et l'application garde en mémoire où se trouve cette donnée du temps qu'elle est utilisée)
ContactTransit unAutreContact = new("DUPONT", "John", 24); // 0x544FBA4784
Console.WriteLine(unAutreContact.nom);
//unAutreContact.nom = "Albert";
unAutreContact = new("MARTEZ", "John", 12); // 0x544FBA4784

// Le fonctionnement immutable est le même pour toutes les structures
int unNombre = 1_254_254;
unNombre = 2_254;


// Il est possible de créer des valeurs de type primitives sous leur forme référence via les classes 
Int32 unAutreNombre = 2_254;
unAutreNombre = 2_417;