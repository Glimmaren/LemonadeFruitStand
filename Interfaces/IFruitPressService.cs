using LemonadeStand.Results;
using System.Collections.ObjectModel;

namespace LemonadeStand.Interfaces
{
    public interface IFruitPressService
    {
        FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity);
    }
}
