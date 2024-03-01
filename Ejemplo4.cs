// Ejemplo 4: Herencia Multiple de Interfaces

interface IPlayer
{
    void Play();
    void Pause();
}

interface IRecorder
{
    void Record();
}

class MusicPlayer : IPlayer, IRecorder
{
    public void Play()
    {
        Console.WriteLine("Reproduciendo...");
    }

public void Pause()
{
    Console.WriteLine("Pausando...");
}

public void Record()
{
    Console.WriteLine("Grabando...");
}
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Cual acción desea realizar:\nPlay\nPause\nRecord");
        string? respuesta = Console.ReadLine();

        MusicPlayer reproductor = new MusicPlayer();

        if (respuesta?.ToLower() == "play")
        {
            reproductor.Play();
        }

        else if (respuesta?.ToLower() == "pause")
        {
            reproductor.Pause();
        }

        else if (respuesta?.ToLower() == "record")
        {
            reproductor.Record();
        }

        else
        {
            Console.WriteLine("Acción no reconocida");
        }
    }
}