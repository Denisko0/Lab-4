namespace Program;

public class Sandwich
{
    private SandwichIngredient[] _ingredients;
    public SandwichIngredient[] Ingredients
    {
        get
        {
            return _ingredients;
        }
    }

    public int Price
    {
        get
        {
            var totalPrice = 0;

            foreach (var ingredient in _ingredients)
            {
                totalPrice += ingredient.Price;
            }

            return totalPrice;
        }
    }

    public Sandwich(SandwichIngredient[] ingredients)
    {
        _ingredients = ingredients;
    }

    public override string ToString()
    {
        var lines = new List<string>();

        foreach (var ingredient in _ingredients)
        {
            lines.Add($"{ingredient.Name} --- {ingredient.Price}$");
        }

        lines.Add($"Total price --- {Price}$\n");

        return String.Join("\n", lines);
    }
}