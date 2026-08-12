using System;

class GeneradorTablas
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   GENERADOR DE TABLAS - NIVEL 2");
        Console.WriteLine("=====================================\n");

        int numero = LeerEnteroValidado("Ingrese el número a multiplicar: ");
        int inicio = LeerEnteroValidado("Ingrese el inicio del rango: ");
        int fin = LeerEnteroValidado("Ingrese el fin del rango: ");

        // Validamos que el rango tenga sentido (inicio no debe ser mayor que fin)
        while (inicio > fin)
        {
            Console.WriteLine("\nError: el inicio no puede ser mayor que el fin. Intente de nuevo.\n");
            inicio = LeerEnteroValidado("Ingrese el inicio del rango: ");
            fin = LeerEnteroValidado("Ingrese el fin del rango: ");
        }

        Console.WriteLine($"\n===== TABLA DEL {numero} (de {inicio} a {fin}) =====");

        // --- Ciclo for pedido por el enunciado ---
        for (int i = inicio; i <= fin; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }

    // Lee y valida un número entero cualquiera (puede ser negativo, ej: multiplicadores negativos)
    static int LeerEnteroValidado(string mensaje)
    {
        int valor;
        bool esValido;

        do
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();
            esValido = int.TryParse(entrada, out valor);

            if (!esValido)
            {
                Console.WriteLine("Error: debe ingresar un número entero válido.\n");
            }

        } while (!esValido);

        return valor;
    }
}