using System;

class Program
{
    static long Potencia(int baseNum, int exponente)
    {
        if (exponente == 0)
            return 1;

        return baseNum * Potencia(baseNum, exponente - 1);
    }

   static void Main()
    {
        Console.WriteLine("Ingresa la base: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el exponente: ");
        int exponente = int.Parse(Console.ReadLine());

        if (exponente < 0 || exponente > 30)
        {
            Console.WriteLine("Exponente fuera de rango: ");
            return;
        }
        Console.WriteLine("El resultado es: " + Potencia(baseNum, exponente));
    }
}