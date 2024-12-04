using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class EjerciciosClasesYObjetos
    {
        public class Puntos
        {
            private double x;
            private double y;

            // Método para cargar los valores de x e y
            public void CargarValoresXY()
            {
                Console.Write("\nIngrese el valor de X: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nIngrese el valor de Y: ");
                y = Convert.ToDouble(Console.ReadLine());
            }

            // Método para imprimir en qué cuadrante se encuentra el punto
            public void ImprimirCuadrante()
            {
                try
                {
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("El punto se encuentra en el primer cuadrante.");
                    }
                    else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("El punto se encuentra en el segundo cuadrante.");
                    }
                    else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("El punto se encuentra en el tercer cuadrante.");
                    }
                    else if (x > 0 && y < 0)
                    {
                        Console.WriteLine("El punto se encuentra en el cuarto cuadrante.");
                    }
                    else if (x == 0 && y != 0)
                    {
                        Console.WriteLine("El punto se encuentra sobre el eje Y.");
                    }
                    else if (y == 0 && x != 0)
                    {
                        Console.WriteLine("El punto se encuentra sobre el eje X.");
                    }
                    else
                    {
                        Console.WriteLine("El punto se encuentra en el origen.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Los datos ingresados deben ser numéricos. {ex.Message}");
                }
            }
        }
    }
}
