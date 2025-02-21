

DVDPlayer dvd = new DVDPlayer();
Projector projector = new Projector();
SoundSystem sound = new SoundSystem();
HomeTheaterFacade h= new HomeTheaterFacade(dvd, projector, sound);
h.WatchMovie("The Avengers");
h.EndMovie();

public class DVDPlayer
{
    public void TurnOn() => Console.WriteLine("DVD Player is ON");
    public void PlayMovie(string movie) => Console.WriteLine($"Playing movie: {movie}");
    public void TurnOff() => Console.WriteLine("DVD Player is OFF");
}

public class Projector
{
    public void TurnOn() => Console.WriteLine("Projector is ON");
    public void SetInput(string source) => Console.WriteLine($"Projector input set to {source}");
    public void TurnOff() => Console.WriteLine("Projector is OFF");
}

public class SoundSystem
{
    public void TurnOn() => Console.WriteLine("Sound System is ON");
    public void SetVolume(int level) => Console.WriteLine($"Sound volume set to {level}");
    public void TurnOff() => Console.WriteLine("Sound System is OFF");
}
public class HomeTheaterFacade
{
    private readonly DVDPlayer dvd;
    private readonly Projector projector;
    private readonly SoundSystem sound;

    public HomeTheaterFacade(DVDPlayer dvd, Projector projector, SoundSystem sound)
    {
        this.dvd = dvd;
        this.projector = projector;
        this.sound = sound;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("\nStarting Movie Experience...\n");
        dvd.TurnOn();
        projector.TurnOn();
        projector.SetInput("DVD");
        sound.TurnOn();
        sound.SetVolume(50);
        dvd.PlayMovie(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("\nShutting down the Home Theater...\n");
        dvd.TurnOff();
        projector.TurnOff();
        sound.TurnOff();
    }
}

