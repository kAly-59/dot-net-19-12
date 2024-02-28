using System;

class Program
{
    static void Main(string[] args)
    {    
        List<ExoPoo_Chaise> listeDeChaises = new List<ExoPoo_Chaise>
        {
            new ExoPoo_Chaise(4, "rouge", "bois"),
            new ExoPoo_Chaise(3, "bleu", "plastique"),
            new ExoPoo_Chaise(6, "vert", "métal"),
            new ExoPoo_Chaise(4, "violet", "fer")
        };
   
        foreach (ExoPoo_Chaise chaise in listeDeChaises)
        {
            Console.WriteLine(chaise);
        }
    }
}
