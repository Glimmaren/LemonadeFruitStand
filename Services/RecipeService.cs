using LemonadeStand.Interfaces;
using LemonadeStand.ViewModels;
using LemonadeStand.ViewModels.Friuts;
using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace LemonadeStand.Services
{

    public class RecipeService : IRecipeService
    {

        List<IRecipe>? Recipes { get; }
        private readonly IRecipeRepository _recipeRepository;

        public RecipeService(IRecipeRepository repo)
        {
            _recipeRepository= repo;
        }

        public List<IRecipe> GetRecipes()
        {
            try
            {
                return _recipeRepository.GetRecipes();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
   
}
