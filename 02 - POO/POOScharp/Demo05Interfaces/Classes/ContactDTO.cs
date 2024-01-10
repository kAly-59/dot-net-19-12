using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05Interfaces.Classes
{
    // Lorsque l'on créé une classe servant uniquement à faire transiter des données, on ne pas pas s'amuser à créer des champs, des propriétés et un constructeur. Cela pour deux raisons: 

    // * On doit écrire beaucoup de ligne de code pour au final une classe ayant un objectif très précis et qui va exister en mémoire durant un laps de temps relativement court
    // * On aimerait se passer de devoir écrire X variations de notre constructeur de façon à rendre l'initialisation de notre classe plus aisée, que l'on veuille remplir tous ses champs, aucun, ou seulement certains
    internal class ContactDTO
    {
        //private string _nom;

        //public string Nom { get; set; }

        //public ContactDTO(string nom)
        //{
        //    _nom = nom;
        //}

        public string Nom { get; init; } = "DOE";
        public string Prenom { get; init; } = "John";
        public int Age { get; init; } = 0;


    }
}
