using Design.Patterns.Interface;

namespace Design.Patterns.Patterns.Structural.Adapter;

public class ThirdPartyAnimal
{
    private const string talk = "squawk";

    protected internal ThirdPartyAnimal()
    {
    }

    public static string Talk()
    {
        return talk;
    }
}

public class ThirdPartyAnimalAdapter : IAnimal
{
    public ThirdPartyAnimalAdapter(ThirdPartyAnimal animal)
    {
    }

    public string MakeSound()
    {
        return ThirdPartyAnimal.Talk();
    }

    public string GetSpecie()
    {
        throw new NotImplementedException();
    }
}