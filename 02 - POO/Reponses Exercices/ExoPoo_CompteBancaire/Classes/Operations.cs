using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_CompteBancaire.Classes
{
    internal class Operation
    {
        private int numero;
        private decimal montant;
        private TypeOperation _type;

        protected int Numero { get => numero; set => numero = value; }
        protected double Montant { get => montant; set => montant = value; }
        protected bool Statut { get => statut; set => statut = value; }
    }
}
