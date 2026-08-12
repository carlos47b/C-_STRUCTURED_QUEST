using System;

class ProcesadorOperadores
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("  PROCESADOR DE OPERADORES - NIVEL 2");
        Console.WriteLine("=====================================\n");

        // Colección de nombres de operadores (arreglo de strings)
        string[] operadores = { "Ana", "Eduardo", "Luis", "Valentina", "Max", "Carlos", "Eva" };

        Console.WriteLine("Lista completa de operadores:");
        foreach (string nombre in operadores)
        {
            Console.WriteLine($" - {nombre}");
        }

        Console.WriteLine("\n===== OPERADORES CON MÁS DE 4 CARACTERES =====");

        // --- foreach + if + String (Length) pedido por el enunciado ---
        foreach (string nombre in operadores)
        {
            if (nombre.Length > 4)
            {
                Console.WriteLine($" - {nombre} ({nombre.Length} caracteres)");
            }
        }
    }
}