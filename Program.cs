using System;

class SistemaAutorizacion
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   SISTEMA DE AUTORIZACIÓN - NIVEL 1");
        Console.WriteLine("=====================================\n");

  
        int edad = LeerEnteroValidado("Ingrese la edad del operador: ", 0, 120);

     
        int nivelSeguridad = LeerEnteroValidado("Ingrese el nivel de seguridad (1-5): ", 1, 5);


        bool credencialActiva = LeerBooleanoValidado("¿Credencial activa? (S/N): ");

        bool accesoAutorizado = (edad >= 18) && (nivelSeguridad >= 3) && credencialActiva;

        Console.WriteLine("\n===== RESULTADO =====");
        if (accesoAutorizado)
        {
            Console.WriteLine(">>> ACCESO AUTORIZADO");
            Console.WriteLine("> MISIÓN CUMPLIDA");
        }
        else
        {
            Console.WriteLine(">>> ACCESO DENEGADO");


            if (edad < 18)
                Console.WriteLine("   - Motivo: edad insuficiente.");
            if (nivelSeguridad < 3)
                Console.WriteLine("   - Motivo: nivel de seguridad insuficiente.");
            if (!credencialActiva)
                Console.WriteLine("   - Motivo: credencial inactiva.");
        }
    }


    static int LeerEnteroValidado(string mensaje, int min, int max)
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
                Console.WriteLine($"Error: debe ingresar un número entero válido.\n");
            }
            else if (valor < min || valor > max)
            {
                Console.WriteLine($"Error: el valor debe estar entre {min} y {max}.\n");
                esValido = false;
            }

        } while (!esValido);

        return valor;
    }

    static bool LeerBooleanoValidado(string mensaje)
    {
        string entrada;

        do
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine().Trim().ToUpper();

            if (entrada != "S" && entrada != "N")
            {
                Console.WriteLine("Error: responda solo con S (Sí) o N (No).\n");
            }

        } while (entrada != "S" && entrada != "N");

        return entrada == "S";
    }
}