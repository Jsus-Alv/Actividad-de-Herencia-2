// Ejemplo 5: Herencia con clases abstractas 

abstract class Animal
{
    public abstract void HacerSonido();  
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
        Animal perro = new Perro();
        perro.HacerSonido();  

        Animal gato = new Gato();
        gato.HacerSonido();   
    }
}
