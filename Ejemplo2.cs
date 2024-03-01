// Ejemplo 2: Herencia con constructores

class Animal 
{
    public string Movimiento { get; set; }
    public string Habla { get; set; }

    public Animal(string movimiento, string habla)
    {
        Movimiento = movimiento;
        Habla = habla;
    }
}

class Perro : Animal
{
    public Perro() : base("El perro camina", "El perro ladra")
    {
    }
}

class Program
{
    static void Main()
    {
        Perro perro = new Perro();

        Console.WriteLine(perro.Movimiento);
        Console.WriteLine(perro.Habla);
    }
}
