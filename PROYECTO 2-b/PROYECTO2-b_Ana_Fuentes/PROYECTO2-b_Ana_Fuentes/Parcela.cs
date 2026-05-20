using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO2_b_Ana_Fuentes
{
    internal class Parcela
    {
        private bool Ocupada;
        private string Tipo;
        private int MesesRestantes;
        private int MesesTotales;
        private double Ingreso;

        public bool ocupada
        {
            get { return Ocupada; }
            set { Ocupada = value; }
        }

        public string tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }

        public int mesesRestantes
        {
            get { return MesesRestantes; }
            set { MesesRestantes = value; }
        }

        public int mesesTotales
        {
            get { return MesesTotales; }
            set { MesesTotales = value; }
        }

        public double ingreso
        {
            get { return Ingreso; }
            set { Ingreso = value; }
        }

        public Parcela()
        {
            ocupada = false;
            tipo = "";
            mesesRestantes = 0;
            mesesTotales = 0;
            ingreso = 0;
        }

    }
}
