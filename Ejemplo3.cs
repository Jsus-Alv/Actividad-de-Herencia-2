// Ejemplo 3: Herencia con método override
class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("Un sonido");
    }
}

class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra");
    }
}

class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El gato maulla");
    }
}

class Program
{
static void Main()
    {
        Animal animal = new Animal();
        animal.HacerSonido();

        Perro perro = new Perro();
        perro.HacerSonido();

        Gato gato = new Gato();
        gato.HacerSonido();
    }
}