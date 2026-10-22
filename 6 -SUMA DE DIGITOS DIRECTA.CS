using System;

class Program
{
    static void SumaDigitos(int n)
    {
        if (n == 0)
        return 0;

        return n % 10 + SumaDigitos(n/10);
    }

    static void Main()
    {
        Console.Write("Ingrese un numero: ");
        int n = int.Parse(Console.ReadLine());

        if (n<=0)
        {
            Console.WriteLine("Ingrese un numero positivo");
            return;
        }
        
        Console.WriteLine("Suma de digitos: " + SumaDigitos(n));
    
    }
}