using System;

class SimuladorMatematico
{
    static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   SIMULADOR MATEMÁTICO - NIVEL 2");
        Console.WriteLine("=====================================\n");

        double numero1 = LeerDoubleValidado("Ingrese el primer número: ");
        double numero2 = LeerDoubleValidado("Ingrese el segundo número: ");

        // --- Uso de la clase Math ---
        double potencia = Math.Pow(numero1, numero2);         
        double raizNumero1 = CalcularRaiz(numero1);             
        double raizNumero2 = CalcularRaiz(numero2);
        double valorAbsoluto1 = Math.Abs(numero1);               
        double valorAbsoluto2 = Math.Abs(numero2);
        double redondeo1 = Math.Round(numero1, 2);               
        double redondeo2 = Math.Round(numero2, 2);
        double mayor = Math.Max(numero1, numero2);               
        double menor = Math.Min(numero1, numero2);               

        Console.WriteLine("\n===== RESULTADOS =====");
        Console.WriteLine($"Potencia ({numero1} ^ {numero2})       : {potencia}");
        Console.WriteLine($"Raíz cuadrada de {numero1}            : {raizNumero1}");
        Console.WriteLine($"Raíz cuadrada de {numero2}            : {raizNumero2}");
        Console.WriteLine($"Valor absoluto de {numero1}           : {valorAbsoluto1}");
        Console.WriteLine($"Valor absoluto de {numero2}           : {valorAbsoluto2}");
        Console.WriteLine($"Redondeo de {numero1} (2 decimales)   : {redondeo1}");
        Console.WriteLine($"Redondeo de {numero2} (2 decimales)   : {redondeo2}");
        Console.WriteLine($"Mayor de los dos números              : {mayor}");
        Console.WriteLine($"Menor de los dos números              : {menor}");
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

        } while (!esValido);

        return valor;
    }

    static double CalcularRaiz(double numero)
    {
        if (numero < 0)
        {
            Console.WriteLine($"(Nota: {numero} es negativo, no tiene raíz cuadrada real; se usa su valor absoluto)");
            return Math.Sqrt(Math.Abs(numero));
        }

        return Math.Sqrt(numero);
    }
}