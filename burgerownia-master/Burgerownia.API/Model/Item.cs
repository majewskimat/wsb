using System.Collections.Generic;

namespace ObiektDwa
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get => TallPrice(); }
        public List<Ingredient> Ingredients { get; set; }
        public bool IsService { get; set; }

        private double TallPrice()
        {
            double sum = 0;
            Ingredients.ForEach(each => sum += each.Price);
            return sum;
        }
        public Item(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
        }

        public Item(string name, List<Ingredient> ingredients)
            : this(name)
        {
            ingredients.ForEach(ingredient => this.Ingredients.Add(ingredient));
        }

        public override string ToString()
        {
            string toString;

            if (Ingredients.Count == 0)
            {
                toString = Name;
            }
            else
            {
                toString = Name + $" ({string.Join<Ingredient>(',', Ingredients.ToArray())})";
            }

            return toString;
        }
    }

}