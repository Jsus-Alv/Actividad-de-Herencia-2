// Ejemplo 1: Herencia Basica
   
class Animal 
{
    public string Movimiento{get; set;}
    public string Habla{get; set;}
}

class Perro : Animal
{
    public Perro()
    {
        Movimiento = "El perro camina";
        Habla = "El perro ladra";
    }
}

class Programa
{
    static void Main()
    {
        Perro perro = new Perro();

        Console.WriteLine(perro.Movimiento);
        Console.WriteLine(perro.Habla);
    }
}