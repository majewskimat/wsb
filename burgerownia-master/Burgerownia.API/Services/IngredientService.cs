using Burgerownia.API.Repositories;
using ObiektDwa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burgerownia.API.Services
{
    class IngredientService
    {
        IngredientRepository repo;
        public IngredientService()
        {
            repo = new IngredientRepository();
        }

        public Ingredient GetIngredient(int id) =>
            repo.Ingredients.Find(ingredient => ingredient.Id == id);
    }
}
