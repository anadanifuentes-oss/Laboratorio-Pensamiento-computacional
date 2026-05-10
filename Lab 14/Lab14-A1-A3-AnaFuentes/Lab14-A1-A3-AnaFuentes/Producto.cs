using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_A1_A3_AnaFuentes
{
    internal class Producto
    {
        //Atributos

        string nombre;
        double precio;
        int cantidad;

        //Constructor
        public Producto(string nombreIngresado, double precioIngresado, int cantidadIngresada)
        {
            this.nombre = nombreIngresado;
            this.precio = precioIngresado;
            this.cantidad = cantidadIngresada;
        }

        //Métodos

        //Mostrar info
        public void MostrarInfo()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Producto: " + nombre);
            Console.WriteLine("Precio: " + precio);
            Console.WriteLine("Cantidad: " + cantidad);
            Console.WriteLine("---------------------------------------------------------------");
        }

        // Vender
        public void Vender(int cantidadVendida)
        {
            if (cantidad >= cantidadVendida)
            {
                this.cantidad -= cantidadVendida;
                Console.WriteLine("\nVenta completada exitosamente. Se vendieron " + cantidadVendida + " unidades de " + nombre);
            }
            else
            {
                Console.WriteLine("\nNo se pudo completar la venta. No hay suficiente stock de " + nombre);
            }
        }
        //Reabastecer
        public void Reabastecer(int cantidadReabastecida)
        {
            this.cantidad += cantidadReabastecida;
            Console.WriteLine("\nReabastecimiento completado exitosamente. Se reabastecieron " + cantidadReabastecida + " unidades de " + nombre);
        } 
    }
}