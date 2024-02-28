using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotelAgain.Classes
{
    public enum StatutChambre
    {
        Libre,
        Occupe,
        EnNettoyage
    }

    public class Chambre
    {
        public int Numero {  get; set; }
        public int NombreDeLit {  get; set; }
        public decimal Tarif {  get; set; }
        public StatutChambre Statut {  get; set; }
    }
}
