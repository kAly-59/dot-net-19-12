using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ExoPoo_Figure.Classes
{
    public class Triangle : Figure
    {
        private double _base;
        private double _hauteur;

        public double Base { get => _base; set => _base = value; }
        public double Hauteur { get => _hauteur; set => _hauteur = value; }

        public Triangle(Point _origine, double Base, double Hauteur) : base(_origine)
        {
            _base = Base;
            _hauteur = Hauteur;
        }

        public override void Deplacement(double deplacementX, double deplacementY)
        {
            Origine.PosX += deplacementX;
            Origine.PosY += deplacementY;
            Console.WriteLine($"Le triangle a été déplacé à {deplacementX},{deplacementY}");
        }

        public string CoordonneesDesCotes()
        {
            Point A = new Point(Origine.PosX, Origine.PosY);
            Point B = new Point(Origine.PosX + _base, Origine.PosY);
            Point C = new Point(Origine.PosX + (_base / 2), Origine.PosY + _hauteur);

            return
                $"A = {A}\n" +
                $"B = {B}\n" +
                $"C = {C}\n";
        }

        public override string ToString()
        {
            return $"Coordonnées du triangle ABC (base = {_base}, hauteur = {_hauteur})";
        }
    }
}
