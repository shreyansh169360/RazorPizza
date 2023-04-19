using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Data;
using RazorPizza.Models;

namespace RazorPizza.Pages.checkout
{
    [BindProperties(SupportsGet =true)]    //this directly binds the variables below to view . enables to recieve data fromany other viewmodel

    public class checkoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }


        
        public void OnGet()
        {
            //here u recieve the data (the object sent by customPizza view model)
            if (string.IsNullOrEmpty(PizzaName))
            {
                PizzaName = "Custom";
            }
            if(string.IsNullOrEmpty(ImageTitle))
            {
                ImageTitle = "Create";
            }
        }
    }
}
