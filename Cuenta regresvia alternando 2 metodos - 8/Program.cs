//Mostrar una cuenta regresiva desde un numero hata cero utlizando dos metodos que se llamen entre si

using System;
class Program
{
    static void CuentaA(int n)
    {
        if (n < 0)
            return;

        Console.WriteLine("A: " + n);
        CuentaB(n - 1);
        
    }

    static void CuentaB(int n)
    {
        if (n < 0)
            return;

        Console.WriteLine("B: " + n);
        CuentaA(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("Ingresa un numero inicial: ");
        int n = int.Parse(Console.ReadLine());

        if(n<0 || n>10000)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 10000: ");
            return;
        }

        CuentaA(n);
    }
}
