using System;

class PanelControl
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   PANEL DE CONTROL - NIVEL 1");
        Console.WriteLine("=====================================\n");

        bool salir = false;

    
        while (!salir)
        {
            MostrarMenu();

            Console.Write("\nSeleccione una opción: ");
            string entrada = Console.ReadLine();

            int opcion;
            bool esValido = int.TryParse(entrada, out opcion);

            if (!esValido)
            {
                Console.WriteLine("\n>>> OPCIÓN NO VÁLIDA\n");
                continue; 
            }

          
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n>>> ESTADO DEL SISTEMA: Operativo\n");
                    break;

                case 2:
                    Console.WriteLine("\n>>> TEMPERATURA ACTUAL: 22°C\n");
                    break;

                case 3:
                    Console.WriteLine("\n>>> OPERADORES ACTIVOS: 4\n");
                    break;

                case 4:
                    Console.WriteLine("\n>>> REINICIANDO SISTEMA...\n");
                    Console.WriteLine(">>> SISTEMA REINICIADO CON ÉXITO\n");
                    break;

                case 5:
                    Console.WriteLine("\n>>> CERRANDO PANEL DE CONTROL...");
                    Console.WriteLine("> MISIÓN CUMPLIDA");
                    salir = true;
                    break;

                default:
                    Console.WriteLine("\n>>> OPCIÓN NO VÁLIDA\n");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("========== PANEL DE CONTROL ==========");
        Console.WriteLine("1. Consultar estado");
        Console.WriteLine("2. Mostrar temperatura");
        Console.WriteLine("3. Mostrar operadores");
        Console.WriteLine("4. Reiniciar sistema");
        Console.WriteLine("5. Salir");
        Console.WriteLine("=======================================");
    }
}