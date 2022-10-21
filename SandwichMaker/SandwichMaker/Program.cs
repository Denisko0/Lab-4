namespace Program;

class Program
{
    static void Main()
    {
        var SandwichMaker = new SandwichMaker();

        var sandwich1 = SandwichMaker.CookSandwich(new Sausages(), new Cheese());

        var sandwich2 = SandwichMaker.CookSandwich(new Sausages(), new Cheese(), new Ketchup());

        Console.WriteLine(sandwich1);
        Console.WriteLine(sandwich2);
    }
}