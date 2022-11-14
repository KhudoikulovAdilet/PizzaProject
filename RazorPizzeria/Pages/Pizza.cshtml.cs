using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Bolognese", 
                PizzaName="Bolognese", 
                BasePrice = 2, 
                TomatoSauce = true, 
                Cheese = true, 
                Finalprice = 4 },
                 new PizzasModel(){ImageTitle="Carbonara",
                PizzaName="Carbonara",
                BasePrice = 3,
                TomatoSauce = true,
                Cheese = true,
                Finalprice = 6 },
                 new PizzasModel(){ImageTitle="Margerita",
                PizzaName="Margerita",
                BasePrice = 4,
                TomatoSauce = true,
                Cheese = true,
                Finalprice = 8 },


        };
        public void OnGet()
        {
        }
    }
}
