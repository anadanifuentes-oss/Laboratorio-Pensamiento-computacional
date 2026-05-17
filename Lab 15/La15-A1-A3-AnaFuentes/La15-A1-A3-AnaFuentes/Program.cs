using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La15_A1_A3_AnaFuentes
{
    internal class Program
    {
        static void Main()
        {
            // Ejercicio 2: Pruebas de calidad (testing) – bottom up

            // a. Retirar efectivo
            double saldo;
            double montoRetirado;

            Console.WriteLine("=== Retirar Efectivo ===");

            // Validar saldo
            while (true)
            {
                Console.WriteLine("Ingrese el saldo actual (0 - 100):");

                if (double.TryParse(Console.ReadLine(), out saldo))
                {
                    // Validación de rango
                    if (saldo >= 0 && saldo <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: El saldo debe estar entre 0 y 100.");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Ingrese un número válido.");
                }
            }

            // Validar monto a retirar
            while (true)
            {
                Console.WriteLine("Ingrese el monto a retirar (0 - 100):");

                if (double.TryParse(Console.ReadLine(), out montoRetirado))
                {
                    // Validación de rango
                    if (montoRetirado >= 0 && montoRetirado <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: El monto debe estar entre 0 y 100.");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Ingrese un número válido.");
                }
            }

            saldo = RetirarEfectivo(saldo, montoRetirado);

            Console.WriteLine($"Saldo actual: {saldo}Q");

            // b. Calcular descuento
            double precio;
            double porcentaje;

            Console.WriteLine("\n=== Calcular Descuento ===");

            // Validar precio
            while (true)
            {
                Console.WriteLine("Ingrese el precio del producto (0 - 100):");

                if (double.TryParse(Console.ReadLine(), out precio))
                {
                    if (precio >= 0 && precio <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: El precio debe estar entre 0 y 100.");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Ingrese un número válido.");
                }
            }

            // Validar porcentaje
            while (true)
            {
                Console.WriteLine("Ingrese el porcentaje de descuento (0 - 100):");

                if (double.TryParse(Console.ReadLine(), out porcentaje))
                {
                    if (porcentaje >= 0 && porcentaje <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: El porcentaje debe estar entre 0 y 100.");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Ingrese un número válido.");
                }
            }

            double resultado = CalcularDescuento(precio, porcentaje);

            Console.WriteLine($"Precio final: {resultado}");

            // c. Depositar dinero
            double dinero;
            double monto;

            Console.WriteLine("\n=== Depositar Dinero ===");

            // Validar saldo
            while (true)
            {
                Console.WriteLine("Ingrese el saldo actual (0 - 100):");

                if (double.TryParse(Console.ReadLine(), out dinero))
                {
                    if (dinero >= 0 && dinero <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: El saldo debe estar entre 0 y 100.");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Ingrese un número válido.");
                }
            }

            // Validar monto a depositar
            while (true)
            {
                Console.WriteLine("Ingrese el monto a depositar (0 - 100):");

                if (double.TryParse(Console.ReadLine(), out monto))
                {
                    if (monto >= 0 && monto <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: El monto debe estar entre 0 y 100.");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Ingrese un número válido.");
                }
            }

            Depositar(ref dinero, monto);

            Console.WriteLine($"Saldo final: {dinero}");

            // Ejercicio 3: Seguimiento paso a paso (Debugging)

            double capital = 1000;
            double tasa = 0.05;
            double intereses = 0;
            double abono = 0;

            for (int mes = 1; mes <= 12 && capital > 0; mes++)
            {
                // Cálculo de intereses del mes
                intereses = capital * tasa;

                // Abono realizado cada mes
                abono = 100 + (mes * 10);

                // Actualización del capital
                capital += intereses - abono;
            }
        }

        // Método a: RetirarEfectivo
        static double RetirarEfectivo(double saldo, double montoRetirado)
        {
            if (montoRetirado <= saldo)
            {
                saldo -= montoRetirado;
                Console.WriteLine($"Se ha retirado: {montoRetirado}Q");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar el retiro.");
            }

            return saldo;
        }

        // Método b: CalcularDescuento
        static double CalcularDescuento(double precio, double porcentaje)
        {
            return precio - (precio * porcentaje / 100);
        }

        // Método c: Depositar
        static void Depositar(ref double dinero, double monto)
        {
            dinero += monto;
        }
    }
}

