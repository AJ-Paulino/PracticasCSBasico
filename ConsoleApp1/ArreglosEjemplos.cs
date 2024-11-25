using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios;

namespace Ejercicios
{
    internal class ArreglosEjemplos
    {
        // Fig. 8.2 Iniciar arreglo
        public void Ejercicio1()
        {
            int[] arreglo; // declara un arreglo llamado arreglo

            // crea el espacio para el arreglo y lo inicializa con ceros predeterminados
            arreglo = new int[10]; // 10 elementos int

            Console.WriteLine("{0}{1,8}", "Índice", "Valor"); // encabezados

            // imprime en pantalla el valor de cada elemento del arreglo
            for (int contador = 0; contador < arreglo.Length; contador++)
                Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
        }

        //Figura 8.3
        public void Ejercicio2()
        {
            // la lista inicializadora especifica el valor para cada elemento
            int[] arreglo = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };

            Console.WriteLine("{0}{1,8}", "Índice", "Valor"); // encabezados

            // imprime en pantalla el valor de cada elemento del arreglo
            for (int contador = 0; contador < arreglo.Length; contador++)
                Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
        }

        //Figura 8.4
        public void Ejercicio3()
        {
            const int LONGITUD_ARREGLO = 10; // crea una constante con nombre
            int[] arreglo = new int[LONGITUD_ARREGLO]; // crea el arreglo

            // calcula el valor para cada elemento del arreglo
            for (int contador = 0; contador < arreglo.Length; contador++)
                arreglo[contador] = 2 + 2 * contador;

            Console.WriteLine("{0}{1,8}", "Índice", "Valor"); // encabezados

            // imprime en pantalla el valor de cada elemento del arreglo
            for (int contador = 0; contador < arreglo.Length; contador++)
                Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
        }

        //Figura 8.5 Sumar arreglo
        public void Ejercicio4()
        {
            int[] arreglo = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            // sumar el valor de cada elemento al total
            for (int contador = 0; contador < arreglo.Length; contador++)
                total += arreglo[contador];

            Console.WriteLine("Total de los elementos del arreglo: {0}", total);
        }

        //Figura 8.6 Gráfico barras
        public void Ejercicio5()
        {
            int[] arreglo = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1 };

            Console.WriteLine("Distribución de las calificaciones:");

            // para cada elemento del arreglo, mostrar en pantalla una barra del gráfico
            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                // muestra etiquetas de las barras ( "00-09: ", ..., "90-99: ", "100: " )
                if (contador == 10)
                    Console.Write(" 100: ");
                else
                    Console.Write("{0:D2}-{1:D2}: ",
                    contador * 10, contador * 10 + 9);

                // imprime barra de asteriscos
                for (int estrellas = 0; estrellas < arreglo[contador]; estrellas++)
                    Console.Write("*");

                Console.WriteLine(); // inicia una nueva línea de salida
            }
        }

        //Figura 8.7 Tirar dado
        public void Ejercicio6()
        {
            Random numerosAleatorios = new Random(); // generador de números aleatorios
            int[] frecuencia = new int[7]; // arreglo de contadores de frecuencia

            // tira el dado 6000 veces; usa el valor del dado como subíndice de frecuencia
            for (int tiro = 1; tiro <= 6000; tiro++)
                ++frecuencia[numerosAleatorios.Next(1, 7)];

            Console.WriteLine("{0}{1,10}", "Cara", "Frecuencia");

            // imprime en pantalla el valor de cada elemento del arreglo
            for (int cara = 1; cara < frecuencia.Length; cara++)
                Console.WriteLine("{0,4}{1,10}", cara, frecuencia[cara]);
        }

        //Figura 8.8 Encuesta Estudiantil
        public void Ejercicio7()
        {
            // arreglo de respuestas a la encuesta
            int[] respuestas = { 1, 2, 6, 4, 8, 5, 9, 7, 8, 10, 1, 6, 3, 8, 6, 10, 3, 8, 2, 7, 6, 5, 7, 6,
                8, 6, 7, 5, 6, 6, 5, 6, 7, 5, 6, 4, 8, 6, 8, 10 };
            int[] frecuencia = new int[11]; // arreglo de contadores de frecuencia

            // para cada respuesta, selecciona el elemento de respuestas y usa ese valor 
            // como subíndice de frecuencia para determinar el elemento a incrementar
            for (int respuesta = 0; respuesta < respuestas.Length; respuesta++)
                ++frecuencia[respuestas[respuesta]];

            Console.WriteLine("{0}{1,11}", "Calificación", "Frecuencia");

            // imprime en pantalla el valor de cada elemento del arreglo
            for (int calificacion = 1; calificacion < frecuencia.Length; calificacion++)
                Console.WriteLine("{0,12}{1,11}", calificacion, frecuencia[calificacion]);
        }

        //Figura 8.9 Carta

        private string cara; // cara de la carta ("As", "Dos", ...)
        private string palo; // palo de la carta ("Corazones", "Diamantes", ...)

        public void Ejercicio8(string caraCarta, string paloCarta)
        {
            cara = caraCarta; // inicializa la cara de la carta
            palo = paloCarta; // inicializa el palo de la carta
        }
        public override string ToString()
        {
            return cara + " de " + palo;
        } // fin del método ToString
    }
}