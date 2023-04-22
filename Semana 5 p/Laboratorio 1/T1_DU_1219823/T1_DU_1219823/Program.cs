internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Mi segundo programa");
        Console.WriteLine("Ingrese su nombre");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su edad");
        string Edad = Console.ReadLine();
        Console.WriteLine("Ingrese su carrera");
        string Carrera = Console.ReadLine();
        Console.WriteLine("Ingrese su carné");
        string Carné = Console.ReadLine();
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad: " + Edad);
        Console.WriteLine("Carrera: " + Carrera);
        Console.WriteLine(Carné);
        Console.Write("Soy " + Nombre);
        Console.Write(" tengo " + Edad);
        Console.Write(" años y estudio la carrera de " + Carrera);
        Console.Write(" ,mi número de carné es " + Carné);
        Console.ReadKey();


    }
}