using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPersonnage.Classes
{
    public class Personnage
    {
        public Personnage(int id, string pseudo, int pointDeVie, int armure, int degats, DateTime dateDeCreation, int nombrePersonneTues)
        {
            Id = id;
            Pseudo = pseudo;
            PointDeVie = pointDeVie;
            Armure = armure;
            Degats = degats;
            DateDeCreation = dateDeCreation;
            NombrePersonneTues = nombrePersonneTues;
        }

        public int Id { get; set; }
        public string Pseudo {  get; set; }
        public int PointDeVie { get; set; }
        public int Armure { get; set; }
        public int Degats { get; set; }
        public DateTime DateDeCreation { get; set; }
        public int NombrePersonneTues { get; set; }
    }
}
