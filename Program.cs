using System;

class FiltroSeguridad
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   FILTRO DE SEGURIDAD - NIVEL 2");
        Console.WriteLine("=====================================\n");

        // Secuencia de códigos de ejemplo a procesar
        string[] codigos = { "OK", "ERROR", "OK", "WARNING", "ERROR", "EXIT", "OK", "OK" };

        Console.WriteLine("Procesando secuencia de códigos...\n");

        foreach (string codigo in codigos)
        {
            // --- continue: ignora "ERROR" y pasa al siguiente elemento ---
            if (codigo == "ERROR")
            {
                Console.WriteLine($" - {codigo} -> ignorado (continue)");
                continue;
            }

            // --- break: detiene todo el procesamiento al encontrar "EXIT" ---
            if (codigo == "EXIT")
            {
                Console.WriteLine($" - {codigo} -> deteniendo procesamiento (break)");
                break;
            }

            // Cualquier otro código se procesa normalmente
            Console.WriteLine($" - {codigo} -> procesado correctamente");
        }

        Console.WriteLine("\n>>> Procesamiento finalizado.");
    }
}