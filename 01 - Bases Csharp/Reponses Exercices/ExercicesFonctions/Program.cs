string nomComplet(string prenom, string nom)
{
    return $"{prenom} {nom}";
}

string nomPrenom = nomComplet("Steve", "Jhonson"); 
Console.WriteLine(nomPrenom);
// Console.WriteLine(nomComplet("Kev", "Vek"));


/*---------------------------*/

int soustraire(int a, int b) 
{
    Console.WriteLine($"Je soustrais {a} et {b}");
    return a - b;
}

int sum = soustraire(2, 1);
Console.WriteLine($"Resultat : {sum} ");


/*----------------------------*/

void quelHeures(string heure = "12h00")
{
    Console.WriteLine($"Il est {heure}");
}

quelHeures();
quelHeures("14h00");

/***************************************/

int compter_lettre_a (string chaine)
{
    int compteurA = 0;
    
    foreach (char c in chaine.ToLower())
    {
        if ( c == 'a' )
        {
            compteurA++;
        }
    }
    return compteurA;
}

Console.WriteLine(compter_lettre_a("C'est le b-a ba"));
Console.WriteLine(compter_lettre_a("mixer"));

/*-------------------------------------------*/



