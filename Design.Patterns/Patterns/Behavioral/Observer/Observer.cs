using Design.Patterns.Entity;

namespace Design.Patterns.Patterns.Behavioral.Observer;

public class Observer
{
    public Observer()
    {
        Console.WriteLine("Observer:");

        var dog = new Animal("dog", new Dog());
        var cat = new Animal("cat", new Cat());
        var cow = new Animal("cow", new Cow());

        var dogSoundSubject = new AnimalSoundSubject(dog);
        var catSoundSubject = new AnimalSoundSubject(cat);
        var cowSoundSubject = new AnimalSoundSubject(cow);
        
        dogSoundSubject.AnimalSoundEvent += AnimalSoundObserver.AnimalSoundEventHandler;
        catSoundSubject.AnimalSoundEvent += AnimalSoundObserver.AnimalSoundEventHandler;
        cowSoundSubject.AnimalSoundEvent += AnimalSoundObserver.AnimalSoundEventHandler;

        dogSoundSubject.MakeSound();
        catSoundSubject.MakeSound();
        cowSoundSubject.MakeSound();

        Console.WriteLine();
    }
}