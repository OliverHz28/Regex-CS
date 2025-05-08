using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- Menú de Regex ---");
            Console.WriteLine("1. Validar Correo Electrónico");
            Console.WriteLine("2. Extraer URLs de Texto");
            Console.WriteLine("3. Extraer Telefonos de Texto");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese su opción: ");

            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegexAplicacion.ValidarEmail();
                    break;
                case "2":
                    RegexAplicacion.ExtraerUrls();
                    break;
                case "3":
                    RegexAplicacion.ExtraerTelefonos();
                    break;
                case "4":
                    Console.WriteLine("Saliendo de la aplicación. ¡Hasta luego!");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, intente de nuevo.");
                    break;
            }

            if (!salir)
            {
                Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }
    }
}