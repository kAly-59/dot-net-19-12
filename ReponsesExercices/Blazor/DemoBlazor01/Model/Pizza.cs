﻿using System.Collections.Generic;

namespace DemoBlazor01.Model
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<Ingredient> Ingredients { get; set; }

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
