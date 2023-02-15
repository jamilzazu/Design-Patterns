namespace Design.Patterns.Patterns.Structural.Facade;

public class Facade
{
    public Facade()
    {
        Console.WriteLine("Facade:");
        var animalFacade = new AnimalFacade();
        Console.WriteLine($"The dog makes {animalFacade.GetDogSound()}");
        Console.WriteLine($"The cat makes {animalFacade.GetCatSound()}");
        Console.WriteLine($"The cow makes {animalFacade.GetCowSound()}");
        Console.WriteLine();
    }
}