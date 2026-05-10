using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_A1_A3_AnaFuentes
{
    internal class Estudiante
    {
        //Atributos

        string nombre_estudiante;
        int edad;
        string grado;
        decimal[] notas;

        //Constructor
        public Estudiante(string nombreIngresado, int edadIngresado, string gradoIngresado, decimal[] notasIngresadas)
        {
            this.nombre_estudiante = nombreIngresado;
            this.edad = edadIngresado;
            this.grado = gradoIngresado;
            this.notas = notasIngresadas;
        }

        //Métodos

        //Calcular promedio
        public decimal CalcularPromedio()
        {
            decimal suma = 0;
            foreach (decimal nota in notas)
            {
                suma += nota;
            }
            return suma / notas.Length;
        }

        //Mostrar info
        public void MostrarInfo()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Nombre del estudiante: " + nombre_estudiante);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Grado: " + grado);
            Console.WriteLine("Promedio de notas: " + CalcularPromedio());
            Console.WriteLine("---------------------------------------------------------------");
        }

        // Verificar si el estudiante aprobó
        public bool VerificarAprobacion()
        {
            decimal promedio = CalcularPromedio();
            if (promedio >= 61)
            {
                Console.WriteLine("\nEl estudiante " + nombre_estudiante + " ha aprobado con un promedio de " + promedio);
                return true;
            }
            else
            {
                Console.WriteLine("\nEl estudiante " + nombre_estudiante + " no ha aprobado. Promedio: " + promedio);
                return false;
            }
        }

        // Agregar nota y actualizar notas
        public void AgregarNota(decimal nuevaNota)
        {
            Array.Resize(ref notas, notas.Length + 1);
            notas[notas.Length - 1] = nuevaNota;

            Console.WriteLine("\nSe ha agregado la nueva nota: " + nuevaNota + " al estudiante " + nombre_estudiante);

            // Recalcular el promedio después de agregar la nueva nota
            decimal nuevoPromedio = CalcularPromedio();
        }
    }
}
