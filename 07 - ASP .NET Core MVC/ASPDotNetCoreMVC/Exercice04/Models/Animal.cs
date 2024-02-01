using System.ComponentModel.DataAnnotations;
namespace Exercice04.Models;


public class Animal
{
    public int Id { get; set; }
    [Display(Name = "Prénom de l'animal")]
    public string? FirstName { get; set; }
    [Display(Name = "Age de l'animal")]
    public int? Age { get; set; }
    [Display(Name = "Espèce de l'animal")]
    public string? Species { get; set; }

}
