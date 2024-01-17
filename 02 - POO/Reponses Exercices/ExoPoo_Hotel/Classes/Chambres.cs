using System;

public enum StatutChambre
{
    Libre,
    Occupe,
    EnNettoyage
}

public class Chambres
{
    private int _numero;
    private int _nombreDelits;
    private decimal _tarif;

    public StatutChambre Statut { get; set; }
    public int Numero { get => _numero; set => _numero = value; }
    public int NombreDelits { get => _nombreDelits; set => _nombreDelits = value; }
    public decimal Tarif { get => _tarif; set => _tarif = value; }

    public Chambres(int numero, StatutChambre statut, int nombreDelits, decimal tarif)
    {
        Numero = numero;
        Statut = statut;
        NombreDelits = nombreDelits;
        Tarif = tarif;
    }

    public void AfficherDetailsChambre()
    {
        Console.WriteLine($"Numéro de la chambre: {Numero}");
        Console.WriteLine($"Statut: {Statut}");
        Console.WriteLine($"Nombre de lits: {NombreDelits}");
        Console.WriteLine($"Tarif: {Tarif}");
    }
}
