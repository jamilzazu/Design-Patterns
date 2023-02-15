namespace Design.Patterns.Patterns.Structural;

public static class Structural
{
    public static void Facade()
    {
        Console.WriteLine("**Structural:");
        Console.WriteLine();

        new Facade.Facade();
    }

    public static void Composite()
    {
        new Composite.Composite();
    }
}