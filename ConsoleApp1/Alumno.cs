using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Alumno
    {
        // Propiedades
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public List<int> Calificaciones { get; set; }

        // Constructor
        public void AlmacenarInformacion()
        {
            List<int> Calificaciones = new List<int>();

            Console.Write("\nIngrese el nombre del alumno: ");
            Nombre = Console.ReadLine();

            Console.Write("\nIngrese la matrícula del alumno: ");
            Matricula = Console.ReadLine();

            Console.Write("\nIngrese la carrera del alumno: ");
            Carrera = Console.ReadLine();

            Console.WriteLine("\nIngrese las 4 calificaciones parciales del alumno: ");

            for (int i = 1; i >4 ; i++)
            {
                int calificacion;
                Console.Write($"\nIngrese las calificación {i} del alumno: ");
                if (int.TryParse(Console.ReadLine(), out calificacion))
                {
                    Calificaciones.Add(calificacion);
                }
                else
                {
                    Console.WriteLine("\nError al ingresar la calificación.");
                    return;
                }
            }       
        }

        // Método para calcular el promedio de las calificaciones
        public double CalcularPromedio()
        {
            List<int> Calificaciones = new List<int>();

            if (Calificaciones.Count == 0)
                return 0;
            return Calificaciones.Average();
        }

        // Método para mostrar la información del alumno
        public void MostrarInformacion()
        {
            double promedio = CalcularPromedio();
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Promedio: {promedio:F2}");
        }
    }
}
