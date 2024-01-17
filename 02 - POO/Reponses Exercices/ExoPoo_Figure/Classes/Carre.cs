using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_Figure.Classes
{
    public class Carre : Figure
    {
        private double _cote;

        public double Cote { get => _cote; set => _cote = value; }

        public Carre(Point _origine, double cote) : base(_origine)
        {
            _cote = cote;
        }

        public override void Deplacement(double deplacementX, double deplacementY)
        {
            Origine.PosX += deplacementX;
            Origine.PosY += deplacementY;
            Console.WriteLine($"Le carré a été déplacé à {deplacementX},{deplacementY}");
        }

        public string CoordonneesDesCotes()
        {
            Point A = new Point(Origine.PosX, Origine.PosY);
            Point B = new Point(Origine.PosX + _cote, Origine.PosY);
            Point C = new Point(Origine.PosX + _cote, Origine.PosY + _cote);
            Point D = new Point(Origine.PosX, Origine.PosY + _cote);

            return
                $"A = {A}\n" +
                $"B = {B}\n" +
                $"C = {C}\n" +
                $"D = {D}\n";
        }

        public override string ToString()
        {
            return $"Coordonnées du carré ABCD (côté = {_cote})";
        }
    }
}
