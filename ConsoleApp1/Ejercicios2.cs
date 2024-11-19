using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios;

namespace Ejercicios
{
    internal class Ejercicios2
    {
        public void ProcesarPiezas()
        {
            int contador = 0;
            string piezas = string.Empty;
            double largo = 0;
            int numeroPiezas = 0;
            int piezasActas = 0;    

            try
            {
                Console.Write("\nIngrese la cantidad de piezas a procesar: ");
                piezas = Console.ReadLine();

                if (!int.TryParse(piezas, out numeroPiezas))
                {
                    Console.WriteLine("\nDebe ingresar la cantidad de piezas a procesar.")
                        ; return;
                }

                if (numeroPiezas < 0)
                {
                    Console.WriteLine("\nDebe ingresar una medida en números de valor positivo.")
                        ; return;
                }

                while (numeroPiezas > contador)
                {
                    Console.Write("\nIngrese la medida de la pieza: ");
                    largo = double.Parse(Console.ReadLine());

                    if (largo <= 1.30 && largo >= 1.20)
                    {
                        piezasActas++;
                    }

                    contador++;
                }

                Console.WriteLine($"\nEl número de piezas actas es: {piezasActas}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError calculando los datos: {e.Message}");
                return;
            }
        }
    }
}
