Console.WriteLine("---ACC POPS---");

double popA = 96809;
int annee;
int popC = 120000;
double acc = 0.89 / 100;

for (annee = 2015; popA <= popC; annee++)
{
    popA += popA * acc;
}

Console.WriteLine($"Il faudra {annee - 2015} ans, nous serons en {annee}");
Console.WriteLine($"La population sera de {popA} habitants");


