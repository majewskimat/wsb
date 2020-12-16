using ObiektDwa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burgerownia.API.Repositories
{
    public class IngredientRepository
    {
        public List<Ingredient> Ingredients = new List<Ingredient>()
        {
            new Ingredient(1,"kotlet drobiowy",10.00),
            new Ingredient(2,"kotlet wieprzowy",20.00),
            new Ingredient(3,"salata lodowa",5.00)
        };

        public List<Ingredient> GetAll() => Ingredients;

    }
}
