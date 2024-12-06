using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }
               
        public void AlmacenarInformacion()
        {
            try
            {
                Console.Write("\nIntroduce el título del libro: ");
                Titulo = Console.ReadLine();

                Console.Write("\nIntroduce el autor del libro: ");
                Autor = Console.ReadLine();

                Console.Write("\nIntroduce el número de páginas del libro: ");
                Paginas = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError al leer los datos ingresados: {e.Message}");
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"\nTítulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Páginas: {Paginas}");
        }

        public bool EsLargo()
        {            
            return Paginas > 500;
        }
    } 
}
