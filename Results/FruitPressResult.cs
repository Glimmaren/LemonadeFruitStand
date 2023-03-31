using LemonadeStand.Interfaces;
using LemonadeStand.ViewModels;
using System.Collections.ObjectModel;

namespace LemonadeStand.Results
{
    public class FruitPressResult
    {
        //-------------Test Note ---------------------
        // Jag har valt att lägga mycket data hantering i denna klassen,
        // kanske borde man gjort det i "FruitPressService" men eftersom
        // den bara hanterar intern data så känndes det rätt att lägga det här.

        public IRecipe Recipe { get; }
        //Collection<IFruit> Fruits { get; }
        public int OrderedGlassQuantity { get; }
        public decimal MoneyNeeded { get; }
        public decimal MoneyDiff { get; }
        public decimal FruitsNeeded { get; }
        public decimal FruitDiff { get; }

        //Validations
        public bool IsEnoughFruit = false;
        public bool IsEnoghtMoney = false;
        public bool IsSuccess = false;

        public FruitPressResult(IRecipe recipe, Collection<IFruit> fruits, decimal moneyPaid, int orderedGlassQuantity)
        {
            Recipe = recipe;
            OrderedGlassQuantity = orderedGlassQuantity;

            //Check if enough money and fruit
            MoneyNeeded = Recipe.PricePerGlass * OrderedGlassQuantity;
            MoneyDiff = moneyPaid - (Recipe.PricePerGlass * OrderedGlassQuantity);

            FruitsNeeded = Recipe.ConsumptionPerGlass * OrderedGlassQuantity;
            FruitDiff = fruits.Count - (OrderedGlassQuantity * Recipe.ConsumptionPerGlass);

            //Validations
            if (MoneyDiff >= 0)
                IsEnoghtMoney = true;
            else
                IsEnoghtMoney = false;

            if (FruitDiff >= 0)
                IsEnoughFruit = true;
            else
                IsEnoughFruit = false;

            if(IsEnoghtMoney && IsEnoughFruit)
                IsSuccess = true;
            else
                IsSuccess = false;
                         
        }
    }
}
