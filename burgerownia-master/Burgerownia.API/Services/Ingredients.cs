using Burgerownia.API.Services;
using System.Collections.Generic;

namespace ObiektDwa
{
    public class Ingredients : List<Ingredient>
    {
        private List<Ingredient> listOfIngredients;
        public Ingredients(params int[] ingredient)
        {
            IngredientService service = new IngredientService();
            listOfIngredients = new List<Ingredient>();

            for (int i = 0; i < ingredient.Length; i++)
            {
                listOfIngredients.Add(
                    service.GetIngredient(ingredient[i])
                    );
            }
        }

        public List<Ingredient> GetAll() => listOfIngredients;
    }
}