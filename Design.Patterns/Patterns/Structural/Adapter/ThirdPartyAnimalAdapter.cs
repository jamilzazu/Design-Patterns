using Design.Patterns.Interface;

namespace Design.Patterns.Patterns.Structural.Adapter;

public class ThirdPartyAnimal
{
    public string Talk()
    {
        return "squawk";
    }
}

public class ThirdPartyAnimalAdapter : IAnimal
{
    private ThirdPartyAnimal animal;

    public ThirdPartyAnimalAdapter(ThirdPartyAnimal animal)
    {
        this.animal = animal;
    }

    public string MakeSound()
    {
        return animal.Talk();
    }
}