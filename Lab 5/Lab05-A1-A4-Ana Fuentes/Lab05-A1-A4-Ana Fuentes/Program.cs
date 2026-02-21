using System;

namespace Lab05_A1_4_Ana_Fuentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Desafio 1: Estructura seleccion "if/else"
            Console.WriteLine("Desafio 1: Estructura seleccion \"if/else\"");

            // Entrada de datos
            double num;
            Console.WriteLine("Ingrese un número:");
            num = double.Parse(Console.ReadLine());

            // Proceso
            if (num > 0)
            {
                // Salida de datos
                Console.WriteLine("El número es positivo.");
            }
            // Proceso
            else if (num < 0)
            {
                // Salida de datos
                Console.WriteLine("El número es negativo.");
            }
            // Proceso
            else
            {
                // Salida de datos
                Console.WriteLine("El número es cero.");
            }

            Console.WriteLine();

            // Desafio 2: Estructura seleccion "if/else"
            Console.WriteLine("Desafio 2: Estructura seleccion \"if/else\"");

            // Entrada de datos
            Console.WriteLine("Escriba un año: ");
            string fecha = Console.ReadLine();
            Console.WriteLine();

            // Proceso
            if (int.TryParse(fecha, out int year))
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    // Salida de datos
                    Console.WriteLine($"{year} es un año bisiesto.");
                }
                // Proceso
                else
                {
                    // Salida de datos
                    Console.WriteLine($"{year} no es un año bisiesto.");
                }
            }
            // Proceso
            else
            {
                // Salida de datos
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero para el año.");
            }

            Console.WriteLine();

            // Desafio 3: Estructura seleccion "else/if"
            Console.WriteLine("Desafio 3: Estructura seleccion \"else/if\"");

            // Entrada de datos
            double ingresoMensual;
            double pago = 0;
            bool multa;
            Console.Write("Ingrese su ingreso mensual: Q");
            ingresoMensual = double.Parse(Console.ReadLine());
            Console.Write("¿Tiene multa? (true/false): ");
            multa = bool.Parse(Console.ReadLine());
            Console.WriteLine();

            // Proceso
            if (ingresoMensual >= 500.01 && ingresoMensual <= 1000.00)
            {
                pago = 10;
            }
            else if (ingresoMensual >= 1000.01 && ingresoMensual <= 3000.00)
            {
                pago = 15;
            }
            else if (ingresoMensual >= 3000.01 && ingresoMensual <= 6000.00)
            {
                pago = 50;
            }
            else if (ingresoMensual >= 6000.01 && ingresoMensual <= 9000.00)
            {
                pago = 75;
            }
            else if (ingresoMensual >= 9000.01 && ingresoMensual <= 12000.00)
            {
                pago = 100;
            }
            else if (ingresoMensual >= 12000.01)
            {
                pago = 150;
            }

            if (multa == true)
            {
                // Proceso
                pago = (pago * 2);

                // Salida de datos
                Console.WriteLine("Se aplicó multa del 50%.");
            }
            Console.WriteLine();
            Console.WriteLine("El monto a pagar por boleto de ornato es: Q" + pago);
            Console.WriteLine();

            // Desafio 4: Estructuras selectivas & Operadores aritméticos
            Console.WriteLine("Desafio 4: Estructuras selectivas & Operadores aritméticos");

            // Entrada de datos
            Console.WriteLine("Ingrese la cantidad de horas que estuvo estacionado:");
            int horas = Convert.ToInt32(Console.ReadLine());
            int tarifa = 10;

            // Proceso
            int costo = horas * tarifa;
            Console.WriteLine();

            // Salida de datos
            Console.WriteLine("El monto total a pagar es de: Q" + costo);
            Console.WriteLine();

            // Entrada de datos
            Console.WriteLine("Ingrese el monto de dinero para realizar el pago");
            double pago2 = Convert.ToDouble(Console.ReadLine());

            // Proceso
            if (pago2 < costo)
            {
                // Salida de datos
                Console.WriteLine("Error, los fondos no son suficientes.");
                return;
            }
            else
            {
                // Proceso
                if (pago2 == costo)
                {
                    // Salida de datos
                    Console.WriteLine("No se requiere cambio, ¡Feliz día!");
                    return;
                }
                else
                {
                    // Proceso
                    double cambio = pago2 - costo;
                    // Salida de datos
                    Console.WriteLine($"Pago realizado con éxito. Su cambio es: {cambio:C}");

                    // Proceso para calcular el cambio en billetes
                    int[] billetes = { 100, 50, 20, 10, 5, 1 };

                    foreach (int billete in billetes)
                    {
                        int cantidadBilletes = (int)(cambio / billete);
                        if (cantidadBilletes > 0)
                        {
                            // Salida de datos
                            Console.WriteLine($"Billetes de Q{billete}: {cantidadBilletes}");
                            cambio -= cantidadBilletes * billete;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Gracias por utilizar la maquina de pago.");
            // Fin del programa
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

