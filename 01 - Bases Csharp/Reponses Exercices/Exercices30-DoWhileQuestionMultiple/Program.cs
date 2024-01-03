// See https://aka.ms/new-console-template for more information
Console.WriteLine("Question multiple");
Console.WriteLine("Quelle est l'intruction pour sortir d'une boucle C# ?");
Console.WriteLine("A) QUIT");
Console.WriteLine("B) CONTINUE");
Console.WriteLine("C) BREAK");
Console.WriteLine("D) EXIT");

bool end = false;

while (!end)
{
    Console.Write("Entrez la bonne réponse : ");
    string rep = Console.ReadLine()!;

    if (rep != "C")
    {
        Console.WriteLine("T'ES MAUVAIS JACK");
    }
    else if (rep == "C") 
    {
        Console.WriteLine("QUE LA WIN");
        end = true;
    }
    
}

