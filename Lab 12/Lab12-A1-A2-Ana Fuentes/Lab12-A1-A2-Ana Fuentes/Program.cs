using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_A1_A2_Ana_Fuentes
{
    internal class Program
    {
        const int Estudiantes = 5;
        const int Notas = 4;
        static void Main(string[] args)
        {
            // Ejercicio 1: Matriz cuadrada de 5x5 y suma de diagonales
            Console.WriteLine("Ejercicio 1: Matriz cuadrada de 5x5 y suma de diagonales");
            int[,] matrizCuadrada = new int[5, 5];

            llenar(matrizCuadrada);

            Console.WriteLine($"\nSuma de la diagonal principal: {sumaDiagonalPrincipal(matrizCuadrada)}");
            Console.WriteLine($"\nSuma de la diagonal secundaria: {sumaDiagonalSecundaria(matrizCuadrada)}");

            // Ejercicio 2: Matriz rectangular de 4x6 y suma de filas y columnas
            Console.WriteLine("\nEjercicio 2: Matriz rectangular de 4x6 y suma de filas y columnas");
            int[,] matriz = new int[4, 6];

            completar(matriz);

            Console.WriteLine($"\nEl total de números pares es de: {numerosPares(matriz)}");
            Console.WriteLine($"\nEl total de números impares es de: {numerosImpares(matriz)}");

            // Ejercicio 3: Matriz de 5x4 en el registro de notas
            Console.WriteLine("\nEjercicio 3: Matriz de 5x4 en el registro de notas");
            float[,] notas = new float[Estudiantes, Notas];

            IngresarNotas(notas);

            for (int i = 0; i < Estudiantes; i++)
            {
                float prom = Promedio(notas, i);

                Console.WriteLine($"\nEstudiante {i + 1}:");
                Console.WriteLine($"Promedio: {prom:F2}");

                if (Aprueba(prom))
                    Console.WriteLine("Estado: Aprobado");
                else
                    Console.WriteLine("Estado: Reprobado");
            }

            // Ejercicio 4: Matriz de 3x3 y determinar si la matriz es simetrica
            Console.WriteLine("\nEjercicio 4: Matriz de 3x3 y determinar si la matriz es simetrica");
            int[,] matrizSimetrica = new int[3, 3];
            rellenar(matrizSimetrica);

            if (EsSimetrica(matrizSimetrica))
                Console.WriteLine("\nLa matriz es simétrica");
            else
                Console.WriteLine("\nLa matriz no es simétrica");
        }
        // Procedimiento para el ejercicio 1
        static void llenar(int[,] m)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Ingrese el elemento [{i}, {j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
        }

        // Funciones para el ejercicio 1
        static int sumaDiagonalPrincipal(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += m[i, i];
            }
            return suma;
        }

        static int sumaDiagonalSecundaria(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += m[i, 4 - i];
            }
            return suma;
        }

        // Procedimiento para el ejercicio 2
        static void completar(int[,] m)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"Ingrese el elemento [{i}, {j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
        }

        // Funciones para el ejercicio 2
        static int numerosPares(int[,] m)
        {
            int contador = 0;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 6; j++)
                {
                    if (m[i, j] % 2 == 0)
                    {
                        contador++;
                    }
                }
            return contador;
        }

        static int numerosImpares(int[,] m)
        {
            int contador = 0;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 6; j++)
                {
                    if (m[i, j] % 2 != 0)
                    {
                        contador++;
                    }
                }
            return contador;
        }

        // Procedimiento para el ejercicio 3
        static void IngresarNotas(float[,] m)
        {
            for (int i = 0; i < Estudiantes; i++)
            {
                Console.WriteLine($"\nIngrese notas del estudiante {i + 1}:");
                for (int j = 0; j < Notas; j++)
                {
                    Console.Write($"Nota {j + 1}: ");
                    m[i, j] = float.Parse(Console.ReadLine());
                }
            }
        }

        // Funciones para el ejercicio 3
        static float Promedio(float[,] m, int estudiante)
        {
            float suma = 0;
            for (int j = 0; j < Notas; j++)
            {
                suma += m[estudiante, j];
            }
            return suma / Notas;
        }

        static bool Aprueba(float prom)
        {
            return prom >= 61;
        }

        // Procedimiento para el ejercicio 4
        static void rellenar(int[,] m)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Ingrese el elemento [{i}, {j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Función para el ejercicio 4

        static bool EsSimetrica(int[,] m)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (m[i, j] != m[j, i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}


