Console.WriteLine("***Calcul de l'air et du périmetre---");

// Carré
Console.WriteLine("Entrez la longeur d'un coté du carré (en cm)");
float nb1 = float.Parse(Console.ReadLine());
float aireCarre = nb1 * nb1;
Console.WriteLine("L'air du carré est : " + aireCarre + " cm2");
float periCarrer = 4 * nb1;
Console.WriteLine("Le Perimètre du carré est : " + periCarrer + " cm");

//Rectancle
Console.WriteLine("Entrez la longeur d'un coté du rectancle (en cm)");
float longueur = float.Parse(Console.ReadLine());

Console.WriteLine("Entrez la largeur d'un coté du rectancle (en cm)");
float largueur = float.Parse(Console.ReadLine());

float aireRectancle = longueur * largueur;
Console.WriteLine("L'air du rectancle est : " + aireRectancle + " cm2");

float periRectancle = 2 * (longueur + largueur);
Console.WriteLine("Le Perimètre du rectancle est : " + periRectancle + " cm");
