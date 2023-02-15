namespace Design.Patterns.Patterns.Behavioral;

public static class Behavioral
{
    public static void Strategy()
    {
        Console.WriteLine("**Behavioral:");
        Console.WriteLine();

        new Strategy.Strategy();
    }

    public static void Visitor()
    {
        new Visitor.Visitor();
    }

    public static void Observer()
    {
        new Observer.Observer();
    }
}