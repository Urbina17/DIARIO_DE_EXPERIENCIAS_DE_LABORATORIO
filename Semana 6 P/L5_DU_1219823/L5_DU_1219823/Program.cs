internal class Program
{
    private static void Main(string[] args)
    {
       
        Console.WriteLine("Ejercicio 1");
        Console.Write("Ingrese número entero: ");
        string input = Console.ReadLine();
        int num;

        if (int.TryParse(input, out num))
        {
            if (num > 0)
            {
                Console.WriteLine("Resultado: el numero es positivo.");
            }
            else if (num < 0)
            {
                Console.WriteLine("Resultado: el numero es negativo");
            }
            else
            {
                Console.WriteLine("Resultado: el número es cero");
            }
        }
        else { Console.WriteLine("El número ingresado no es válido"); }
    
        Console.WriteLine("Ejercicio 2");
        Console.Write("Ingrese un número del 1 al 7: ");
        int numero = int.Parse(Console.ReadLine());
        if (numero < 1 || numero > 7)
        {
            Console.WriteLine("Error, el numero debe de estar entre 1 y 7");
        }
        else
        {
            string dia;
            switch (numero)
            {
                case 1:
                    dia = "lunes";
                    break;
                case 2:
                    dia = "martes";
                    break;
                case 3:
                    dia = "miércoles";
                    break;
                case 4:
                    dia = "jueves";
                    break;
                case 5:
                    dia = "viernes";
                    break;
                case 6:
                    dia = "sábado";
                    break;
                default:
                    dia = "domingo";
                    break;
            }
            Console.WriteLine("Dia: " + dia);
        }
            }
        }

    
