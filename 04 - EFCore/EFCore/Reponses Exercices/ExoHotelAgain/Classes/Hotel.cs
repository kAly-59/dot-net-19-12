using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotelAgain.Classes
{
    public class Hotel
    {
        public List<Client> Clients { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Chambre> Chambres { get; set; }
    }
}
