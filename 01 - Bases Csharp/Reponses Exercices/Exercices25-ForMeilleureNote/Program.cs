Console.WriteLine("---GESTION NOTES---");

double[] notes = new double[5];

Console.WriteLine("Entrez 5 notes !");

for (int i = 0; i < notes.Length; i++)
{
    Console.Write($"Note {i + 1} (sur 20) : ");
    notes[i] = Convert.ToDouble(Console.ReadLine());
    if (notes[i] < 0 || notes[i] > 20)
    {
        Console.WriteLine("ENTRE 0 & 20 !");
        i--;
    }
}

double noteMax = notes[0];
double noteMin = notes[0];
double notesMoyenne = notes[0];

for (int i = 1; i < notes.Length; i++)
{
    if (notes[i] > noteMax)
    {
        noteMax = notes[i];
    }

    if (notes[i] < noteMin)
    {
        noteMin = notes[i];
    }
    notesMoyenne += notes[i];
}

double moyenne = notesMoyenne / notes.Length;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La meilleur note est : {noteMax}");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La plus mauvaise note est : {noteMin}");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"La moyenne est de : {moyenne}");
