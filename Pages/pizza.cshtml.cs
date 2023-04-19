using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages
{
    public class pizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
         new PizzasModel() { ImageTitle = "Margerita", PizzaName = "Margerita", BasePrice = 2, hasTotamtoSauce = true, hasCheese = true, FinalPrice = 4 },
        new PizzasModel() { ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 2, hasTotamtoSauce=true, hasCheese = true, hasMeat = true, FinalPrice = 5 },
        new PizzasModel() { ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 2, hasTotamtoSauce = true, hasCheese = true, hasHam = true, hasPineapple = true, FinalPrice = 15 },
        new PizzasModel() { ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 2, hasTotamtoSauce = true, hasCheese = true, hasHam = true, hasMushroom = true, FinalPrice = 6 },
        new PizzasModel() { ImageTitle = "MeatFeast", PizzaName = "MeatFeast", BasePrice = 2, hasTotamtoSauce = true, hasCheese = true, hasHam = true, hasMeat = true, FinalPrice = 6 },
        new PizzasModel() { ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 2, hasTotamtoSauce = true, hasCheese = true, hasMushroom = true, FinalPrice = 5 },
        new PizzasModel() { ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 2, hasTotamtoSauce = true, hasCheese = true, hasPeperoni = true, FinalPrice = 5 },
        new PizzasModel() { ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 2, hasTotamtoSauce = true, hasCheese = true, hasTuna = true, FinalPrice = 5 },
        new PizzasModel() { ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 2, hasTotamtoSauce = true, hasCheese = true, hasMushroom = true, hasPineapple = true, FinalPrice = 12 },
        };
        public void OnGet()
        {
        }
    }
}
