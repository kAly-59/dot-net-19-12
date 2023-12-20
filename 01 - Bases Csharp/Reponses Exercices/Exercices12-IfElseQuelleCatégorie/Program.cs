Console.Write("Dans quel cat mon enfant est il? (Entrez un age) : ");
int age = int.Parse(Console.ReadLine());

if (age >= 3 && age <= 6)
{
    Console.WriteLine("Votre enfant est dans la cat " + "baby");
}
else if (age >= 7 && age <= 8)
{
    Console.WriteLine("Votre enfant est dans la cat " + "Poussin");
}
else if (age >= 9 && age <= 10)
{
    Console.WriteLine("Votre enfant est dans la cat " + "Pupille");
}
else if (age >= 11 && age <= 12)
{
    Console.WriteLine("Votre enfant est dans la cat " + "Minime");
}
else if (age >= 13 && age <= 18)
{
    Console.WriteLine("Votre enfant est dans la cat " + "Cadet");
}
else if (age >= 18)
{
    Console.WriteLine("Votre enfant est considéré comme adulte.");
}