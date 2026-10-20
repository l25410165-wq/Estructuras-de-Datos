//Calcular la suma de los numeros desde 1 hasta n utilizando dos metodos que se llamen mutuamente

using System;
class Program
{
    static int SumaA(int n)
    {
        if (n <= 0)
            return 0
                ;

        return n + SumaB(n - 1);

    }

    static int SumaB(int n)
    {
        if (n <= 0)
            return 0;

        return n + SumaA(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("Ingrese el primer numero: ");
        int n = int.Parse(Console.ReadLine());

        
        if(n<0 || n>10000)
        {
            Console.WriteLine("Ingreese un numero entre el 0 y el 10000");
        }

        Console.WriteLine("La suma de los numeros es: " + SumaA(n));

        SumaA(n);
        SumaB(n);
       
    }
}