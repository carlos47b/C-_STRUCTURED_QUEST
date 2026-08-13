using System;

class GeneradorCodigos
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   GENERADOR DE CÓDIGOS - NIVEL 2");
        Console.WriteLine("=====================================\n");

        // --- Random: un solo objeto reutilizado para todas las generaciones ---
        // (crear un Random nuevo en cada vuelta del ciclo puede generar
        // números repetidos si se hace muy rápido, por eso se declara una sola vez)
        Random generador = new Random();

        // Reto adicional: cuántos códigos generar
        int cantidad = LeerEnteroValidado("¿Cuántos códigos desea generar?: ");

        Console.WriteLine("\n===== CÓDIGOS GENERADOS =====");

        for (int i = 1; i <= cantidad; i++)
        {
            string codigo = GenerarCodigoSeisDigitos(generador);
            Console.WriteLine($"Código {i}: {codigo}");
        }
    }

    // Genera un número aleatorio entre 100000 y 999999 (siempre 6 dígitos)
    static string GenerarCodigoSeisDigitos(Random generador)
    {
        int numero = generador.Next(100000, 1000000); // límite superior exclusivo
        return numero.ToString();
    }

    // Lee y valida un entero positivo mayor a cero
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
            else if (valor <= 0)
            {
                Console.WriteLine("Error: la cantidad debe ser mayor a cero.\n");
                esValido = false;
            }

        } while (!esValido);

        return valor;
    }
}