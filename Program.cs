using System;

class LoginSistema
{
    // Credenciales válidas (puedes cambiarlas por las que pida tu docente)
    const string USUARIO_VALIDO = "admin";
    const string CLAVE_VALIDA = "1234";

    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("      LOGIN DEL SISTEMA - NIVEL 1");
        Console.WriteLine("=====================================\n");

        int intentos = 0;
        const int MAX_INTENTOS = 3;
        bool accesoConcedido = false;

        // --- Ciclo while: se repite mientras haya intentos disponibles ---
        while (intentos < MAX_INTENTOS && !accesoConcedido)
        {
            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Contraseña: ");
            string clave = Console.ReadLine();

            if (usuario == USUARIO_VALIDO && clave == CLAVE_VALIDA)
            {
                accesoConcedido = true;
                Console.WriteLine("\n>>> ACCESO CONCEDIDO");
                Console.WriteLine($">>> Bienvenido, {usuario}.");
            }
            else
            {
                intentos++;
                int restantes = MAX_INTENTOS - intentos;

                if (restantes > 0)
                {
                    Console.WriteLine($"\nUsuario o contraseña incorrectos.");
                    Console.WriteLine($"Intentos restantes: {restantes}\n");
                }
            }
        }

        // Si se acabaron los intentos y nunca hubo acceso, se bloquea el sistema
        if (!accesoConcedido)
        {
            Console.WriteLine("\n>>> SISTEMA BLOQUEADO");
        }
    }
}