using System;
class Program
{
    static void Main()
    {
        //Ejercicio 1
        Console.WriteLine("Ejercicio 1");
        string nombre = "Zelda Flores";
        int nivel = 10;
        float puntosdevida = 100.99f;
        bool esjefe = true;
        Console.WriteLine("Datos del Personaje");
        Console.WriteLine("Nombre: " + nombre + ", Nivel: " + nivel + ", Puntos de vida: " + puntosdevida + " y ¿Es un jefe?: " + esjefe);
        Console.WriteLine();

        //Ejercicio 2
        Console.WriteLine("Ejercicio 2");
        int Numeroentero = 1500;
        long Numerolargo = Numeroentero;
        double Numerodecimal = Numerolargo;
        Console.WriteLine("El numero es: " + Numerodecimal);
        Console.WriteLine();

        //Ejercicio 3
        Console.WriteLine("Ejercicio 3");
        double precioExacto = 45.89;
        double precioRedondeado = Math.Round(precioExacto);
        Console.WriteLine("Precio exacto: " + precioExacto);
        Console.WriteLine("Precio redondeado: " + precioRedondeado);
        Console.WriteLine();

        //Ejercicio 4
        Console.WriteLine("Ejercicio 4");
        Console.WriteLine("Ingrese un numero por consola:");
        string entradaUsuario = Console.ReadLine();
        int.Parse(entradaUsuario);
        int num1, num2, resultado;
        num1 = int.Parse(entradaUsuario);
        num2 = 5;
        resultado = num1 + num2;
        Console.WriteLine("El resultado de la suma con el numero 5 es de: " + resultado);
        Console.WriteLine();

        //Ejercicio 5
        Console.WriteLine("Ejercicio 5");
        string valorBoolenao = "true";
        Convert.ToBoolean(valorBoolenao);
        string valorDecimal = "25.5";
        Convert.ToDouble(valorDecimal);
        Console.WriteLine("Valor booleano: " + valorBoolenao);
        Console.WriteLine("Valor decimal: " + valorDecimal);
        Console.WriteLine();

        //Ejercicio 6
        Console.WriteLine("Ejercicio 6");
        double pi = 3.14159265;
        string texto = Math.PI.ToString("F2");
        Console.WriteLine("Valor de pi con dos decimales: " + texto);
        Console.WriteLine();

        //Ejercicio 7
        Console.WriteLine("Ejercicio 7");
        Console.WriteLine("Ingrese el precio de un producto: ");
        string precioTexto = Console.ReadLine();
        double precio = Convert.ToDouble(precioTexto);
        double iva = precio * 0.21;
        double precioFinal = precio + iva;
        Console.WriteLine("El precio final con IVA es: " + precioFinal);
        Console.WriteLine("El precio final con IVA redondeado es: " + (int)precioFinal);
        Console.WriteLine();

        // Final del programa
        Console.WriteLine("¡Gracias por usar el programa!");
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}