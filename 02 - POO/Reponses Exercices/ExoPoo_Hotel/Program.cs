using ExoPoo_Hotel.Classes;

class Program
{
    static void Main()
    {
        Hotel hotel1 = new Hotel();

        Clients client1 = new Clients ("kAly", "LykA", "0658994994");
        Chambres chambre1 = new Chambres(101, StatutChambre.Libre, 2, 150.00m);
        Reservations reservation1 = new Reservations(StatutReservation.Prevu, new List<Chambres> { chambre1 }, client1);

        hotel1.AjouterClient(client1);
        hotel1.AjouterChambre(chambre1);
        hotel1.AjouterReservation(reservation1);

        hotel1.AfficherDetailsHotel();
    }
}
