using System;
using System.Text.RegularExpressions;

public static class RegexAplicacion
{
    // Método para validar un correo electrónico
    public static void ValidarEmail()
    {
        Console.WriteLine("\nIngrese la dirección de correo electrónico a validar:");
        string? email = Console.ReadLine();
        string pattern = @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z]{2,}$";

        if (string.IsNullOrEmpty(email))
        {
            Console.WriteLine("Error: La dirección de correo electrónico no puede estar vacía.");
        }
        else if (!Regex.IsMatch(email, pattern))
        {
            Console.WriteLine($"Error: La dirección de correo electrónico '{email}' no es válida.");
        }
        else
        {
            Console.WriteLine($"La dirección de correo electrónico '{email}' es válida.");
        }
    }

    // Método para extraer URLs de un texto
    public static void ExtraerUrls()
    {
        Console.WriteLine("\nIngrese el texto del cual desea extraer URLs:");
        string? text = Console.ReadLine();
        string pattern = @"https?://(?:www\.)?[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*(?:\.[a-zA-Z]{2,})+(?::\d+)?(?:[/?#][a-zA-Z0-9&%$-_.+!*'(),;:@=/]*)?";

        if (!string.IsNullOrEmpty(text))
        {
            MatchCollection matches = Regex.Matches(text, pattern);

            if (matches.Count > 0)
            {
                Console.WriteLine("URLs encontradas:");
                foreach (Match match in matches)
                {
                    Console.WriteLine("URL: " + match.Value);
                }
            }
            else
            {
                Console.WriteLine("No se encontraron URLs en el texto.");
            }
        }
        else
        {
            Console.WriteLine("El texto ingresado está vacío.");
        }
    }

 // Método para extraer números de teléfono
    public static void ExtraerTelefonos()
    {
        Console.WriteLine("\nIngrese el texto del cual desea extraer números de teléfono:");
        string? text = Console.ReadLine();
        string pattern = @"(?:\+?(\d{1,3}))?[-.\s]?\(?(\d{3})\)?[-.\s]?(\d{3})[-.\s]?(\d{4})(?:\s*(?:ext|ext.)\s*(\d+))?";

        if (!string.IsNullOrEmpty(text))
        {
            MatchCollection matches = Regex.Matches(text, pattern);

            if (matches.Count > 0)
            {
                Console.WriteLine("Números de teléfono encontrados:");
                foreach (Match match in matches)
                {
                    Console.WriteLine("Número de teléfono: " + match.Value);
                }
            }
            else
            {
                Console.WriteLine("No se encontraron números de teléfono en el texto.");
            }
        }
        else
        {
            Console.WriteLine("El texto ingresado está vacío.");
        }
    }
}