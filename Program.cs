using System;

class ValidadorDatos
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   VALIDADOR DE DATOS - NIVEL 2");
        Console.WriteLine("=====================================\n");

        
        int edad = LeerEnteroConTryParse("Ingrese su edad: ");
        double salario = LeerDoubleConTryParse("Ingrese su salario: ");
        int anioNacimiento = LeerEnteroConTryParse("Ingrese su año de nacimiento: ");

        Console.WriteLine("\n===== DATOS VALIDADOS =====");
        Console.WriteLine($"Edad             : {edad}");
        Console.WriteLine($"Salario          : {salario:C}"); 
        Console.WriteLine($"Año de nacimiento: {anioNacimiento}");

        
        Console.WriteLine("\n--- Ejemplo adicional usando Parse() con try/catch ---");
        Console.Write("Ingrese un número extra para probar Parse(): ");
        string entradaExtra = Console.ReadLine();

        try
        {
            int numeroExtra = int.Parse(entradaExtra);
            Console.WriteLine($"Número ingresado correctamente: {numeroExtra}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: el texto ingresado no tiene un formato numérico válido.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: el número es demasiado grande o pequeño para un entero.");
        }
    }

   
    static int LeerEnteroConTryParse(string mensaje)
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
                Console.WriteLine("Error: ingrese un número entero válido (sin letras ni símbolos).\n");
            }

        } while (!esValido);

        return valor;
    }

   
    static double LeerDoubleConTryParse(string mensaje)
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
                Console.WriteLine("Error: ingrese un número válido (puede tener decimales).\n");
            }
            else if (valor < 0)
            {
                Console.WriteLine("Error: el salario no puede ser negativo.\n");
                esValido = false;
            }

        } while (!esValido);

        return valor;
    }
}