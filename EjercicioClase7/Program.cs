using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioClase7
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadAlumnos;
            string num;
            double suma = 0, promedio, minima = 10.0, maxima = 0;

            Console.WriteLine("BIENVENIDO. A continuación cargue los datos.");
            Console.Write("Ingrese la cantidad de alumnos: ");
            num = Console.ReadLine();
            cantidadAlumnos = Convert.ToInt32(num);
            Console.WriteLine("");

            double[] calificaciones = new double[cantidadAlumnos];

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese la calificación " + (i + 1));
                num = Console.ReadLine();
                calificaciones[i] = Convert.ToInt32(num);
            }

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                suma += calificaciones[i];
            }

            promedio = suma / cantidadAlumnos;

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                if (calificaciones[i] < minima)
                {
                    minima = calificaciones[i];
                }

                if (calificaciones[i] > maxima)
                {
                    maxima = calificaciones[i];
                }
            }

            Console.Clear();
            Console.WriteLine("El promedio es de: " + promedio);

            Console.WriteLine("");
            Console.WriteLine("La calificación mas alta es: " + maxima);

            Console.WriteLine("");
            Console.WriteLine("La calificación mas baja es: " + minima);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
