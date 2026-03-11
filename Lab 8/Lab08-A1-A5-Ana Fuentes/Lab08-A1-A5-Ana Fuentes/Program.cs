using System;

namespace Lab08_A1_A5_Ana_Fuentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1: Solicitar 20 números al usuario
            Console.WriteLine("Ejercicio 1: Solicitar 20 números al usuario");

            int numero;
            int mayor = 0;
            int menor = int.MaxValue;
            int suma = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Ingrese número " + i + ": ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > mayor)
                {
                    mayor = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }

                suma = suma + numero;
            }

            double promedio = (double)suma / 20;
            Console.WriteLine();

            Console.WriteLine("Número mayor: " + mayor);
            Console.WriteLine("Número menor: " + menor);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine();

            // Ejercicio 2: Mostrar números del 1 al 100 con condiciones
            Console.WriteLine("Ejercicio 2: Mostrar números del 1 al 100 con condiciones");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("ParSiete");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("Par");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine("Siete");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

            // Ejercicio 3: Calcular descuentos para clientes
            Console.WriteLine("Ejercicio 3: Calcular descuentos para clientes");

            double compra;
            double totalDia = 0;
            int clientesDescuento = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese monto de compra del cliente " + i + ": ");
                compra = Convert.ToDouble(Console.ReadLine());

                double descuento = 0;

                if (compra > 700)
                {
                    descuento = compra * 0.12;
                    clientesDescuento++;
                }
                else if (compra > 300)
                {
                    descuento = compra * 0.05;
                    clientesDescuento++;
                }

                double totalPagar = compra - descuento;

                Console.WriteLine("Total pagado por cliente " + i + ": " + totalPagar);

                totalDia = totalDia + totalPagar;
            }
            Console.WriteLine();
            Console.WriteLine("Clientes con descuento: " + clientesDescuento);
            Console.WriteLine("Total de ventas del día: " + totalDia);
            Console.WriteLine();

            // Ejercicio 4: Menú de opciones para mostrar números
            Console.WriteLine("Ejercicio 4: Menú de opciones para mostrar números");

            Console.Write("Ingrese un número entero: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Mostrar los números desde el número ingresado hasta 1");
            Console.WriteLine("2. Mostrar los múltiplos de 3 hasta el número ingresado");
            Console.WriteLine("3. Mostrar los múltiplos de 5 hasta el número ingresado");

            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                for (int i = n; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else if (opcion == 2)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if (opcion == 3)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Opción no válida");
            }
            Console.WriteLine();

            // Ejercicio 5: Mostrar triángulo de asteriscos
            Console.WriteLine("Ejercicio 5: Mostrar triángulo de asteriscos");

            Console.Write("Ingrese número de filas: ");
            int filas = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= filas; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}