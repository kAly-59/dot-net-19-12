using System.ComponentModel.DataAnnotations;

namespace Marmoset.Models
{
    public class MarmosetViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nom")]
        public string Name { get; set; }
    }
}
