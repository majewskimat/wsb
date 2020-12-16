using ObiektDwa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burgerownia.NewFolder
{
    class Mati
    {
        internal Burgerownia.API.Repositories.IngredientRepository ingredientRepository;
        internal Order order;
        public Mati()
        {
            ingredientRepository = new Burgerownia.API.Repositories.IngredientRepository();
            order = new Order();
        }

    }
}
