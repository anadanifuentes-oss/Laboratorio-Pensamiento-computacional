using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO2_b_Ana_Fuentes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // INICIO DEL SISTEMA

            // LAS VALIDACIONES TAMBIEN SON ENTRADAS DE DATOS, NO SOLO DE OPCIONES

            // MENSAJE DE BIENVENIDA

            Console.WriteLine("Bienvenido al sistema de gestion de granja!!!");
            Console.WriteLine("Ingrese los datos iniciales para comenzar.");

            // VARIABLES GENERALES DEL SISTEMA DE GRANJA

            double dinero;
            int empleados;
            double sueldo;
            int meses;
            int filas;
            int columnas;
            int opcion;
            int opcionPlanta;
            int cantidad;
            int tipo;

            // ENTRADA DE DATOS INICIALES

            // DATOS INICIALES

            // NUMERO DE EMPLEADOS
            Console.WriteLine("\nIngrese numero de empleados:");
            while (!int.TryParse(Console.ReadLine(), out empleados) || empleados <= 0)
            {
                Console.WriteLine("\nEntrada invalida. Ingrese un numero positivo:");
            }

            // SUELDO
            Console.WriteLine("\nIngrese sueldo por empleado:");
            while (!double.TryParse(Console.ReadLine(), out sueldo) || sueldo <= 0)
            {
                Console.WriteLine("\nEntrada invalida. Ingrese un sueldo valido:");
            }

            // MESES
            Console.WriteLine("\nIngrese meses a simular:");
            while (!int.TryParse(Console.ReadLine(), out meses) || meses <= 0)
            {
                Console.WriteLine("\nEntrada invalida. Ingrese meses validos:");
            }

            // CALCULO DEL DINERO MINIMO

            double gastoTotal = empleados * sueldo * meses;

            Console.WriteLine($"\nComo recomendación. Necesita al menos Q{gastoTotal} para pagar a los empleados durante estos {meses} meses.");

            double gastoActual = gastoTotal / meses;

            Console.WriteLine($"\nActualmente, cada mes necesita al menos Q{gastoActual} para pagar a los empleados.");
            Console.WriteLine("Tambien considere que esta sera la cantidad minima a ingresar.");
            Console.WriteLine("\nAl igual que considere que el minimo para comprar semillas sera de Q100.");

            // DINERO INICIAL

            Console.WriteLine("\nIngrese dinero inicial:");
            while (!double.TryParse(Console.ReadLine(), out dinero) || dinero <= 0 || dinero < gastoActual )
            {
                Console.WriteLine($"\nDinero insuficiente. Ingrese un monto positivo que considere la cantidad salarial mensual de los empleados que es Q{gastoActual}:");
            }

            Console.WriteLine("\nIngrese filas (Todas las filas comienzan desde 0):");
            while (!int.TryParse(Console.ReadLine(), out filas) || filas <= 0)
            {
                Console.WriteLine("\nEntrada invalida. Ingrese un numero entero positivo para filas:");
            }

            Console.WriteLine("\nIngrese columnas (Todas las columnas comienzan desde 0):");
            while (!int.TryParse(Console.ReadLine(), out columnas) || columnas <= 0)
            {
                Console.WriteLine("\nEntrada invalida. Ingrese un numero entero positivo para columnas:");
            }

            Console.WriteLine("\nDatos ingresados correctamente.");

            // MATRIZ DE PARCELAS

            Parcela[,] parcelas = new Parcela[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    parcelas[i, j] = new Parcela();
                }
            }

            // INVENTARIO

            int trigo = 0;
            int repollo = 0;
            int tomate = 0;
            int calabaza = 0;
            int esparrago = 0;


            // ESTADISTICAS

            double ingresosTotales = 0;
            double costoSalarios = 0;
            double costoSemillas = 0;

            double capitalInicial = dinero;

            // CICLO PRINCIPAL

            while (meses > 0 && dinero > 0)
            {
                Console.WriteLine("\n=============================");
                Console.WriteLine("         MENU PRINCIPAL");
                Console.WriteLine("=============================");

                Console.WriteLine("\nMeses restantes: " + meses);
                Console.WriteLine("Dinero actual: Q" + dinero);
                Console.WriteLine("\nSi ya no le queda dinero para comprar semillas o realizar alguna accion, salga del programa.");

                Console.WriteLine("\n1. Comprar semillas");
                Console.WriteLine("2. Sembrar");
                Console.WriteLine("3. Consultar parcelas");
                Console.WriteLine("4. Avanzar mes");
                Console.WriteLine("5. Salir");


                // VALIDACION DE OPCION

                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("\nEntrada invalida. Ingrese una opcion del 1 al 5:");
                }

                switch (opcion)
                {
                    // COMPRAR SEMILLAS

                    case 1:

                        Console.WriteLine("\n===== COMPRA DE SEMILLAS =====");

                        double costosMensuales = empleados * sueldo;

                        Console.WriteLine("\nCaja: Q" + dinero);

                        Console.WriteLine("Costos mensuales proyectados: Q" + costosMensuales);

                        double utilidad = dinero - costosMensuales;

                        Console.WriteLine("Utilidad disponible: Q" + utilidad);

                        // VALIDACION FINANCIERA

                        if (utilidad <= 0)
                        {
                            Console.WriteLine("\nNo puede comprar semillas.");
                            break;
                        }

                        // MOSTRAR OPCIONES DE PLANTAS

                        Console.WriteLine("\n1. Trigo - Meses a crecer 1");
                        Console.WriteLine("   Costo: Q100");
                        Console.WriteLine("   Ganancia: Q130");

                        Console.WriteLine("\n2. Repollo - Meses a crecer 2");
                        Console.WriteLine("   Costo: Q180");
                        Console.WriteLine("   Ganancia: Q280");

                        Console.WriteLine("\n3. Tomate - Meses a crecer 3");
                        Console.WriteLine("   Costo: Q250");
                        Console.WriteLine("   Ganancia: Q450");

                        Console.WriteLine("\n4. Calabaza - Meses a crecer 4");
                        Console.WriteLine("   Costo: Q220");
                        Console.WriteLine("   Ganancia: Q360");

                        Console.WriteLine("\n5. Esparrago - Meses a crecer 6");
                        Console.WriteLine("   Costo: Q500");
                        Console.WriteLine("   Ganancia: Q1000");

                        Console.WriteLine("\nSeleccione una planta:");

                        // VALIDACION DE OPCION DE PLANTA

                        while (!int.TryParse(Console.ReadLine(), out opcionPlanta) || opcionPlanta < 1 || opcionPlanta > 5)
                        {
                            Console.WriteLine("\nEntrada invalida. Ingrese una opcion del 1 al 5:");
                        }

                        Console.WriteLine("\nCantidad:");

                        while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
                        {
                            Console.WriteLine("\nEntrada invalida. Ingrese una cantidad positiva:");
                        }

                        double costoCompra = 0;

                        switch (opcionPlanta)
                        {
                            case 1:
                                costoCompra = cantidad * 100;
                                break;

                            case 2:
                                costoCompra = cantidad * 180;
                                break;

                            case 3:
                                costoCompra = cantidad * 250;
                                break;

                            case 4:
                                costoCompra = cantidad * 220;
                                break;

                            case 5:
                                costoCompra = cantidad * 500;
                                break;

                            default:
                                Console.WriteLine("\nOpcion invalida");
                                break;
                        }

                        // VALIDACION NUEVA

                        // NO GASTAR DINERO DE SALARIOS

                        if (costoCompra > utilidad)
                        {
                            Console.WriteLine("\nERROR: No puedes gastar dinero reservado para salarios.");
                            break;
                        }

                        // REALIZAR COMPRA

                        switch (opcionPlanta)
                        {
                            case 1:

                                trigo += cantidad;

                                dinero -= costoCompra;

                                costoSemillas += costoCompra;

                                break;

                            case 2:

                                repollo += cantidad;

                                dinero -= costoCompra;

                                costoSemillas += costoCompra;

                                break;

                            case 3:

                                tomate += cantidad;

                                dinero -= costoCompra;

                                costoSemillas += costoCompra;

                                break;

                            case 4:

                                calabaza += cantidad;

                                dinero -= costoCompra;

                                costoSemillas += costoCompra;

                                break;

                            case 5:

                                esparrago += cantidad;

                                dinero -= costoCompra;

                                costoSemillas += costoCompra;

                                break;
                        }

                        Console.WriteLine("\nCompra realizada.");

                        Console.WriteLine("Dinero restante: Q" + dinero);

                        break;

                    // SEMBRAR

                    case 2:
                        int i, j;

                        Console.WriteLine("\n===== SEMBRAR =====");

                        Console.WriteLine("Cantidad disponible de cada tipo de siembra:");
                        Console.WriteLine("\n1. Trigo: " + trigo);
                        Console.WriteLine("2. Repollo: " + repollo);
                        Console.WriteLine("3. Tomate: " + tomate);
                        Console.WriteLine("4. Calabaza: " + calabaza);
                        Console.WriteLine("5. Esparrago: " + esparrago);

                        // VALIDACION DE FILA Y COLUMNA

                        Console.WriteLine("\nFila (Ingrese una fila entre 0 y " + (filas - 1) + "):");
                        while (!int.TryParse(Console.ReadLine(), out i) || i < 0 || i >= filas)
                        {
                            Console.WriteLine("\nEntrada invalida. Ingrese una fila entre 0 y " + (filas - 1) + ":");
                        }

                        Console.WriteLine("\nColumna (Ingrese una columna entre 0 y " + (columnas - 1) + "):");
                        while (!int.TryParse(Console.ReadLine(), out j) || j < 0 || j >= columnas)
                        {
                            Console.WriteLine("\nEntrada invalida. Ingrese una columna entre 0 y " + (columnas - 1) + ":");
                        }

                        // VALIDACION DE POSICION Y PARCELA

                        if (i < 0 || i >= filas || j < 0 || j >= columnas)
                        {
                            Console.WriteLine("\nPosicion invalida.");
                            break;
                        }

                        if (parcelas[i, j].ocupada)
                        {
                            Console.WriteLine("\nParcela ocupada.");
                            break;
                        }

                        Console.WriteLine("\nInventario:");

                        Console.WriteLine("1. Trigo: " + trigo);
                        Console.WriteLine("2. Repollo: " + repollo);
                        Console.WriteLine("3. Tomate: " + tomate);
                        Console.WriteLine("4. Calabaza: " + calabaza);
                        Console.WriteLine("5. Esparrago: " + esparrago);

                        Console.WriteLine("\nSeleccione cultivo:");

                        // VALIDACION DE TIPO DE CULTIVO

                        while (!int.TryParse(Console.ReadLine(), out tipo) || tipo < 1 || tipo > 5)
                        {
                            Console.WriteLine("\nEntrada invalida. Ingrese un numero entre 1 y 5:");
                        }

                        switch (tipo)
                        {
                            case 1:

                                if (trigo > 0)
                                {
                                    parcelas[i, j].ocupada = true;
                                    parcelas[i, j].tipo = "Trigo";
                                    parcelas[i, j].mesesRestantes = 1;
                                    parcelas[i, j].mesesTotales = 1;
                                    parcelas[i, j].ingreso = 130;

                                    trigo--;

                                    Console.WriteLine("\nTrigo sembrado.");
                                }
                                else
                                {
                                    Console.WriteLine("\nSin inventario, no puede sembrar.");
                                }

                                break;

                            case 2:

                                if (repollo > 0)
                                {
                                    parcelas[i, j].ocupada = true;
                                    parcelas[i, j].tipo = "Repollo";
                                    parcelas[i, j].mesesRestantes = 2;
                                    parcelas[i, j].mesesTotales = 2;
                                    parcelas[i, j].ingreso = 280;

                                    repollo--;

                                    Console.WriteLine("\nRepollo sembrado.");
                                }
                                else
                                {
                                    Console.WriteLine("\nSin inventario, no puede sembrar.");
                                }

                                break;

                            case 3:

                                if (tomate > 0)
                                {
                                    parcelas[i, j].ocupada = true;
                                    parcelas[i, j].tipo = "Tomate";
                                    parcelas[i, j].mesesRestantes = 3;
                                    parcelas[i, j].mesesTotales = 3;
                                    parcelas[i, j].ingreso = 450;

                                    tomate--;

                                    Console.WriteLine("\nTomate sembrado.");
                                }
                                else
                                {
                                    Console.WriteLine("\nSin inventario, no puede sembrar.");
                                }

                                break;

                            case 4:

                                if (calabaza > 0)
                                {
                                    parcelas[i, j].ocupada = true;
                                    parcelas[i, j].tipo = "Calabaza";
                                    parcelas[i, j].mesesRestantes = 4;
                                    parcelas[i, j].mesesTotales = 4;
                                    parcelas[i, j].ingreso = 360;

                                    calabaza--;

                                    Console.WriteLine("\nCalabaza sembrada.");
                                }
                                else
                                {
                                    Console.WriteLine("\nSin inventario, no puede sembrar.");
                                }

                                break;

                            case 5:

                                if (esparrago > 0)
                                {
                                    parcelas[i, j].ocupada = true;
                                    parcelas[i, j].tipo = "Esparrago";
                                    parcelas[i, j].mesesRestantes = 6;
                                    parcelas[i, j].mesesTotales = 6;
                                    parcelas[i, j].ingreso = 1000;

                                    esparrago--;

                                    Console.WriteLine("\nEsparrago sembrado.");
                                }
                                else
                                {
                                    Console.WriteLine("\nSin inventario, no puede sembrar.");
                                }

                                break;

                            default:
                                Console.WriteLine("\nOpcion invalida.");
                                break;
                        }

                        break;

                    // CONSULTAR PARCELAS

                    case 3:

                        ConsultarParcelas(parcelas, filas, columnas);

                        break;

                    // AVANZAR MES

                    case 4:

                        Console.WriteLine("\n===== AVANZANDO MES =====");

                        double salarioMes = empleados * sueldo;

                        // VALIDACION DE SALARIOS

                        if (salarioMes > dinero)
                        {
                            Console.WriteLine("\nNo tiene suficiente dinero para pagar salarios.");
                            Console.WriteLine("La granja ha quebrado.");

                            meses = 0;
                            break;
                        }

                        dinero -= salarioMes;

                        costoSalarios += salarioMes;

                        Console.WriteLine("\nSalarios pagados: Q" + salarioMes);

                        AvanzarMes(parcelas, filas, columnas, ref dinero, ref ingresosTotales);

                        meses--;

                        Console.WriteLine("Dinero actual: Q" + dinero);

                        Console.WriteLine("Meses restantes: " + meses);

                        Console.WriteLine("Cambio presentado en cada parcela.");

                        Console.WriteLine("Si la parcela se completo, se sumo al dinero total.");

                        break;

                    // SALIR

                    case 5:

                        meses = 0;

                        break;

                    default:

                        Console.WriteLine("\nOpcion invalida.");

                        break;
                }
            }

            // REPORTE FINAL

            double inventarioProceso = Inventario(parcelas, filas, columnas);

            Console.WriteLine("\n========================");
            Console.WriteLine("       REPORTE FINAL");
            Console.WriteLine("========================");

            Console.WriteLine("Capital inicial: Q" + capitalInicial);

            Console.WriteLine("Ingresos: Q" + ingresosTotales);

            Console.WriteLine("Inventario en proceso: Q" + inventarioProceso);

            Console.WriteLine("Mano de obra: Q" + costoSalarios);

            Console.WriteLine("Materia prima: Q" + costoSemillas);

            Console.WriteLine("Dinero final: Q" + dinero);

            double utilidades = capitalInicial + ingresosTotales + inventarioProceso - costoSalarios - costoSemillas;

            Console.WriteLine("Utilidades finales: Q" + utilidades);

            // MENSAJE SI QUIEBRA

            if (dinero < (empleados * sueldo))
            {
                Console.WriteLine("\nLa granja se quedo sin dinero suficiente para operar.");
            }
        }

        // CONSULTAR PARCELAS

        static void ConsultarParcelas(Parcela[,] parcelas, int filas, int columnas)
        {
            int f, c;

            Console.WriteLine("\nMAPA DE PARCELAS:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (parcelas[i, j].ocupada)
                    {
                        Console.Write("[X]");
                    }
                    else
                    {
                        Console.Write("[ ]");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nFila:");
            while (!int.TryParse(Console.ReadLine(), out f) || f < 0 || f >= filas)
            {
                Console.WriteLine("\nEntrada invalida. Ingrese una fila entre 0 y " + (filas - 1) + ":");
            }

            Console.WriteLine("\nColumna:");
            while (!int.TryParse(Console.ReadLine(), out c) || c < 0 || c >= columnas)
            {
                Console.WriteLine("\nEntrada invalida. Ingrese una columna entre 0 y " + (columnas - 1) + ":");
            }

            if (parcelas[f, c].ocupada == false)
            {
                Console.WriteLine("\nParcela libre.");
                Console.WriteLine("Ingreso esperado: Q0");
            }
            else
            {
                Console.WriteLine("\nCultivo: " + parcelas[f, c].tipo);

                Console.WriteLine("Meses totales: " + parcelas[f, c].mesesTotales);

                Console.WriteLine("Meses restantes: " + parcelas[f, c].mesesRestantes);

                Console.WriteLine("Ingreso esperado: Q" + parcelas[f, c].ingreso);
            }
        }

        // AVANZAR MES

        static void AvanzarMes(Parcela[,] parcelas, int filas, int columnas, ref double dinero, ref double ingresosTotales)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (parcelas[i, j].ocupada)
                    {
                        parcelas[i, j].mesesRestantes--;

                        Console.WriteLine("\n=====================================");
                        Console.WriteLine("Parcela " + i + "," + j);
                        Console.WriteLine("Cultivo: " + parcelas[i, j].tipo);
                        Console.WriteLine("\n=====================================");

                        if (parcelas[i, j].mesesRestantes > 0)
                        {
                            Console.WriteLine("\nCultivo en proceso.");
                            Console.WriteLine("Meses restantes: " + parcelas[i, j].mesesRestantes);
                            Console.WriteLine("Ingreso esperado: Q" + parcelas[i, j].ingreso);
                        }

                        if (parcelas[i, j].mesesRestantes == 0)
                        {
                            Console.WriteLine("\nCosecha completada en parcela " + i + "," + j);
                            Console.WriteLine("Ingreso obtenido: Q" + parcelas[i, j].ingreso);

                            dinero += parcelas[i, j].ingreso;

                            ingresosTotales += parcelas[i, j].ingreso;

                            parcelas[i, j].ocupada = false;
                            parcelas[i, j].tipo = "";
                            parcelas[i, j].mesesRestantes = 0;
                            parcelas[i, j].mesesTotales = 0;
                            parcelas[i, j].ingreso = 0;

                        }
                    }
                }
            }
        }

        // INVENTARIO

        static double Inventario(Parcela[,] parcelas, int filas, int columnas)
        {
            double inventarioProceso = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (parcelas[i, j].ocupada)
                    {
                        inventarioProceso += parcelas[i, j].ingreso;
                    }
                }
            }

            return inventarioProceso;
        }
    }
}
        
    

