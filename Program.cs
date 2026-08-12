using System;

class RelojSistema
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("     RELOJ DEL SISTEMA - NIVEL 2");
        Console.WriteLine("=====================================\n");

        DateTime ahora = DateTime.Now;

        Console.WriteLine("===== FECHA Y HORA ACTUAL =====");
        Console.WriteLine($"Fecha y hora completa : {ahora}");
        Console.WriteLine($"Día                    : {ahora.Day}");
        Console.WriteLine($"Mes                    : {ahora.Month} ({ahora:MMMM})");
        Console.WriteLine($"Año                    : {ahora.Year}");
        Console.WriteLine($"Hora                   : {ahora:HH:mm:ss}");
        Console.WriteLine($"Día de la semana       : {ahora.DayOfWeek}");

        // --- Reto adicional: calcular edad a partir de fecha de nacimiento ---
        Console.WriteLine("\n===== CÁLCULO DE EDAD =====");
        DateTime fechaNacimiento = LeerFechaValidada("Ingrese su fecha de nacimiento (dd/mm/aaaa): ");

        int edad = CalcularEdad(fechaNacimiento, ahora);

        Console.WriteLine($"\nFecha de nacimiento: {fechaNacimiento:dd/MM/yyyy}");
        Console.WriteLine($"Edad actual: {edad} años");
    }

    // Pide una fecha como texto y la valida con TryParse (no truena con texto inválido)
    static DateTime LeerFechaValidada(string mensaje)
    {
        DateTime fecha;
        bool esValido;

        do
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();
            esValido = DateTime.TryParse(entrada, out fecha);

            if (!esValido)
            {
                Console.WriteLine("Error: formato de fecha inválido. Use dd/mm/aaaa.\n");
            }
            else if (fecha > DateTime.Now)
            {
                Console.WriteLine("Error: la fecha de nacimiento no puede ser en el futuro.\n");
                esValido = false;
            }

        } while (!esValido);

        return fecha;
    }


    static int CalcularEdad(DateTime nacimiento, DateTime fechaActual)
    {
        int edad = fechaActual.Year - nacimiento.Year;

       
        if (fechaActual.Month < nacimiento.Month ||
           (fechaActual.Month == nacimiento.Month && fechaActual.Day < nacimiento.Day))
        {
            edad--;
        }

        return edad;
    }
}