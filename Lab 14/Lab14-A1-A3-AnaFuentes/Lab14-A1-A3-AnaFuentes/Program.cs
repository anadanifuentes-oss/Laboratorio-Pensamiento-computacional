using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_A1_A3_AnaFuentes
{
    internal class Program
    {
        static void Main()
        {
            //Ejercicio # 1: CuentaBancaria
            Console.WriteLine("Ejercicio # 1: CuentaBancaria");

            // Crear una cuenta bancaria
            CuentaBancaria bac = new CuentaBancaria("Ana Fuentes", "1118426");
            CuentaBancaria bi = new CuentaBancaria("Esteban Sian", "1267726");
            CuentaBancaria promerica = new CuentaBancaria("Damaris Pinzón", "1188926");

            //Mostrar Saldo Inicial
            bac.MostrarInfo();
            bi.MostrarInfo();
            promerica.MostrarInfo();

            //Depositos
            Console.WriteLine("Realizando depósitos...");
            bac.Depositar(500);
            bi.Depositar(100);
            promerica.Depositar(50);

            //Saldo
            bac.MostrarInfo();
            bi.MostrarInfo();
            promerica.MostrarInfo();
            Console.ReadLine();

            // Retiros
            Console.WriteLine("Realizando retiros...");
            bac.Retirar(200);
            bi.Retirar(50);
            promerica.Retirar(30);
            
            // Saldo después de retiros
            bac.MostrarInfo();
            bi.MostrarInfo();
            promerica.MostrarInfo();
            Console.ReadLine();

            // Ejercicio # 2: Producto
            Console.WriteLine("\nEjercicio # 2: Producto");

            // Crear productos
            Producto producto1 = new Producto("Laptop", 1500.00, 10);
            Producto producto2 = new Producto("Smartphone", 800.00, 20);
            Producto producto3 = new Producto("Tablet", 600.00, 15);

            // Mostrar información de los productos
            producto1.MostrarInfo();
            producto2.MostrarInfo();
            producto3.MostrarInfo();

            // Vender productos
            Console.WriteLine("\nVendiendo productos...");
            producto1.Vender(2);
            producto2.Vender(5);
            producto3.Vender(3);

            // Reabastecer productos
            Console.WriteLine("\nReabasteciendo productos...");
            producto1.Reabastecer(5);
            producto2.Reabastecer(10);
            producto3.Reabastecer(7);

            // Mostrar información de los productos
            producto1.MostrarInfo();
            producto2.MostrarInfo();
            producto3.MostrarInfo();

            // Ejercicio # 3: Estudiante
            Console.WriteLine("\nEjercicio # 3: Estudiante");

            // Crear estudiantes
            Estudiante estudiante1 = new Estudiante("Ana Fuentes", 20, "1118426", new decimal[] { 85, 90, 78 });
            Estudiante estudiante2 = new Estudiante("Esteban Sian", 22, "1267726", new decimal[] { 70, 75, 95 });
            Estudiante estudiante3 = new Estudiante("Damaris Pinzón", 21, "1188926", new decimal[] { 60, 65, 100 });

            // Calcular promedio de los estudiantes
            Console.WriteLine("\nCalculando promedios...");
            estudiante1.CalcularPromedio();
            estudiante2.CalcularPromedio();
            estudiante3.CalcularPromedio();

            // Mostrar información de los estudiantes
            estudiante1.MostrarInfo();
            estudiante2.MostrarInfo();
            estudiante3.MostrarInfo();

            // Verificar aprobación de los estudiantes
            estudiante1.VerificarAprobacion();
            estudiante2.VerificarAprobacion();
            estudiante3.VerificarAprobacion();

            // Agregar nuevas notas a un estudiante
            estudiante3.AgregarNota(95);

            // Mostrar información actualizada del estudiante
            estudiante1.MostrarInfo(); 
            estudiante2.MostrarInfo();
            estudiante3.MostrarInfo();
        }
    }
}
