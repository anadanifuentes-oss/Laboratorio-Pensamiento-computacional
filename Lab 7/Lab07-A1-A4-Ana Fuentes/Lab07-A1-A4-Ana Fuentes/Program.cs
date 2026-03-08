using System;

namespace Lab07_A1_A4_Ana_Fuentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problema #1 - Mostrar los números del 1 al 20
            string nombre = "<Ana Fuentes>";
            int carnet = 1118426;
            int indice = 1;
            Console.WriteLine(" Nombre: " + nombre + " Carnet: " + carnet.ToString());
            while (indice <= 20)
            {
                if (indice % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine(indice);
                indice = indice + 1;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

            // Problema #2 - Do While, divison numeros positivos
            Console.Write("Ingrese un número entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            int i = 1;

            Console.WriteLine("Los divisores de " + numero + " son:");

            do
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                }

                i++;

            } while (i <= numero);

            Console.WriteLine();

            Console.ReadLine();

            // Problema #3 - For, Fibonacci
            Console.Write("Ingrese la cantidad de números Fibonacci que desea ver: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            Console.WriteLine("Serie de Fibonacci:");

            for (int c = 0; c < n; c++)
            {
                Console.WriteLine(a);

                int siguiente = a + b;
                a = b;
                b = siguiente;
            }

            Console.WriteLine();

            Console.ReadLine();

            // Problema #4 - For, Ciclos Anidados, tablas de multiplicar
            int d;
            int e;

            for (d = 1; d <= 12; d++)
            {
                Console.WriteLine("Tabla del " + d);

                for (e = 1; e <= 10; e++)
                {
                    int resultado = d * e;
                    Console.WriteLine(d + " x " + e + " = " + resultado);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
    

    


