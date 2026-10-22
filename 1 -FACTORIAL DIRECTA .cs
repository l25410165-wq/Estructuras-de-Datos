//CALCULAR EL FACTORIAL DE UN NUMERO NO NEGATIVO USANDO RECUSRIVIDAD

using System;

class program
{
    static long Factorial(int n)
    {
        if (n== 0)
            return 1;

        return n*Factorial(n - 1); 
    }

    static void Main()
    {
        Console.Write("Ingresa el numero: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 20)
        {
            Console.WriteLine("ingresa un un numero entre 1 y 20.");
            return;
        }

        Console.WriteLine("Factorial: " + Factorial(n));
    }
}
