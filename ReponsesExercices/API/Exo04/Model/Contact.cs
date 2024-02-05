namespace Exo04.Model
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Prenom { get; set; }

        public DateTime DateNaissance { get; set; }
        public int Age { get; set; }
        public string Avatar { get; set; }
        public Sexe Genre { get; set; }    
    }

    public enum Sexe
    {
        Homme, Femme
    }
}


