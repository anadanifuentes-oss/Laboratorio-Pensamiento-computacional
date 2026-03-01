using System;

namespace Lab06_A1_A4_Ana_Fuentes
{
    class Program
    {
        static int menu()
        {
            int opcion;
            // Desafio #1 <Menu de conversiones switch/case>
            Console.WriteLine("Menu");
            Console.WriteLine("Elige una opcion");
            Console.WriteLine();
            Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
            Console.WriteLine("2. Convertir de Fahrenheit a Celsius");
            Console.WriteLine("3. Convertir de Celsius a Kelvin");
            Console.WriteLine();
            Console.Write("Ingresa el numero de la opcion que deseas realizar: ");
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        static void CelciusaFahrenheit()
        {
            double CE, FA;
            Console.WriteLine();
            Console.WriteLine("Ingrese los grados en Celcius ");
            CE = double.Parse(Console.ReadLine());
            FA = (CE * 1.800) + 32;
            Console.WriteLine();
            Console.WriteLine("La Conversion a grados Fahrenheit es: " + FA);
            Console.WriteLine();
        }
        static void FahrenheitaCelcius()
        {
            double F, C;
            Console.WriteLine();
            Console.WriteLine("Ingrese los grados en Fahrenheit ");
            F = double.Parse(Console.ReadLine());
            C = (F - 32) / 1.800;
            Console.WriteLine();
            Console.WriteLine("La Conversion a grados Celcius es: " + C);
            Console.WriteLine();
        }

        static void CelciusaKelvin()
        {
            double CS, KE;
            Console.WriteLine();
            Console.WriteLine("Ingrese los grados en Celcius ");
            CS = double.Parse(Console.ReadLine());
            KE = (CS + 273.15);
            Console.WriteLine();
            Console.WriteLine("La Conversion a Kelvin es: " + KE);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            int opc;
            opc = menu();

            switch (opc)
            {
                case (1): CelciusaFahrenheit(); break;
                case (2): FahrenheitaCelcius(); break;
                case (3): CelciusaKelvin(); break;
                default:
                    Console.WriteLine("Error esa opcion no existe"); break;
            }

            Console.WriteLine("Presiona ENTER para salir del menu");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            ProgramaDescuentos();

            ProgramaPagoEstacionamiento();

            EvaluacionEmpleados();
        }

        // Desafio #2 <Descuentos switch/case>
        static void ProgramaDescuentos()
        {
            int tipoCliente;
            int cantidad;
            double precioUnitario;
            double descuento = 0;
            double total;
            double totalFinal;

            Console.WriteLine("Tienda de Descuentos");
            Console.WriteLine("Seleccione el tipo de cliente:");
            Console.WriteLine();
            Console.WriteLine("1. Cliente Regular (5%)");
            Console.WriteLine("2. Cliente VIP (10%)");
            Console.WriteLine();
            Console.Write("Ingrese opcion: ");
            tipoCliente = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Ingrese cantidad de unidades compradas: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Ingrese precio por unidad: ");
            precioUnitario = double.Parse(Console.ReadLine());
            Console.WriteLine();

            total = cantidad * precioUnitario;

            // Verificar si es mayorista
            if (cantidad > 100)
            {
                descuento = 0.15;
                Console.WriteLine("Se aplica descuento de Mayorista (15%)");
            }
            else
            {
                switch (tipoCliente)
                {
                    case 1:
                        descuento = 0.05;
                        Console.WriteLine("Se aplica descuento de Cliente Regular (5%)");
                        break;

                    case 2:
                        descuento = 0.10;
                        Console.WriteLine("Se aplica descuento de Cliente VIP (10%)");
                        break;

                    default:
                        Console.WriteLine("Tipo de cliente no valido.");
                        break;
                }
            }

            totalFinal = total - (total * descuento);
            Console.WriteLine();
            Console.WriteLine("Total sin descuento: " + total);
            Console.WriteLine();
            Console.WriteLine("Total con descuento: " + totalFinal);
            Console.WriteLine();

            Console.WriteLine("Presione ENTER para salir de la Tienda de Descuentos.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        // Desafio #3 <Pago por estacionaminento con if>
        static void ProgramaPagoEstacionamiento()
        {
            int horas;
            double precioPorHora = 0;
            double total;

            Console.WriteLine("Pago por Estacionamineto");
            Console.WriteLine();
            Console.Write("Ingrese el numero de horas que estuvo estacionado: ");
            horas = int.Parse(Console.ReadLine());

            if (horas < 2)
            {
                precioPorHora = 5;
            }
            else if (horas >= 2 && horas <= 5)
            {
                precioPorHora = 4;
            }
            else if (horas > 5)
            {
                precioPorHora = 3;
            }

            total = horas * precioPorHora;

            Console.WriteLine();
            Console.WriteLine("Precio por hora: $" + precioPorHora);
            Console.WriteLine();
            Console.WriteLine("Total a pagar: $" + total);
            Console.WriteLine();
            Console.WriteLine("Presione ENTER para salir del Pago por Estacionamineto.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        // Desafio #4 <Evaluacion de empleados switch/case con if>

        static void EvaluacionEmpleados()
        {
            double puntuacion;
            double dinero;
            string nivel = "";

            Console.WriteLine("Evaluacion de Empleados");
            Console.Write("Ingrese su puntuacion (0.0, 0.4, 0.6 o mas): ");
            puntuacion = double.Parse(Console.ReadLine());

            if (puntuacion == 0.0)
            {
                nivel = "Inaceptable";
            }
            else if (puntuacion == 0.4)
            {
                nivel = "Aceptable";
            }
            else if (puntuacion >= 0.6)
            {
                nivel = "Meritorio";
            }
            else
            {
                Console.WriteLine("Puntuacion no valida.");
                Console.ReadLine();
                return; // termina el programa
            }

            dinero = 2400 * puntuacion;

            Console.WriteLine();
            Console.WriteLine("Nivel de rendimiento: " + nivel);
            Console.WriteLine();
            Console.WriteLine("Cantidad de dinero a recibir: " + dinero + " euros");
            Console.WriteLine();
            Console.WriteLine("Presione ENTER para salir de la Evaluacion de Empleados y terminar el programa.");
            Console.ReadLine();
        }
    }
}
