Console.WriteLine("---TABLE DE MULTIPLICATION---");
Console.WriteLine();

for (int chiffre = 1; chiffre <= 10; chiffre++)
{
    Console.WriteLine(string.Concat(Enumerable.Repeat("-", 21)));
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"|   TABLE DE {chiffre}     |");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(string.Concat(Enumerable.Repeat("-", 21)));

    for (int table = 0; table <= 10; table++)
    {
        int res = chiffre * table;
        Console.WriteLine($"| {chiffre} | x | {table,-2} = {res,-3} |");
        Console.WriteLine(string.Concat(Enumerable.Repeat("-", 21)));
    }
    Console.WriteLine();
}