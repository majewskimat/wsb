using burgerownia.BazaDanych_SQLite;
using Burgerownia.NewFolder;
using ObiektDwa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Burgerownia
{
    public partial class Form2 : Form
    {
        API.Repositories.BurgerRepository burgerRepository;
        API.Repositories.IngredientRepository ingredientRepository;
        private Mati mati;
        public Form2()
        {
            mati = new Mati();
            InitializeComponent();
            DataToListBox();
            ingredientRepository = new API.Repositories.IngredientRepository();
            Ingredient[] allIngredients = ingredientRepository.GetAll().ToArray();
            //ListBox_BurgerIngredients.Items.AddRange(allIngredients);
            burgerRepository = new API.Repositories.BurgerRepository();
            List<Burger> burgers = burgerRepository.GetAll();
        }
        private void DataToListBox()
        {
            List<Burger> a = (new SQLite_DB().DataToList());
            ListBox_BurgerIngredients.Items.AddRange(a.ToArray());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ListBox_BurgerIngredients.Items.Clear();
            ListBox_BurgerIngredients.Items.AddRange(burgerRepository.Get(1).Ingredients.ToArray());
           // mati.order.AddItem(new Burger("Mario Burger", new Ingredients(1, 2, 3).GetAll()));
            //label1.Text = mati.order.OrderItems[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mati.order.AddItem(new Burger(1,
                "Master Burger",
                new List<Ingredient>() {
                    new Ingredient(
                        "masterMeat",
                        1_000_000.00) }
                ));

            //label1.Text = mati.order.OrderItems[1].ToString();
        }

    }
}
