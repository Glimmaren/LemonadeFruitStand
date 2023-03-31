using LemonadeStand.Interfaces;

namespace LemonadeStand.ViewModels
{
    public class Recipe : IRecipe
    {
        public string Name { get; }
        public Type AllowedFruit { get; }
        public decimal ConsumptionPerGlass { get; }
        public int PricePerGlass { get; }
        public Recipe(string name, Type allowedFruit, decimal consumptionPerGlass, int pricePerGlass)
        {
            this.Name = name;
            this.AllowedFruit = allowedFruit;
            this.ConsumptionPerGlass = consumptionPerGlass;
            this.PricePerGlass = pricePerGlass;
        }
    }
}
