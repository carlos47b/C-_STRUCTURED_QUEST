using System;

class MenuPersistente
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("     MENÚ PERSISTENTE - NIVEL 2");
        Console.WriteLine("=====================================\n");

        int opcion;

        // --- do-while: el bloque se ejecuta al menos una vez ---
        // por eso el menú se muestra siempre, aunque la condición
        // de salida se evalúe hasta el final del bloque.
        do
        {
            MostrarMenu();

            Console.Write("\nSeleccione una opción: ");
            string entrada = Console.ReadLine();

            bool esValido = int.TryParse(entrada, out opcion);

            if (!esValido)
            {
                Console.WriteLine("\n>>> OPCIÓN NO VÁLIDA\n");
                opcion = 0; // valor "neutro" para que el switch caiga en default
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n>>> Opción 1 ejecutada.\n");
                    break;

                case 2:
                    Console.WriteLine("\n>>> Opción 2 ejecutada.\n");
                    break;

                case 3:
                    Console.WriteLine("\n>>> Opción 3 ejecutada.\n");
                    break;

                case 4:
                    Console.WriteLine("\n>>> Opción 4 ejecutada.\n");
                    break;

                case 5:
                    Console.WriteLine("\n>>> Saliendo del sistema...");
                    Console.WriteLine("> MISIÓN CUMPLIDA");
                    break;

                default:
                    if (esValido) // solo mostramos esto si fue número pero fuera de rango
                        Console.WriteLine("\n>>> OPCIÓN NO VÁLIDA\n");
                    break;
            }

        } while (opcion != 5); // se repite hasta que el usuario elija "Salir"
    }

    static void MostrarMenu()
    {
        Console.WriteLine("============ MENÚ PRINCIPAL ============");
        Console.WriteLine("1. Opción 1");
        Console.WriteLine("2. Opción 2");
        Console.WriteLine("3. Opción 3");
        Console.WriteLine("4. Opción 4");
        Console.WriteLine("5. Salir");
        Console.WriteLine("==========================================");
    }
}