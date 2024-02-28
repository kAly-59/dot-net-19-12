using ExoPoo_Figure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_Figure.Classes
{
    public abstract class Figure : Ideplacable
    {
        protected Point _origine;

        public Point Origine { get => _origine; set => _origine = value; }

        protected Figure(Point origine)
        {
            _origine = origine;
        }

        public virtual void Deplacement(double deplacementX, double deplacementY)
        {
            Origine.PosX += deplacementX;
            Origine.PosY += deplacementY;
        }

        public override string ToString()
        {
            return $"Origine: {_origine}";
        }
    }
}

