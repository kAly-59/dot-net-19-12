Console.WriteLine("--NOYEUX JOEL--");
Console.Write("SAISIR LA HAUTEUR DU SAPIN : ");
int hauteur = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= hauteur; i++)
{
    for (int j = 0; j < hauteur - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < 2 * i - 1; k++)
    {
        Console.Write("@"); 
    }
    Console.WriteLine(); 
}
