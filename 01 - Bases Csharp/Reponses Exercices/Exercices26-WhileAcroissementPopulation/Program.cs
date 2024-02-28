Console.WriteLine("---ACC POPS---");

double popA = 96809;
int popC = 120000;
int annee = 2015;
double acc = 0.89 / 100;

while (popA <= popC)
{
    popA += popA * acc;
    annee++;
}

Console.WriteLine($"Il faudra {annee - 2015} ans, nous serons en {annee}");
Console.WriteLine($"La population sera de {popA} habitants");
