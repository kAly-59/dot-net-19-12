using System.ComponentModel.DataAnnotations;

namespace Demo01.Models;

public class Contact
{
    // L'annotation Display précise comment on devrait afficher une certaine propriété dans la partie présentation
    // Elle sera utile pour Html.DisplayNameFor(...)

    public int Id { get; set; }

    
    [Display(Name = "Prénom")] // par défaut le display correspond au nom de la propriété => "FirstName"
    public string? FirstName { get; set; }


    [Display(Name = "Nom")]
    public string? LastName { get; set; }


    [Display(Name = "Adresse Mail")]
    public string? Email { get; set; }


    [Display(Name = "Numéro de téléphone")]
    public string? Phone { get; set; }
}
