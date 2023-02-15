namespace Design.Patterns.Patterns.Creational;

public static class Creational
{
    public static void FactoryMethod()
    {
        Console.WriteLine("**Creational:");
        Console.WriteLine();

        new FactoryMethod.FactoryMethod();
    }

    public static void AbstractFactory()
    {
        new AbstractFactory.AbstractFactory();
    }

    public static void Builder()
    {
        new Builder.Builder();
    }
}