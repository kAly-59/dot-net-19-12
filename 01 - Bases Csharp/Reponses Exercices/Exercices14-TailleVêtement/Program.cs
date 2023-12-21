Console.WriteLine("QUELLE TAILLE ??");

Console.Write("ENTREZ LA TAILLE : ");
int taille = int.Parse(Console.ReadLine());
Console.Write("ENTREZ LE POIDS : ");
int poids = int.Parse(Console.ReadLine());

// Conditions pour CAT 1
if ((taille >= 145 && taille <= 169) && (poids >= 43 && poids <= 47))
{
    Console.WriteLine("CAT 1");
}
else if ((taille >= 145 && taille <= 166) && (poids >= 48 && poids <= 53))
{
    Console.WriteLine("CAT 1");
}
else if ((taille >= 145 && taille <= 163) && (poids >= 54 && poids <= 59))
{
    Console.WriteLine("CAT 1");
}
else if ((taille >= 145 && taille <= 160) && (poids >= 60 && poids <= 65))
{
    Console.WriteLine("CAT 1");
}
// Conditions pour CAT 2
else if ((taille >= 169 && taille <= 178) && (poids >= 48 && poids <= 53))
{
    Console.WriteLine("CAT 2");
}
else if ((taille >= 166 && taille <= 175) && (poids >= 54 && poids <= 59))
{
    Console.WriteLine("CAT 2");
}
else if ((taille >= 163 && taille <= 172) && (poids >= 60 && poids <= 65))
{
    Console.WriteLine("CAT 2");
}
else if ((taille >= 160 && taille <= 169) && (poids >= 66 && poids <= 71))
{
    Console.WriteLine("CAT 2");
}
// Conditions pour CAT 3
else if ((taille >= 178 && taille <= 183) && (poids >= 54 && poids <= 59))
{
    Console.WriteLine("CAT 3");
}
else if ((taille >= 175 && taille <= 183) && (poids >= 60 && poids <= 65))
{
    Console.WriteLine("CAT 3");
}
else if ((taille >= 172 && taille <= 183) && (poids >= 66 && poids <= 71))
{
    Console.WriteLine("CAT 3");
}
else if ((taille >= 163 && taille <= 183) && (poids >= 72 && poids <= 77))
{
    Console.WriteLine("CAT 3");
}
// Condition pour CHANGER DE MAGASIN
else if (taille <= 145 || taille >= 183 || poids <= 43 || poids >= 77)
{
    Console.WriteLine("CHANGE DE BOUTIQUE");
}
