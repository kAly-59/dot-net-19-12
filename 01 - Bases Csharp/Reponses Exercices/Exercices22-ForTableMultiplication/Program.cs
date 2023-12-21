Console.WriteLine("---TABLE DE MULTIPLICATION---");

for (int chiffre = 0; chiffre < 11; chiffre++)
{
    Console.WriteLine($"TABLE DE {chiffre} :");
    for (int table = 1; table < 11; table++)
    {
        int res = chiffre * table;
        Console.WriteLine($"- {chiffre} x {table} = {res}");
    }
    Console.WriteLine();
}