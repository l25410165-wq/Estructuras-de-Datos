using System;

class Program
{
    static long Invertir(long n, long resultado = 0)
    {
        if (n == 0)
            return resultado;

        return Invertir(n / 10, resultado * 10 + n % 10);
    }

    static void Main()
    {
        Console.Write("Ingresa un numero positivo: ");

        if (long.TryParse(Console.ReadLine(), out long n) && n > 0)
        {
            Console.WriteLine("Numero invertido: " + Invertir(n));
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un numero entero positivo valido.");
        }

        Console.WriteLine("El numero invertido es: " + Invertir(n));
    }
}

