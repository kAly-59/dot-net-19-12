using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ExoPoo_Figure.Classes
{
    public class Rectangle : Figure
    {
        private double _longueur;
        private double _largeur;

        public double Longueur { get => _longueur; set => _longueur = value; }
        public double Largeur { get => _largeur; set => _largeur = value; }

        public Rectangle(Point _origine, double Longueur, double Largeur) : base(_origine)
        {
            _longueur = Longueur;
            _largeur = Largeur;
        }

        public override void Deplacement(double deplacementX, double deplacementY)
        {
            Origine.PosX += deplacementX;
            Origine.PosY += deplacementY;
            Console.WriteLine($"Le rectangle a été déplacé à {deplacementX},{deplacementY}");
        }

        public string CoordonneesDesCotes()
        {
            Point A = new Point(Origine.PosX, Origine.PosY);
            Point B = new Point(Origine.PosX + _longueur, Origine.PosY);
            Point C = new Point(Origine.PosX + _longueur, Origine.PosY + _largeur);
            Point D = new Point(Origine.PosX, Origine.PosY + _largeur);

            return
                $"A = {A}\n" +
                $"B = {B}\n" +
                $"C = {C}\n" +
                $"D = {D}\n";
        }

        public override string ToString()
        {
            return $"Coordonnées du rectangle ABCD (longueur = {_longueur}, largeur = {_largeur})";
        }
    }
}
