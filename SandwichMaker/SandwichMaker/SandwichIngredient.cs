namespace Program;

public abstract class SandwichIngredient
{
    private string _name;
    public string Name
    {
        get { return _name; }
    }

    private int _price;
    public int Price
    {
        get { return _price; }
    }

    public SandwichIngredient(string name, int price)
    {
        _name = name;
        _price = price;
    }
}
