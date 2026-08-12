using System;

class VerificacionEdad
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   VERIFICACIÓN DE EDAD - NIVEL 1");
        Console.WriteLine("=====================================\n");

        int edad = LeerEnteroValidado("Ingrese la edad del operador: ");

     
        if (edad >= 18)
        {
            Console.WriteLine("\n>>> Acceso permitido");
        }
        else
        {
            Console.WriteLine("\n>>> Acceso restringido");
        }
    }

    
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
            else if (valor < 0)
            {
                Console.WriteLine("Error: la edad no puede ser negativa.\n");
                esValido = false;
            }

        } while (!esValido);

        return valor;
    }
}