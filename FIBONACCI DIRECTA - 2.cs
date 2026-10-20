//CALCULAR EL FACTORIAL DE UN NUMERO NO NEGATIVO USANDO RECUSRIVIDAD

using System;

class program
{
    static long Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Ingresa la posicion: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 40)
        {
            Console.WriteLine("ingresa un un numero entre 0 y 40.");
            return;
        }

        Console.WriteLine("Fibonacci: " + Fibonacci(n));
    }
}
