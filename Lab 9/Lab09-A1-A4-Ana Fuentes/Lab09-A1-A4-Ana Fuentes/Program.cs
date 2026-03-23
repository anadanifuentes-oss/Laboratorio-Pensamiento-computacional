using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_A1_A4_Ana_Fuentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio # 1: Parametros por valor, cantidad de caracteres de una cadena

            Console.WriteLine("\nEjercicio # 1: Parametros por valor, cantidad de caracteres de una cadena");
            Console.WriteLine();
            Console.WriteLine("Ingrese una cadena de texto: ");
            string cadena = Console.ReadLine();
            Entrada(cadena);

            // Ejercicio # 2: Parametros por referencia, intercambio de valor de dos variables enteras usando un auxiliar de variable c

            Console.WriteLine("\nEjercicio # 2: Parametros por referencia, intercambio de valor de dos variables enteras");
            Console.WriteLine();
            Console.WriteLine("Ingrese el valor de a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b");
            int b = int.Parse(Console.ReadLine());
            Intercambio(ref a, ref b);

            // Ejercicio # 3: Integracion - Parametros por valor, porcentaje de descuento, y por referencia, precio actual de un producto
            Console.WriteLine("\nEjercicio # 3: Integracion - Parametros por valor y por referencia");
            Console.WriteLine();
            Console.WriteLine("El precio del boleto es de Q 48.50");
            Console.WriteLine("Tiene descuento? (SI/NO):");
            string respuesta = Console.ReadLine().ToUpper();

            double precio = 48.50;

            if (respuesta == "NO")
            {
                Console.WriteLine("El precio del boleto permanece igual por lo que son: Q 48.50");
                return;
            }
            if (respuesta == "SI")
            {
                Console.WriteLine("Ingrese el porcentaje de descuento (niños 0.5, adultos mayores 0.15, personas con membresia premium 0.9): ");
                double descuento = double.Parse(Console.ReadLine());
                Descuento(descuento, ref precio);
            }

            // Ejercicio # 4: Integracion - Parametros por valor y por referencia videojuego daño, curar, mostrar salud actual del personaje
            int puntosSalud = 15;
            int nivel = 1;
            int opcion;
            bool juegoActivo = true;

            do
            {
                Console.WriteLine("\n----- Menú Videojuego -----");
                Console.WriteLine("Nivel actual: " + nivel);
                Console.WriteLine("1. Mostrar salud");
                Console.WriteLine("2. Recibir daño");
                Console.WriteLine("3. Curar");
                Console.WriteLine("4. Ver calificación y subir nivel");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        mostrarSalud(ref puntosSalud);
                        break;

                    case 2:
                        recibirDaño(ref puntosSalud, ref juegoActivo);
                        break;

                    case 3:
                        curar(ref puntosSalud);
                        break;

                    case 4:
                        calificarDesempeño(puntosSalud);
                        nivel++;
                        Console.WriteLine("¡Has subido al nivel " + nivel + "!");
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del juego...");
                        juegoActivo = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 5 && juegoActivo);

            Console.WriteLine("Juego terminado.");

            Console.ReadKey();
        }


        // Procedimeinto de ejercicio # 1, cantidad de caracteres de una cadena, parametro por valor
        static void Entrada(string cadena)
        {
            int cantidad = cadena.Length;
            Console.WriteLine("La cantidad de caracteres de la cadena es: " + cantidad);
        }

        // Procedimeinto de ejercicio # 2, intercambio de valor de dos variables
        static void Intercambio(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("El valor de a es: " + a);
            Console.WriteLine("El valor de b es: " + b);
        }

        // Procedimeinto de ejercicio # 3, porcentaje de descuento y precio actual de un producto
        static void Descuento(double descuento, ref double precio)
        {
            switch (descuento)
            {
                case 0.5:
                    Console.WriteLine("El descuento es para niños");
                    break;
                case 0.15:
                    Console.WriteLine("El descuento es para adultos mayores");
                    break;
                case 0.9:
                    Console.WriteLine("El descuento es para personas con membresia premium");
                    break;
                default:
                    Console.WriteLine("Descuento no valido");
                    break;
            }
            double descuentoCalculado = precio * (descuento);
            precio = precio - descuentoCalculado;
            Console.WriteLine("El precio actual del boleto con descuento son: Q " + precio);
        }

        // Procedimeinto de ejercicio # 4, Parametros por valor y por referencia videojuego

        static void recibirDaño(ref int puntosSalud, ref bool juegoActivo)
        {
            if (puntosSalud == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡Has muerto! Game Over.");
                Console.ResetColor();
                juegoActivo = false;
                return;
            }

            puntosSalud -= 5;

            if (puntosSalud == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Te has quedado sin vida. ¡Cuidado! Si recibes otro daño morirás.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Has recibido daño.");
            }
        }

        // b. Aumenta la salud en 3 (máximo 15) con validación
        static void curar(ref int puntosSalud)
        {
            if (puntosSalud == 15)
            {
                Console.WriteLine("La salud ya está al máximo.");
            }
            else if (puntosSalud + 3 > 15)
            {
                Console.WriteLine("No se puede superar la vida máxima (15).");
            }
            else
            {
                puntosSalud += 3;
                Console.WriteLine("Te has curado.");
            }
        }

        // c. Muestra la salud con color
        static void mostrarSalud(ref int puntosSalud)
        {
            if (puntosSalud >= 11 && puntosSalud <= 15)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (puntosSalud >= 6)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine("Puntos de salud: " + puntosSalud);
            Console.ResetColor();
        }

        // d. Califica el desempeño (por valor)
        static void calificarDesempeño(int puntosSalud)
        {
            if (puntosSalud == 15)
            {
                Console.WriteLine("Calificación: S");
            }
            else if (puntosSalud >= 11)
            {
                Console.WriteLine("Calificación: A");
            }
            else if (puntosSalud >= 6)
            {
                Console.WriteLine("Calificación: B");
            }
            else
            {
                Console.WriteLine("Calificación: C");
            }
        }
    }
}