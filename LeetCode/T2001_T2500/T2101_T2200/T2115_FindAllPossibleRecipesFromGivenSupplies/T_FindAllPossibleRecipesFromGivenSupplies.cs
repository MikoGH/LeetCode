namespace LeetCode.T2001_T2500.T2101_T2200.T2115_FindAllPossibleRecipesFromGivenSupplies;

public class T_FindAllPossibleRecipesFromGivenSupplies
{
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies)
    {
        var dctRecipes = new Dictionary<string, IList<string>>(recipes.Length);
        var dctIngredients = new Dictionary<string, bool>(recipes.Length + supplies.Length);
        var visited = new HashSet<string>(recipes.Length);

        for (int i = 0; i < supplies.Length; i++)
        {
            dctIngredients.Add(supplies[i], true);
        }

        for (int i = 0; i < recipes.Length; i++)
        {
            dctRecipes.Add(recipes[i], ingredients[i]);
        }

        for (int i = 0; i < recipes.Length; i++)
        {
            Dfs(dctRecipes, dctIngredients, visited, recipes[i]);
        }

        return dctIngredients.Where(x => x.Value).Select(x => x.Key).Except(supplies).ToList();
    }

    private bool Dfs(Dictionary<string, IList<string>> dctRecipes, Dictionary<string, bool> dctIngredients, HashSet<string> visited, string recipe)
    {
        var result = true;
        visited.Add(recipe);

        foreach (var ingredient in dctRecipes[recipe])
        {
            if (dctIngredients.TryGetValue(ingredient, out bool hasIngredient))
            {
                result &= hasIngredient;
            }
            else if (dctRecipes.ContainsKey(ingredient) && !visited.Contains(ingredient))
            {
                result &= Dfs(dctRecipes, dctIngredients, visited, ingredient);
            }
            else
            {
                result = false;
            }
        }

        dctIngredients[recipe] = result;

        return result;
    }
}
