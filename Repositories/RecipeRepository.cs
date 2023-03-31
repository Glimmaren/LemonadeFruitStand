using LemonadeStand.Interfaces;
using LemonadeStand.ViewModels.Friuts;
using LemonadeStand.ViewModels;

namespace LemonadeStand.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        //--------------- Test Notes ---------------
        //Här hade jag slängt in en UnitOfwork i en större applikation
        //som pratat med en DbContext, microservice eller dylikt, men det kändes ännu mer overkill
        //än vad det redan är=)
        //I de fallen hade vi kört Asyncront

        //Mock context or datahandeling!
        private readonly List<IRecipe> _recipes;
        public RecipeRepository() 
        {
            _recipes = new List<IRecipe>
            {
                new Recipe("Apple Lemonade", typeof(Apple), 2.5M, 10),
                new Recipe("Melon Lemonade", typeof(Melon), 0.5M, 12),
                new Recipe("Orange Lemonade", typeof(Orange), 1M, 9)
            };
        }

        public List<IRecipe> GetRecipes()
        {
            return _recipes;
        }
    }
}
