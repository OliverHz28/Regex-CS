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
            Console.WriteLine("4. Encontrar Palabras que Empiezan con 'a' y Terminan con 'r'");
            Console.WriteLine("5. Eliminar todos los espacios en blanco");
            Console.WriteLine("6. Verificar si es un palíndromo (ignorando espacios)");
            Console.WriteLine("7. Salir");
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
                    RegexAplicacion.EncontrarPalabrasAyR();
                    break;
                case "5":
                    RegexAplicacion.EliminarEspaciosEnBlanco();
                    break;
                case "6":
                    RegexAplicacion.VerificarPalindromo();
                    break;
                case "7":
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