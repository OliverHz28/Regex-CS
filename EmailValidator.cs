using System;
using System.Text.RegularExpressions;

public class EmailValidator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la dirección de correo electrónico a validar:");
        string? email = Console.ReadLine(); // Usamos string? para indicar que puede ser nulo

        //string pattern = @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        string pattern = @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z]{2,}$";

        if (string.IsNullOrEmpty(email)) // Verificamos si la cadena es nula o vacía
        {
            Console.WriteLine("No se ingresó ninguna dirección de correo electrónico.");
        }
        else
        {
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine($"La dirección de correo electrónico '{email}' es válida.");
            }
            else
            {
                Console.WriteLine($"La dirección de correo electrónico '{email}' no es válida.");
            }
        }

        Console.ReadKey();
    }
}