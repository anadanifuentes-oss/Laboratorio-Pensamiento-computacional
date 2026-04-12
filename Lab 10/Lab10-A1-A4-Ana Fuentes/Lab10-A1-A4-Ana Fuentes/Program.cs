using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab10_A1_A4_Ana_Fuentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1: Suma de dígitos
            int numero;

            Console.WriteLine("Ejercicio 1: Suma de dígitos");

            while (true)
            {
                Console.Write("Ingrese un número entero positivo: ");

                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: no escribas letras, solo números enteros.");
                }
            }

            while (numero < 0)
            {
                Console.WriteLine("Error: el número debe ser positivo.");
                Console.Write("Ingrese nuevamente un número positivo: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            int resultado = SumaDigitos(numero);

            Console.WriteLine("La suma de los dígitos es: " + resultado);

            // Ejercicio 2:  Ajuste de saldo
            decimal saldo;

            Console.WriteLine("\nEjercicio 2: Ajuste de saldo");

            while (true)
            {
                Console.Write("Ingrese el saldo actual: ");

                if (decimal.TryParse(Console.ReadLine(), out saldo))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Error: no escribas letras, solo números enteros.");
                }
            }

            while (saldo < 0)
            {
                Console.WriteLine("Error: el saldo no puede ser negativo.");
                Console.Write("Ingrese nuevamente un saldo positivo: ");
                saldo = Convert.ToDecimal(Console.ReadLine());
            }

            while (saldo == 0)
            {
                Console.WriteLine("El saldo es cero, no se pueden realizar retiros.");
                Console.Write("Ingrese nuevamente un saldo positivo: ");
                saldo = Convert.ToDecimal(Console.ReadLine());
            }

            decimal monto_de_retiro;

            while (true)
            {
                Console.Write("Ingrese el monto de retiro: ");

                if (decimal.TryParse(Console.ReadLine(), out monto_de_retiro))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Error: no escribas letras, solo números enteros.");
                }
            }

            while (monto_de_retiro < 0)
            {
                Console.WriteLine("Error: el monto de retiro no puede ser negativo.");
                Console.Write("Ingrese nuevamente el monto de retiro positivo: ");
                saldo = Convert.ToDecimal(Console.ReadLine());
            }

            while (monto_de_retiro == 0)
            {
                Console.WriteLine("El monto de retiro es cero, no se pueden realizar retiros.");
                Console.Write("Ingrese nuevamente el monto de retiro positivo: ");
                saldo = Convert.ToDecimal(Console.ReadLine());
            }

            decimal nuevoSaldo = AjusteSaldo(ref saldo, ref monto_de_retiro);

            // Ejercicio 3: Conversión de temperatura (valor + referencia) 
            double fahrenheit = 0;
            double celsius;

            Console.WriteLine("\nEjercicio 3: Conversión de temperatura");

            while (true)
            {
                Console.Write("Ingrese la temperatura en grados Celsius: ");

                if (double.TryParse(Console.ReadLine(), out celsius))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: no escribas letras, solo números.");
                }
            }

            string resultadoConversion = Temperatura(celsius, ref fahrenheit);
            Console.WriteLine(resultadoConversion);

            // Ejercicio 4: Funciones – Sistema de puntos de estudiante
            int puntos = 50;
            int opcion;
            bool sistemaActivo = true;

            do
            {
                Console.WriteLine("\n----- Sistema de Puntos de Estudiante -----");
                Console.WriteLine("1. Agregar puntos");
                Console.WriteLine("2. Quitar puntos");
                Console.WriteLine("3. Obtener nivel");
                Console.WriteLine("4. Evaluar estado");
                Console.WriteLine("5. Mostrar puntos");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        agregarPuntos(ref puntos);
                        break;

                    case 2:
                        quitarPuntos(ref puntos);
                        break;

                    case 3:
                        Console.WriteLine("Nivel: " + obtenerNivel(puntos));
                        break;

                    case 4:
                        Console.WriteLine("Estado: " + evaluarEstado(puntos));
                        break;

                    case 5:
                        Console.WriteLine("Puntos actuales: " + puntos);
                        break;

                    case 6:
                        Console.WriteLine("Saliendo del sistema...");
                        sistemaActivo = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 6 && sistemaActivo);

            Console.WriteLine("Sistema finalizado.");
            Console.ReadKey();
        }

        // Ejercicio 1: Método para calcular la suma de los dígitos de un número
        public static int SumaDigitos(int numero)
        {
            int suma = 0;

            while (numero > 0)
            {
                suma += numero % 10;
                numero /= 10;
            }

            return suma;
        }
        // Ejercicio 2: Método para ajustar el saldo
        public static decimal AjusteSaldo(ref decimal saldo, ref decimal monto_de_retiro)
        {

            if (monto_de_retiro > saldo)
            {
                Console.WriteLine("Saldo = " + saldo + " (sin cambios)");
                return saldo;
            }

            decimal nuevoSaldo = saldo - monto_de_retiro;
            Console.WriteLine("Saldo = " + nuevoSaldo);
            return nuevoSaldo;
        }

        // Ejercicio 3: Método para conversión de temperatura (valor + referencia) 
        public static string Temperatura(double celsius, ref double fahrenheit)
        {
            fahrenheit = (celsius * 9 / 5) + 32;
            return "Los grados en Fahrenheit son " + fahrenheit;
        }

        // Ejercicio 4: Método para funciones – Sistema de puntos de estudiante:

        // 4.1. agregarPuntos( )
        static int agregarPuntos(ref int puntos)
        {
            if (puntos + 10 > 100)
            {
                puntos = 100;
                Console.WriteLine("Los puntos llegaron al máximo (100).");
            }
            else
            {
                puntos += 10;
                Console.WriteLine("Se agregaron 10 puntos.");
            }

            return puntos;
        }

        // 4.2. quitarPuntos( )
        static int quitarPuntos(ref int puntos)
        {
            if (puntos - 7 < 0)
            {
                puntos = 0;
                Console.WriteLine("Los puntos no pueden ser menores a 0.");
            }
            else
            {
                puntos -= 7;
                Console.WriteLine("Se quitaron 7 puntos.");
            }

            return puntos;
        }

        // 4.3. obtenerNivel( )
        static string obtenerNivel(int puntos)
        {
            if (puntos >= 80)
                return "Avanzado";
            else if (puntos >= 50)
                return "Intermedio";
            else
                return "Básico";
        }

        // 4.4. evaluarEstado( )
        static string evaluarEstado(int puntos)
        {
            if (puntos == 100)
                return "Excelente";
            else if (puntos >= 70)
                return "Aprobado";
            else if (puntos >= 1)
                return "Reprobado";
            else
                return "Sin puntos";
        }
    }
}
        
    



