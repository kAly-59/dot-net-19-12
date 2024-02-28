class Program
{
    static void Main(string[] args)
    {
        List<Citernes> listeDesCiternes = new List<Citernes>
        {
            new Citernes(10, 100, 50),
            new Citernes(20, 100, 70),
            new Citernes(30, 100, 100),
            new Citernes()
        };

        foreach (Citernes citerne in listeDesCiternes)
        {
            Console.WriteLine($"Détails de la citerne => {citerne}");
            Console.WriteLine(citerne.RemplissageCiterne());
            citerne.RemplirAvecLitres(50);
            Console.WriteLine($"Détails de la citerne après remplissage => {citerne}:");
            Console.WriteLine(citerne.RemplissageCiterne());
            Console.WriteLine();
        }
    }
}


