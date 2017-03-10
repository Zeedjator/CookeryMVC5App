using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookery.Domain;

namespace Cookery.Domain.Abstract
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipe> Recipes { get; }
        IEnumerable<Ingredient> Ingredients { get; }
        void SaveRecipe(Recipe recipe);

        Recipe DeleteRecipe(int recipeId);
    }
}
