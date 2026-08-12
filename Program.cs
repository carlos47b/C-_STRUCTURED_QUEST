using System;

class CalculadoraRecursos
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   CALCULADORA DE RECURSOS - NIVEL 1");
        Console.WriteLine("=====================================\n");

       
        int trabajadores = LeerEnteroValidado("Ingrese la cantidad de trabajadores: ");

       
        double horas = LeerDoubleValidado("Ingrese las horas trabajadas: ");

      
        double consumoPorHora = LeerDoubleValidado("Ingrese el consumo por hora (recurso/hora): ");

        
        double consumoTotal = trabajadores * horas * consumoPorHora;

      
        Console.WriteLine("\n===== REPORTE DE CONSUMO =====");
        Console.WriteLine($"Trabajadores      : {trabajadores}");
        Console.WriteLine($"Horas trabajadas  : {horas}");
        Console.WriteLine($"Consumo por hora  : {consumoPorHora}");
        Console.WriteLine($"Consumo total     : {consumoTotal}");
        Console.WriteLine("================================");
    }

    
    static int LeerEnteroValidado(string mensaje)
    {
        int valor;
        bool esValido;

        do
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();

           

            if (!esValido)
            {
                Console.WriteLine("Error: debe ingresar un número entero válido.\n");
            }
            else if (valor < 0)
            {
                Console.WriteLine("Error: el valor no puede ser negativo.\n");
                esValido = false; 
            }

        } while (!esValido);

        return valor;
    }

 
    static double LeerDoubleValidado(string mensaje)
    {
        double valor;
        bool esValido;

        do
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();

            esValido = double.TryParse(entrada, out valor);

            if (!esValido)
            {
                Console.WriteLine("Error: debe ingresar un número válido.\n");
            }
            else if (valor < 0)
            {
                Console.WriteLine("Error: el valor no puede ser negativo.\n");
                esValido = false;
            }

        } while (!esValido);

        return valor;
    }
}