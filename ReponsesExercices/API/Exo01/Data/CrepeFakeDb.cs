using Exo01.Model;

namespace Exo01.Data
{
    public class CrepeFakeDb
    {
        public List<Crepe> Crepes { get; set; } = new List<Crepe>()
        {
            new Crepe()
            {
                Id = 1,
                Name = "Suprise du chef",
                Diameter = 14,
                Topping1 = Topping.Mayonnaise,
                Topping2 = Topping.Camenbert
            },

             new Crepe()
            {
                Id = 2,
                Name = "Suprise du sous-chef",
                Diameter = 26,
                Topping1 = Topping.MappleSirup,
                Topping2 = Topping.Egg
            },

        };
    }
}
