using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoBlazor01.Model
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est requis !")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Le prix est requis !")]
        public decimal Price { get; set; }
        public List<Pizza.Ingredient> Ingredients { get; set; } = new List<Pizza.Ingredient>();

        public Pizza()
        {
            Ingredients = new List<Ingredient>();
        }

        public enum Ingredient
        {
            SauceTomate,
            CremeFraiche,
            Mozzarrela,
            Emmental,
            Chevre,
            Bacon,
            Poulet,
            Boeuf,
            Saumon,
            Oignon,
            Poivron,
            Tomate,
            Artichaut,
            Peperoni,
            Jambon,
            Champignon,
            Aneth,
            Oeuf,
            Olive,
            Gorgonzola,
            Ananas
        }
    }
}
