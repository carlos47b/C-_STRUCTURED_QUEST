using System;
using System.Collections.Generic;

class OperacionCodigoRojo
{
    static List<string> operadoresRegistrados = new List<string>();
    static List<string> historialAccesos = new List<string>();
    static Random generadorAleatorio = new Random();
    static int accesosExitosos = 0;
    static int accesosFallidos = 0;
    static int codigosGenerados = 0;

    static void Main(string[] args)
    {
        bool salir = false;

        do
        {
            MostrarEncabezado();
            MostrarMenu();

            Console.Write("\nSeleccione una opción: ");
            string entrada = Console.ReadLine();
            int opcion;
            bool esValido = int.TryParse(entrada, out opcion);

            if (!esValido)
            {
                Console.WriteLine("\n>>> OPCIÓN NO VÁLIDA");
                Pausar();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    RegistrarOperador();
                    break;
                case 2:
                    SimularAcceso();
                    break;
                case 3:
                    GenerarCodigoSeguridad();
                    break;
                case 4:
                    MostrarEstadisticas();
                    break;
                case 5:
                    MostrarFechaHora();
                    break;
                case 6:
                    Console.WriteLine("\n>>> CERRANDO SISTEMA...");
                    Console.WriteLine("> MISIÓN CUMPLIDA");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("\n>>> OPCIÓN NO VÁLIDA");
                    break;
            }

            if (!salir) Pausar();

        } while (!salir);
    }

    static void MostrarEncabezado()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("=====================================");
        Console.WriteLine("     OPERACIÓN: CÓDIGO ROJO");
        Console.WriteLine("     Centro de Control - .NET 10");
        Console.WriteLine("=====================================");
        Console.ResetColor();
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n1. Registrar operador");
        Console.WriteLine("2. Simular acceso");
        Console.WriteLine("3. Generar código de seguridad");
        Console.WriteLine("4. Ver estadísticas");
        Console.WriteLine("5. Fecha y hora del sistema");
        Console.WriteLine("6. Salir");
    }

    static void RegistrarOperador()
    {
        Console.WriteLine("\n----- REGISTRO DE OPERADOR -----");

        string nombre;
        do
        {
            Console.Write("Nombre del operador: ");
            nombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombre))
                Console.WriteLine("Error: el nombre no puede estar vacío.");
        } while (string.IsNullOrWhiteSpace(nombre));

        nombre = nombre.Trim();
        while (nombre.Contains("  "))
            nombre = nombre.Replace("  ", " ");

        int edad = LeerEnteroValidado("Edad del operador: ", 0, 120);

        operadoresRegistrados.Add(nombre);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n>>> Operador \"{nombre}\" ({edad} años) registrado con éxito.");
        Console.ResetColor();
    }

    static void SimularAcceso()
    {
        Console.WriteLine("\n----- SIMULACIÓN DE ACCESO -----");

        if (operadoresRegistrados.Count == 0)
        {
            Console.WriteLine("No hay operadores registrados. Registre uno primero.");
            return;
        }

        Console.WriteLine("Operadores disponibles:");
        foreach (string op in operadoresRegistrados)
            Console.WriteLine($" - {op}");

        Console.Write("\nIngrese el nombre del operador: ");
        string nombre = Console.ReadLine();

        int edad = LeerEnteroValidado("Edad: ", 0, 120);
        int nivelSeguridad = LeerEnteroValidado("Nivel de seguridad (1-5): ", 1, 5);
        bool credencialActiva = LeerBooleano("¿Credencial activa? (S/N): ");

        bool acceso = operadoresRegistrados.Contains(nombre) &&
                      edad >= 18 && nivelSeguridad >= 3 && credencialActiva;

        string marcaTiempo = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        if (acceso)
        {
            accesosExitosos++;
            historialAccesos.Add($"[{marcaTiempo}] {nombre} - ACCESO CONCEDIDO");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n>>> ACCESO CONCEDIDO");
        }
        else
        {
            accesosFallidos++;
            historialAccesos.Add($"[{marcaTiempo}] {nombre} - ACCESO DENEGADO");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n>>> ACCESO DENEGADO");
        }
        Console.ResetColor();
    }

    static void GenerarCodigoSeguridad()
    {
        Console.WriteLine("\n----- GENERADOR DE CÓDIGOS -----");
        int cantidad = LeerEnteroValidado("¿Cuántos códigos desea generar?: ", 1, 100);

        for (int i = 1; i <= cantidad; i++)
        {
            int codigo = generadorAleatorio.Next(100000, 1000000);
            Console.WriteLine($"Código {i}: {codigo}");
            codigosGenerados++;
        }
    }

    static void MostrarEstadisticas()
    {
        Console.WriteLine("\n----- ESTADÍSTICAS DEL SISTEMA -----");
        Console.WriteLine($"Operadores registrados : {operadoresRegistrados.Count}");
        Console.WriteLine($"Accesos exitosos        : {accesosExitosos}");
        Console.WriteLine($"Accesos fallidos         : {accesosFallidos}");
        Console.WriteLine($"Códigos generados        : {codigosGenerados}");

        Console.WriteLine("\nÚltimos accesos registrados:");
        if (historialAccesos.Count == 0)
        {
            Console.WriteLine(" (sin registros aún)");
        }
        else
        {
            int inicio = Math.Max(0, historialAccesos.Count - 5);
            for (int i = inicio; i < historialAccesos.Count; i++)
                Console.WriteLine($" - {historialAccesos[i]}");
        }
    }

    static void MostrarFechaHora()
    {
        DateTime ahora = DateTime.Now;
        Console.WriteLine("\n----- FECHA Y HORA DEL SISTEMA -----");
        Console.WriteLine($"Fecha completa   : {ahora:dd/MM/yyyy}");
        Console.WriteLine($"Hora             : {ahora:HH:mm:ss}");
        Console.WriteLine($"Día              : {ahora.Day}");
        Console.WriteLine($"Mes              : {ahora:MMMM}");
        Console.WriteLine($"Año              : {ahora.Year}");
        Console.WriteLine($"Día de la semana : {ahora.DayOfWeek}");
    }

    static int LeerEnteroValidado(string mensaje, int min, int max)
    {
        int valor;
        bool esValido;
        do
        {
            Console.Write(mensaje);
            esValido = int.TryParse(Console.ReadLine(), out valor);
            if (!esValido)
                Console.WriteLine("Error: ingrese un número entero válido.");
            else if (valor < min || valor > max)
            {
                Console.WriteLine($"Error: el valor debe estar entre {min} y {max}.");
                esValido = false;
            }
        } while (!esValido);
        return valor;
    }

    static bool LeerBooleano(string mensaje)
    {
        string entrada;
        do
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine().Trim().ToUpper();
            if (entrada != "S" && entrada != "N")
                Console.WriteLine("Responda solo con S o N.");
        } while (entrada != "S" && entrada != "N");
        return entrada == "S";
    }

    static void Pausar()
    {
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }
}