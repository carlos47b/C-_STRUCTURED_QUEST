using System;

class ConsolaControl
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("     CONSOLA DE CONTROL - NIVEL 2");
        Console.WriteLine("=====================================\n");

        MostrarEstado("OPERATIVO", ConsoleColor.White, ConsoleColor.DarkGreen);
        MostrarEstado("INFORMACIÓN", ConsoleColor.Black, ConsoleColor.Cyan);
        MostrarEstado("ADVERTENCIA", ConsoleColor.Black, ConsoleColor.Yellow);
        MostrarEstado("ERROR", ConsoleColor.White, ConsoleColor.DarkRed);

        Console.WriteLine("\n>>> Fin del reporte de estados (colores restaurados).");
    }


    static void MostrarEstado(string mensaje, ConsoleColor colorTexto, ConsoleColor colorFondo)
    {
        Console.ForegroundColor = colorTexto;   
        Console.BackgroundColor = colorFondo;   

        Console.WriteLine($" [ {mensaje} ] ");

        
        Console.ResetColor();
    }
}