using System;

class ClasificadorAlertas
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   CLASIFICADOR DE ALERTAS - NIVEL 1");
        Console.WriteLine("=====================================\n");

        Console.Write("Ingrese el nivel de alerta (0-10): ");
        string entrada = Console.ReadLine();

        int nivel;
        bool esValido = int.TryParse(entrada, out nivel);

        if (!esValido)
        {
            Console.WriteLine("\n>>> NIVEL DE ALERTA INVÁLIDO");
            return; 
        }

        if (nivel == 0)
        {
            Console.WriteLine("\n>>> NORMAL");
        }
        else if (nivel >= 1 && nivel <= 3)
        {
            Console.WriteLine("\n>>> ADVERTENCIA");
        }
        else if (nivel >= 4 && nivel <= 6)
        {
            Console.WriteLine("\n>>> PELIGRO");
        }
        else if (nivel >= 7 && nivel <= 9)
        {
            Console.WriteLine("\n>>> CRÍTICO");
        }
        else if (nivel == 10)
        {
            Console.WriteLine("\n>>> EMERGENCIA");
        }
        else
        {
            
            Console.WriteLine("\n>>> NIVEL DE ALERTA INVÁLIDO");
        }
    }
}