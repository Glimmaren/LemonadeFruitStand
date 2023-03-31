using LemonadeStand.Interfaces;
using LemonadeStand.Results;
using System.Collections.ObjectModel;

namespace LemonadeStand.Services
{
    public class FruitPressService : IFruitPressService
    {
        
        public FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity)
        {
            return new FruitPressResult(recipe, fruits, moneyPaid, orderedGlassQuantity);
        }
    }
}
