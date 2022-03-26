using System;

namespace ProyectoPotencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Matem matem = new Matem();
            Console.WriteLine("Para calcular a^b");
            Console.WriteLine("a :");
            double a= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b :");
            int b = Convert.ToInt32(Console.ReadLine());
            double c= matem.Potencia(a, b);

            Console.WriteLine("resultado:" + c);

            Console.ReadKey();
        }
    }
}
