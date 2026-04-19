using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_A1_A4_Ana_Fuentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1: Detección de Palíndromos con arreglos y ciclos
            Console.WriteLine("Ejercicio 1: Detección de Palíndromos");
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine().ToLower();

            char[] caracteres = palabra.ToCharArray();
            bool esPalindromo = true;

            for (int i = 0; i < caracteres.Length / 2; i++)
            {
                if (caracteres[i] != caracteres[caracteres.Length - 1 - i])
                {
                    esPalindromo = false;
                    break;
                }
            }

            Console.WriteLine(esPalindromo);

            // Ejercicio 2: Traducción de palabras con arreglos  y ciclos con menu
            Console.WriteLine("\nEjercicio 2: Traducción de palabras");

            Console.Write("\nSe practicará una lección en español con los colores primarios y tambien con el blanco y verde.");
            Console.WriteLine("\nAl elegir el color el programa traducirá estas palabras al Italiano como al Inglés.");

            string[] palabrasEspanol = { "rojo", "azul", "amarillo", "blanco", "verde" };
            string[] palabrasIngles = { "red", "blue", "yellow", "white", "green" };
            string[] palabrasItaliano = { "rosso", "blu", "giallo", "bianco", "verde" };

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Practicar lección");
                Console.WriteLine("2. Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\nIngrese una palabra en español: ");
                        string vocabulario = Console.ReadLine().ToLower();

                        int indice = -1;

                        for (int i = 0; i < palabrasEspanol.Length; i++)
                        {
                            if (palabrasEspanol[i] == vocabulario)
                            {
                                indice = i;
                                break;
                            }
                        }

                        if (indice != -1)
                        {

                            string esp = char.ToUpper(palabrasEspanol[indice][0]) + palabrasEspanol[indice].Substring(1);
                            string ing = char.ToUpper(palabrasIngles[indice][0]) + palabrasIngles[indice].Substring(1);
                            string ita = char.ToUpper(palabrasItaliano[indice][0]) + palabrasItaliano[indice].Substring(1);

                            Console.WriteLine(esp + ", " + ing + ", " + ita);
                        }
                        else
                        {
                            Console.WriteLine("La palabra no corresponde a la lección actual.");
                        }
                        break;

                    case "2":
                        salir = true;
                        Console.WriteLine("Fin de la lección.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }

            // Ejercicio 3: Calificación de un curso
            Console.WriteLine("\nEjercicio 3: Calificación de un curso");

            int[] notas = new int[10];
            Random rnd = new Random();

            int a = 0;
            while (a < notas.Length)
            {
                notas[a] = rnd.Next(50, 100);
                a++;
            }

            int posibilidad = 0;

            while (posibilidad != 3)
            {
                Console.WriteLine("\n----CALIFICACIONES----");
                Console.WriteLine("1. Reporte de rendimiento");
                Console.WriteLine("2. Estadísticas");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");

                posibilidad = int.Parse(Console.ReadLine());

                switch (posibilidad)
                {
                    case 1:
                        Console.WriteLine("\nNotas:");

                        int j = 0;
                        while (j < notas.Length)
                        {
                            if (notas[j] <= 64)
                                Console.ForegroundColor = ConsoleColor.Red;
                            else if (notas[j] <= 79)
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            else
                                Console.ForegroundColor = ConsoleColor.Green;

                            Console.Write(notas[j] + " ");
                            j++;
                        }

                        Console.ResetColor();
                        Console.WriteLine();
                        break;

                    case 2:
                        int suma = 0;
                        int mayor = notas[0];
                        int menor = notas[0];

                        int k = 0;
                        while (k < notas.Length)
                        {
                            suma += notas[k];

                            if (notas[k] > mayor)
                                mayor = notas[k];

                            if (notas[k] < menor)
                                menor = notas[k];

                            k++;
                        }

                        double promedio = (double)suma / notas.Length;

                        Console.WriteLine("\nPromedio: " + promedio);
                        Console.WriteLine("Mayor: " + mayor);
                        Console.WriteLine("Menor: " + menor);
                        break;

                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }

            // Ejercicio 4: Simulación de pagos de planilla
            Console.WriteLine("\nEjercicio 4: Simulación de pagos de planilla");

            string[] nombres = { "Ana", "Mario", "Saúl", "Karla", "María", "José" };
            double[] salario = { 100, 125.50, 98.65, 125, 132.50, 102.50 };
            double[] horas = new double[6];

            int b = 0;
            while (b < nombres.Length)
            {
                Console.Write("Ingrese las horas trabajadas por " + nombres[b] + ": ");
                horas[b] = double.Parse(Console.ReadLine());

                if (horas[b] < 0)
                {
                    Console.WriteLine("Error: no puede ser negativo");
                }
                else
                {
                    b++;
                }
            }

            Console.WriteLine("\n----PAGOS SEMANALES----");

            int c = 0;
            while (c < nombres.Length)
            {
                double pago = 0;

                if (horas[c] <= 40)
                {
                    pago = horas[c] * salario[c];
                }
                else
                {
                    double extra = horas[c] - 40;
                    pago = (40 * salario[c]) + (extra * salario[c] * 1.5);
                }

                Console.WriteLine("A " + nombres[c] + " se le pagará un total de: " + pago + " quetzales.");
                c++;
            }
        }    
    }
}