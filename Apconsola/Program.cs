//Hecho por Jose Izaac Robles Trinidad & Samir Dominguez Perez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arreglo
{
    class Program
    {
        private double[] datos;
        public void Ingresar() // En este objeto se ingresan los datos del arreglo
        {
            datos = new double[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese el valor numero " + f + " del arreglo: ");
                String linea;
                linea = Console.ReadLine();
                datos[f] = double.Parse(linea);
            }
            Console.Write("\n");
        }

        public void Imprimir() //En este objeto se muestran los valores tal y como se ingresaron
        {
            Console.Write("Los valores del arreglo son \n");
            for (int f = 0; f < 5; f++)
            {
                Console.Write("[" + datos[f] + "] ");
            }
            Console.WriteLine("\n");
        }

        public void Ordenar() // En este objeto se ordenan los datos del arreglo
        {
            Console.Write("Orden de menor a mayor \n");
            Array.Sort(datos);
            foreach (double value in datos)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");

            Console.Write("Orden de mayor a menor \n");
            Array.Reverse(datos);
            foreach (double value in datos)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");
        }

        public void Guardar() // En este objeto se almacenan los datos del arreglo
        {
            using (StreamWriter writer = new StreamWriter("ArreglodeIzaac.txt", false))
            {
                for (int i = 0; i < datos.Length; i++)
                {
                    writer.WriteLine(datos[i].ToString());
                }
            }
        }

        public void Salir() // En este objeto se sale del programa de consola
        {
            Console.WriteLine("Saliendo...");
            return;
        }

        static void Main(string[] args)//main principal
        {
            Program pv = new Program();
            int Menu;
            for (int h = 0; h < 10000; h++)
            {  //Inicia ingreso de datos para la comparacion inicial

                Console.WriteLine("1. Ingresar los numeros" + "\n2. Mostrar los numeros" + "\n3. Ordenar los numeros" + "\n4. Guardar los numeros" + "\n5. Salir");
                Menu = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                switch (Menu)
                {
                    case 1: //Se llama al objeto Ingresar
                        Console.WriteLine("Ingreso de datos");
                        pv.Ingresar();
                        break;

                    case 2: //Se llama al objeto Imprimir
                        Console.WriteLine("Impresion de datos");
                        pv.Imprimir();
                        break;

                    case 3: //Se llama al objeto Ordenar
                        Console.WriteLine("Impresion de datos ordenados");
                        pv.Ordenar();
                        break;

                    case 4: //Se llama al objeto Guardar
                        Console.WriteLine("Guardado de los datos");
                        Console.WriteLine("\n");
                        pv.Guardar();
                        break;

                    case 5: //Se llama al objeto Salir
                        pv.Salir();
                        h = 10000; //Se asigna el valor 10000 para que la condicion se cumpla
                        break;

                    default: //En caso que el usuario ingrese un vaor incorrecto, el porgrama finaliza
                        Console.WriteLine("Error, dato erroneo");
                        h = 10000; //Se asigna el valor 10000 para que la condicion se cumpla
                        break;

                }
            }
        }
    }
}
