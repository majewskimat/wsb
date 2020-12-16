using System.Collections.Generic;

namespace ObiektDwa
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsVege { get; set; }
        public bool HasAlergens { get; set; }
        public List<Alergen> Alergens { get; set; }


        public Ingredient(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Ingredient(int id, string name, double price)
           : this(name,price)
        {
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}