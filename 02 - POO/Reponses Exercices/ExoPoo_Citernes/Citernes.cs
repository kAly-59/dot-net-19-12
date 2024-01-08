using System;
using System.Collections.Generic;

class Citernes
{
    // Attributes
    private double _poidsVide = 0;
    private double _capTotal = 100;
    private double _lvlRemplissage = 0;
    private static int _totalRemplissage = 0;

    // Properties
    public double PoidsVide 
    { 
        get => _poidsVide; 
        set => _poidsVide = value; 
    }
    public double CapTotal 
    { 
        get => _capTotal; 
        private set => _capTotal = value; 
    }
    public double LvlRemplissage 
    { 
        get => _lvlRemplissage; 
        private set => _lvlRemplissage = value; 
    }

    // Methode
    public Citernes()
    {
        // Constructeur sans paramètres
    }

    public Citernes(double poidsVide, double capTotal, double lvlRemplissage)
    {
        PoidsVide = poidsVide;
        CapTotal = capTotal;
        LvlRemplissage = lvlRemplissage;
    }
    public double PoidsTotalCiterne()
    {
        return PoidsVide + (CapTotal * (LvlRemplissage / 100));
    }

    public string RemplissageCiterne()
    {
        double poidsTotal = PoidsTotalCiterne();

        if (poidsTotal <= 100)
        {
            return "La citerne est remplie à moins de 100 %.";
        }
        else
        {
            return "La citerne est remplie à 100 %.";
        }
    }

    public void RemplirAvecLitres(double litres)
    {
        double pourcentageAjoute = (litres / CapTotal) * 100;

        if (LvlRemplissage + pourcentageAjoute <= 100)
        {
            LvlRemplissage += pourcentageAjoute;
            Console.WriteLine($"La citerne a été remplie de {litres} litres.");
        }
        else
        {
            Console.WriteLine("Impossible de remplir au-delà de la capacité maximale.");
        }
    }

    public override string ToString()
    {
        return $"PoidsVide: {PoidsVide}, CapTotal: {CapTotal}, LvlRemplissage: {LvlRemplissage}";
    }
}
