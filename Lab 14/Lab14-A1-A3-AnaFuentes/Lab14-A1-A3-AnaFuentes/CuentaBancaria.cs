using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_A1_A3_AnaFuentes
{
    internal class CuentaBancaria
    {
        //Atributos

        double saldo;
        string titular;
        string numeroCuenta;

        //Constructor
        public CuentaBancaria(string nombreIngresado, string numeroCuentaGenerado)
        { 
            this.titular = nombreIngresado;
            this.numeroCuenta = numeroCuentaGenerado;
            this.saldo = 50; 
        }

        //Métodos

        //Mostrar info
        public void MostrarInfo()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Cuenta : " + numeroCuenta.ToString() + " - " + titular);
            Console.WriteLine("Saldo: " + saldo.ToString());
            Console.WriteLine("---------------------------------------------------------------");
        }

        // Depositar
        public void Depositar(double monto)
        {
            this.saldo += monto;
            Console.WriteLine("\nDepósito realizado: " + monto.ToString() + "Q, en cuenta de " + titular);
        }

        //Retirar
        public void Retirar(double monto2)
        {
            if (this.saldo >= monto2)
            { 
                this.saldo -= monto2;
                Console.WriteLine("\nRetiro realizado de: " + monto2.ToString() + "Q, en cuenta de " + titular);
            }
            else
            {
                Console.WriteLine("\nSaldo insuficiente para realizar el retiro.");
            }

        }
    }
}
