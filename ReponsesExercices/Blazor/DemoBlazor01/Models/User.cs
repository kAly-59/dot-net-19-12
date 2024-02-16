using System.ComponentModel.DataAnnotations;

namespace DemoBlazor01.Model
{
    public class User
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Le nom est requis !")]
        public string? Name { get; set; }

        [Required(ErrorMessage="L'email est requis !")]
        [EmailAddress(ErrorMessage = "L'email n'est pas dans un format valide")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "L'adresse est requise")]
        public string? Adresse { get; set; }

        [Required(ErrorMessage = "Le code postal est requis")]
        public string? CodePostal { get; set; }

        [Range(1, 125, ErrorMessage = "L'age doit être compris entre 1 et 125.")]
        public string? Age { get; set; }

        [Required(ErrorMessage = "La date de naissance doit être valide.")]
        public DateTime Naissance { get; set; }

        [Required(ErrorMessage = "Veuillez indiquer si vous êtes marié(e)")]
        public bool Marie { get; set; }

        [Range(1, 4, ErrorMessage = "La couleur est requise.")]
        public Colors CouleurFavori { get; set; }

        public enum Colors
        {
            Nothing, Rouge, Bleu, Noir
        }

        //public override string ToString()
        //{
        //    return $"{Name} {Email} {Adresse} {CodePostal} {Age} {Naissance} {Marie} {CouleurFavori}";
        //}
    }
   
}
