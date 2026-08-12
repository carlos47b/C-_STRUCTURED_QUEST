using System;

class AnalizadorNombres
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   ANALIZADOR DE NOMBRES - NIVEL 2");
        Console.WriteLine("=====================================\n");

        string nombreOriginal = LeerTextoValidado("Ingrese el nombre completo: ");

        // --- Manejo de espacios innecesarios ---
        // Trim() quita espacios al inicio y al final.
        // Reemplazamos múltiples espacios internos por uno solo.
        string nombreLimpio = LimpiarEspacios(nombreOriginal);

        int cantidadCaracteres = nombreLimpio.Length;
        string nombreMayusculas = nombreLimpio.ToUpper();
        string nombreMinusculas = nombreLimpio.ToLower();

        Console.WriteLine("\n===== REPORTE DEL NOMBRE =====");
        Console.WriteLine($"Nombre limpio      : \"{nombreLimpio}\"");
        Console.WriteLine($"Cantidad caracteres : {cantidadCaracteres}");
        Console.WriteLine($"En MAYÚSCULAS      : {nombreMayusculas}");
        Console.WriteLine($"en minúsculas      : {nombreMinusculas}");
    }

    // Pide texto y valida que no esté vacío ni sean solo espacios
    static string LeerTextoValidado(string mensaje)
    {
        string entrada;

        do
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Error: el nombre no puede estar vacío.\n");
            }

        } while (string.IsNullOrWhiteSpace(entrada));

        return entrada;
    }

    // Quita espacios al inicio/final y colapsa espacios dobles internos
    static string LimpiarEspacios(string texto)
    {
        string resultado = texto.Trim();

        // Mientras existan espacios dobles, los vamos reemplazando por uno solo
        while (resultado.Contains("  "))
        {
            resultado = resultado.Replace("  ", " ");
        }

        return resultado;
    }
}