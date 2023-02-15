using Design.Patterns.Entity;

namespace Design.Patterns.Patterns.Behavioral.Observer;

public sealed class AnimalSoundSubject
{
    private readonly Animal _animal;

    public AnimalSoundSubject(Animal animal)
    {
        _animal = animal;
    }

    public event EventHandler<string> AnimalSoundEvent;

    public void MakeSound()
    {
        var sound = _animal.MakeSound();
        OnAnimalSound(sound);
    }

    private void OnAnimalSound(string sound)
    {
        AnimalSoundEvent?.Invoke(this, sound);
    }
}