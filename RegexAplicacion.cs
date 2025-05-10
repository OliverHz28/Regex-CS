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

    public static void EncontrarPalabrasAyR()
    {
        Console.WriteLine("\nIngrese el texto donde desea encontrar palabras que empiezan con 'a' y terminan con 'r':");
        string? text = Console.ReadLine();
        string pattern = @"\ba\w*r\b";

        if (!string.IsNullOrEmpty(text))
        {
            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase); // Usamos IgnoreCase para ser insensible a mayúsculas

            if (matches.Count > 0)
            {
                Console.WriteLine("Palabras encontradas:");
                foreach (Match match in matches)
                {
                    Console.WriteLine("Palabra: " + match.Value);
                }
            }
            else
            {
                Console.WriteLine("No se encontraron palabras que empiecen con 'a' y terminen con 'r' en el texto.");
            }
        }
        else
        {
            Console.WriteLine("El texto ingresado está vacío.");
        }
    }

    public static void EliminarEspaciosEnBlanco()
    {
        Console.WriteLine("\nIngrese el texto del cual desea eliminar los espacios en blanco:");
        string? text = Console.ReadLine();

        if (!string.IsNullOrEmpty(text))
        {
            string textoSinEspacios = Regex.Replace(text, @"\s+", "");
            Console.WriteLine("Texto sin espacios en blanco:");
            Console.WriteLine(textoSinEspacios);
        }
        else
        {
            Console.WriteLine("El texto ingresado está vacío.");
        }
    }

    public static void VerificarPalindromo()
    {
        Console.WriteLine("\nIngrese el texto para verificar si es un palíndromo (los espacios serán ignorados):");
        string? text = Console.ReadLine();

        if (!string.IsNullOrEmpty(text))
        {
            // Eliminar todos los espacios en blanco y convertir a minúsculas para la comparación
            string textoSinEspacios = Regex.Replace(text, @"\s+", "").ToLower();

            // Invertir la cadena
            string textoInvertido = new string(textoSinEspacios.Reverse().ToArray());

            // Comparar la cadena original (sin espacios) con su versión invertida
            if (textoSinEspacios == textoInvertido)
            {
                Console.WriteLine($"'{text}' es un palíndromo (ignorando espacios).");
            }
            else
            {
                Console.WriteLine($"'{text}' no es un palíndromo (ignorando espacios).");
            }
        }
        else
        {
            Console.WriteLine("El texto ingresado está vacío.");
        }
    }

}