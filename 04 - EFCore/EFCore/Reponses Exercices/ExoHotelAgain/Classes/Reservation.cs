using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotelAgain.Classes
{
    public enum StatutReservation
    {
       Prevu, 
       Encours, 
       Fini, 
       EnNettoyage
    }
    public class Reservation
    {
        public int ID { get; set; }
        public StatutReservation Statut { get; set; }
        public List<Chambre> Chambres { get; set;}
        public Client Client { get; set; }
    }
}
