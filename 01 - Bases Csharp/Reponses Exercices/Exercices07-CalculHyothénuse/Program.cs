Console.WriteLine("---Calcul de la longueur de hypythenuse---");


Console.Write("Entrez la longeur d'un coté de hypothenuse (en cm) : ");
float longueur = float.Parse(Console.ReadLine());
Console.Write("Entrez la largeur d'un coté de hypothenuse (en cm) : ");
float largueur = float.Parse(Console.ReadLine());

double longueurHypot = Math.Sqrt(longueur * longueur + largueur * largueur);
Console.WriteLine("Le longueur de l'hypythenuse est : " + longueurHypot + " cm");


