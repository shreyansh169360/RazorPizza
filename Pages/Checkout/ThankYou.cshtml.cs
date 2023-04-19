using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Data;
using RazorPizza.Models;

namespace RazorPizza.Pages.checkout
{
    [BindProperties(SupportsGet = true)]
    public class ThankYouModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        //the below code is called Dependency-injection and is the way to access DB data.
        private readonly ApplicationDbContext _context;
        public ThankYouModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            pizzaOrder po = new pizzaOrder();
            po.PizzaName = PizzaName;
            po.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(po);
            _context.SaveChanges();
        }
    }
}
