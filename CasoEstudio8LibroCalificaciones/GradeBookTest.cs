namespace CasoEstudio8LibroCalificaciones
{
    // Fig. 8.16: PruebaLibroCalificaciones.cs
    // Crea objeto LibroCalificaciones que utiliza un arreglo de calificaciones.
    public class GradeBookTest
    {
        // El método Main comienza la ejecución de la aplicación
        public static void Main(string[] args)
        {
            // arreglo unidimensional de calificaciones de estudiantes
            int[] arregloCalificaciones = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

            LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones(
            "CS101 Introducción a la programación en C#", arregloCalificaciones);
            miLibroCalificaciones.MostrarMensaje();
            miLibroCalificaciones.ProcesarCalificaciones();
        } // fin de Main
    } // fin de la clase PruebaLibroCalificaciones
}
