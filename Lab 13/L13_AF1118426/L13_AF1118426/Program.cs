using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13_AF1118426
{
   

    class Program
    {
        static void Main()
        {
            // Ejercicio 1 – Clase Persona
            Persona per = new Persona();

            Console.WriteLine("Ejercicio 1 – Clase Persona");

            Console.WriteLine("\nIngrese su nombre: ");
            per.Nombre = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(per.Nombre))
            {
                Console.WriteLine("\nEl nombre no puede estar vacío. Por favor, ingrese un nombre válido.");
                Console.WriteLine("\nIngrese su nombre: ");
                per.Nombre = Console.ReadLine();
            }
            while (per.Nombre.Any(char.IsDigit))
            {
                Console.WriteLine("\nEl nombre no puede tener numeros.");
                Console.WriteLine("\nIngrese su nombre: ");
                per.Nombre = Console.ReadLine();
            }

            Console.WriteLine("\nIngrese su edad: ");
            while (!int.TryParse(Console.ReadLine(), out per.Edad))
            {
                Console.WriteLine("\nIngrese la edad este debe ser un número entero.");
                Console.WriteLine("\nIngrese su edad: ");
            }
            while (per.Edad <= 0)
            {
                Console.WriteLine("\nLa edad debe ser un número positivo. Por favor, ingrese una edad válida.");
                Console.WriteLine("\nIngrese su edad: ");
                per.Edad = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nIngrese su altura en cm: ");
            while (!double.TryParse(Console.ReadLine(), out per.Altura))
            {
                Console.WriteLine("\nIngrese la altura este debe ser un número con decimales.");
                Console.WriteLine("\nIngrese su altura en cm: ");
            }
            while (per.Altura <= 0)
            {
                Console.WriteLine("\nLa altura debe ser un número positivo. Por favor, ingrese una altura válida.");
                Console.WriteLine("\nIngrese su altura: ");
                per.Altura = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n¿Es estudiante? (true/false): ");
            while (!bool.TryParse(Console.ReadLine(), out per.Estudiante))
            {
                Console.WriteLine("\nIngrese un valor válido (true/false).");
                Console.WriteLine("\n¿Es estudiante? (true/false): ");
            }

            Console.WriteLine("\nNombre: " + per.Nombre);
            Console.WriteLine("Edad: " + per.Edad);
            Console.WriteLine("Altura en cm: " + per.Altura);
            Console.WriteLine("Estudiante: " + per.Estudiante);

            // Ejercicio 2 – Clase Vehiculo
            Vehiculo veh = new Vehiculo();

            Console.WriteLine("\nEjercicio 2 – Clase Vehiculo");

            Console.WriteLine("\nIngrese la marca: ");
            veh.Marca = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(veh.Marca))
            {
                Console.WriteLine("\nLa marca no puede estar vacía. Por favor, ingrese una marca válida.");
                Console.WriteLine("\nIngrese la marca: ");
                veh.Marca = Console.ReadLine();
            }
            while (veh.Marca.Any(char.IsDigit))
            {
                Console.WriteLine("\nLa marca no puede tener numeros.");
                Console.WriteLine("\nIngrese la marca: ");
                veh.Marca = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el modelo: ");
            veh.Modelo = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(veh.Modelo))
            {
                Console.WriteLine("\nEl modelo no puede estar vacío. Por favor, ingrese un modelo válido.");
                Console.WriteLine("\nIngrese el modelo: ");
                veh.Modelo = Console.ReadLine();
            }
            while (veh.Modelo.Any(char.IsDigit))
            {
                Console.WriteLine("\nEl modelo no puede tener numeros.");
                Console.WriteLine("\nIngrese el modelo: ");
                veh.Modelo = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el año: ");
            while (!int.TryParse(Console.ReadLine(), out veh.Año))
            {
                Console.WriteLine("\nIngrese el año este debe ser un número entero.");
                Console.WriteLine("\nIngrese el año: ");
            }
            while (veh.Año <= 0)
            {
                Console.WriteLine("\nEl año debe ser un número positivo. Por favor, ingrese un año válido.");
                Console.WriteLine("\nIngrese el año: ");
                veh.Año = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el color: ");
            veh.Color = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(veh.Color))
            {
                Console.WriteLine("\nEl color no puede estar vacío. Por favor, ingrese un color válido.");
                Console.WriteLine("\nIngrese el color: ");
                veh.Color = Console.ReadLine();
            }
            while (veh.Color.Any(char.IsDigit))
            {
                Console.WriteLine("\nEl color no puede tener numeros.");
                Console.WriteLine("\nIngrese el color: ");
                veh.Color = Console.ReadLine();
            }

            Console.WriteLine("Ingrese la placa: ");
            veh.Placa = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(veh.Placa))
            {
                Console.WriteLine("\nLa placa no puede estar vacía. Por favor, ingrese una placa válida.");
                Console.WriteLine("\nIngrese la placa: ");
                veh.Placa = Console.ReadLine();
            }
            while (veh.Placa.Any(char.IsDigit))
            {
                Console.WriteLine("\nLa placa no puede tener numeros.");
                Console.WriteLine("\nIngrese la placa: ");
                veh.Placa = Console.ReadLine();
            }

            Console.WriteLine("\nMarca: " + veh.Marca);
            Console.WriteLine("Modelo: " + veh.Modelo);
            Console.WriteLine("Año: " + veh.Año);
            Console.WriteLine("Color: " + veh.Color);
            Console.WriteLine("Placa: " + veh.Placa);

            // Ejercicio 3 – Clase Producto
            Producto pro = new Producto();

            Console.WriteLine("\nEjercicio 3 – Clase Producto");

            Console.WriteLine("\nIngrese el código: ");
            while (string.IsNullOrWhiteSpace(pro.Codigo))
            {
                Console.WriteLine("\nEl código no puede estar vacío. Por favor, ingrese un código válido.");
                Console.WriteLine("\nIngrese el código: ");
                pro.Codigo = Console.ReadLine();
            }
            while (pro.Codigo.Any(char.IsDigit))
            {
                Console.WriteLine("\nEl código no puede tener numeros.");
                Console.WriteLine("\nIngrese el código: ");
                pro.Codigo = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el nombre: ");
            pro.Nombre = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(pro.Codigo))
            {
                Console.WriteLine("\nEl nombre no puede estar vacío. Por favor, ingrese un nombre válido.");
                Console.WriteLine("\nIngrese el nombre: ");
                pro.Nombre = Console.ReadLine();
            }
            while (pro.Nombre.Any(char.IsDigit))
            {
                Console.WriteLine("\nEl nombre no puede tener numeros.");
                Console.WriteLine("\nIngrese el nombre: ");
                pro.Nombre = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el precio: ");
            while (!double.TryParse(Console.ReadLine(), out pro.Precio))
            {
                Console.WriteLine("\nIngrese el precio este debe ser un número con decimales.");
                Console.WriteLine("\nIngrese su precio: ");
            }
            while (pro.Precio <= 0)
            {
                Console.WriteLine("\nEl precio debe ser un número positivo. Por favor, ingrese un precio válido.");
                Console.WriteLine("\nIngrese su precio: ");
                pro.Precio = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el stock: ");
            while (!int.TryParse(Console.ReadLine(), out pro.Stock))
            {
                Console.WriteLine("\nIngrese el stock este debe ser un número entero.");
                Console.WriteLine("\nIngrese su stock: ");
            }
            while (pro.Stock < 0)
            {
                Console.WriteLine("\nEl stock no puede ser negativo. Por favor, ingrese un stock válido.");
                Console.WriteLine("\nIngrese su stock: ");
                pro.Stock = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("¿Está disponible? (true/false): ");
            while (!bool.TryParse(Console.ReadLine(), out pro.Disponible))
            {
                Console.WriteLine("\nIngrese un valor válido (true/false): ");
                Console.WriteLine("\n¿Está disponible? (true/false): ");
            }

            Console.WriteLine("\nCódigo: " + pro.Codigo);
            Console.WriteLine("Nombre: " + pro.Nombre);
            Console.WriteLine("Precio: " + pro.Precio);
            Console.WriteLine("Stock: " + pro.Stock);
            Console.WriteLine("Disponible: " + pro.Disponible);

            // Ejercicio 4 – Clase Mascota
            Mascota mas = new Mascota();

            Console.WriteLine("\nEjercicio 4 – Clase Mascota");

            Console.WriteLine("\nIngrese el nombre: ");
            mas.Nombre = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(mas.Nombre))
            {
                Console.WriteLine("\nEl nombre no puede estar vacío. Por favor, ingrese un nombre válido.");
                Console.WriteLine("\nIngrese el nombre: ");
                mas.Nombre = Console.ReadLine();
            }
            while (mas.Nombre.Any(char.IsDigit))
            {
                Console.WriteLine("\nEl nombre no puede tener numeros.");
                Console.WriteLine("\nIngrese el nombre: ");
                mas.Nombre = Console.ReadLine();
            }

            Console.WriteLine("Ingrese la especie: ");
            mas.Especie = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(mas.Especie))
            {
                Console.WriteLine("\nLa especie no puede estar vacía. Por favor, ingrese una especie válida.");
                Console.WriteLine("\nIngrese la especie: ");
                mas.Especie = Console.ReadLine();
            }
            while (mas.Especie.Any(char.IsDigit))
            {
                Console.WriteLine("\nLa especie no puede tener numeros.");
                Console.WriteLine("\nIngrese la especie: ");
                mas.Especie = Console.ReadLine();
            }

            Console.WriteLine("Ingrese la edad: ");
            while (!int.TryParse(Console.ReadLine(), out mas.Edad))
            {
                Console.WriteLine("\nIngrese una edad válida (número entero): ");
                Console.WriteLine("\nIngrese la edad: ");
            }
            while (mas.Edad < 0)
            {
                Console.WriteLine("\nLa edad no puede ser negativa. Por favor, ingrese una edad válida.");
                Console.WriteLine("\nIngrese la edad: ");
                mas.Edad = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el peso: ");
            while (!double.TryParse(Console.ReadLine(), out mas.Peso))
            {
                Console.WriteLine("\nIngrese un peso válido (número con decimales): ");
                Console.WriteLine("\nIngrese el peso: ");
            }
            while (mas.Peso < 0)
            {
                Console.WriteLine("\nEl peso no puede ser negativo. Por favor, ingrese un peso válido.");
                Console.WriteLine("\nIngrese el peso: ");
                mas.Peso = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("¿Está vacunado? (true/false): ");
            while (!bool.TryParse(Console.ReadLine(), out mas.Vacunado))
            {
                Console.WriteLine("\nIngrese un valor válido (true/false): ");
                Console.WriteLine("\n¿Está vacunado? (true/false): ");
            }

            Console.WriteLine("\nNombre: " + mas.Nombre);
            Console.WriteLine("Especie: " + mas.Especie);
            Console.WriteLine("Edad: " + mas.Edad);
            Console.WriteLine("Peso: " + mas.Peso);
            Console.WriteLine("Vacunado: " + mas.Vacunado);
        }
    }
}
