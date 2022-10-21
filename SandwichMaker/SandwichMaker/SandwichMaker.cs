namespace Program;

public class SandwichMaker
{
    public Sandwich CookSandwich(SandwichIngredient ingredient1, SandwichIngredient ingredient2)
    {
        SandwichIngredient[] sandwichIngredients = { new Bread(), ingredient1, ingredient2 };

        return new Sandwich(sandwichIngredients);
    }

    public Sandwich CookSandwich(SandwichIngredient ingredient1, SandwichIngredient ingredient2, SandwichIngredient ingredient3)
    {
        SandwichIngredient[] coffeeIngredients = { new Bread(), ingredient1, ingredient2, ingredient3 };

        return new Sandwich(coffeeIngredients);
    }
}