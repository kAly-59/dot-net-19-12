using ExoPoo_Pendu;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME !!!");
        Pendu jeuPendu = new Pendu(10);

        while (jeuPendu.NbEssais > 0)
        {
            Console.Write("Entrez une lettre : ");
            char lettre = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (!jeuPendu.TestChar(lettre))
            {
                Console.WriteLine("Entrer une lettre valide.");
                continue;
            }

            if (!jeuPendu.TestChar(lettre))
            {
                Console.WriteLine("Lettre incorrecte !");
            }
        }
    }
}


