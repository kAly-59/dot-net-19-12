using System.ComponentModel;

namespace WebApplication1.Models
{
    public class ContactViewModel
    {
        public int Id { get; set; }

        [DisplayName("Nom")]
        public string? Nom { get; set; }

        [DisplayName("Prenom")]
        public string? Prenom { get; set; }

        [DisplayName("Email")]
        public string? Email { get; set; }

    }
}
