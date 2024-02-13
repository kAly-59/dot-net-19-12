using System.ComponentModel.DataAnnotations;

namespace DemoBlazor01.Model
{
    public class User
    {
        public int Id { get; set; }

        [Required, StringLength(10, MinimumLength = 4, ErrorMessage = "Le nom doit faire entre 4 et 10 caractères !")]
        public string? Name { get; set; }

        [Required(ErrorMessage="L'email est requis !")]
        [EmailAddress(ErrorMessage = "L'email n'est pas dans un format valide")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "L'adresse est requise")]
        public string? Adresse { get; set; }

        [Required(ErrorMessage = "Le code postal est requis")]
        public string? CodePostal { get; set; }

        [Required(ErrorMessage = "L'âge est requis")]
        public string? Age { get; set; }

        [Required]
        public DateTime Naissance { get; set; }

        [Required(ErrorMessage = "Veuillez indiquer si vous êtes marié(e)")]
        public bool Marie { get; set; }

        [Required]
        public string? CouleurFavori { get; set; }

        public override string ToString()
        {
            return $"{Name} {Email} {Adresse} {CodePostal} {Age} {Naissance} {Marie} {CouleurFavori}";
        }
    }
   
}
