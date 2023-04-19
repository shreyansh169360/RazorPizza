using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages.Forms
{
    public class customPizzaModel : PageModel // this is the viewModel (pageMode)
    {
        [BindProperty] //binding the actual Model with ViewModel
        public PizzasModel Pizza { get; set; }  //this is the actual Model
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() //catch anything submitted with post 
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.hasTotamtoSauce) PizzaPrice += 1;
            if (Pizza.hasCheese) PizzaPrice += 1;
            if (Pizza.hasPineapple) PizzaPrice += 10;
            if (Pizza.hasPeperoni) PizzaPrice += 1;
            if (Pizza.hasMushroom) PizzaPrice += 1;
            if (Pizza.hasTuna) PizzaPrice += 1;
            if (Pizza.hasHam) PizzaPrice += 1;
            if (Pizza.hasMeat) PizzaPrice += 1;

            return RedirectToPage("/checkout/checkout" , new {Pizza.PizzaName , PizzaPrice });
        }
    }
}
