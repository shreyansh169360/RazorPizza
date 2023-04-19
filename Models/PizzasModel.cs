namespace RazorPizza.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool hasTotamtoSauce { get; set; }
        public bool hasCheese { get; set; }
        public bool hasPeperoni{ get; set; }
        public bool hasMushroom { get; set; }
        public bool hasTuna { get; set; }
        public bool hasPineapple { get; set; }
        public bool hasHam { get; set; }
        public bool hasMeat { get; set; }
        public float FinalPrice { get; set; }


    }
}
