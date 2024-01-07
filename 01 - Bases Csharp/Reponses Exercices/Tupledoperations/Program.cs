class program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Entrez 2 nombres : ");
        double nb1 = Convert.ToDouble(Console.ReadLine());
        double nb2 = Convert.ToDouble(Console.ReadLine());

        MyFunction(nb1, nb2);
    }

    static void MyFunction(double nb1, double nb2)
    {
        double sum = nb1 + nb2;
        double diff = nb1 - nb2;
        double quotien = nb1 / nb2;
        double produit = nb1 * nb2;

        Console.WriteLine("Somme : " + sum);
        Console.WriteLine("Différence : " + diff);
        Console.WriteLine("Quotient : " + quotien);
        Console.WriteLine("Produit : " + produit);
    }

}
