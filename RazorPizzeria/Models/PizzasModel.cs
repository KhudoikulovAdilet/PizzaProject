namespace RazorPizzeria.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public int BasePrice { get; set; } = 2;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Mashroom { get; set; }
        public bool Tuna { get; set; }
        public bool PineApple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }
        public float Finalprice { get; set; }
    }
}
