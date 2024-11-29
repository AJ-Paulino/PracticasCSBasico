using ArreglosCasoEstudioCapitulo8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosCasoEstudioCapitulo8
{
    public class PaqueteDeCartas
    {
        private Carta[] paquete; // arreglo de objetos Carta
        private int cartaActual; // subíndice de la siguiente Carta a repartir
        private const int NUMERO_DE_CARTAS = 52; // constante para el número de objetos Carta
        private Random numerosAleatorios; // generador de números aleatorios

        // el cosntructor llena el paquete de objetos Carta
        public PaqueteDeCartas()
        {
            string[] caras = { "As", "Dos", "Tres", "Cuatro", "Cinco", "Seis",
"Siete", "Ocho", "Nueve", "Diez", "Joto", "Qüina", "Rey" };
            string[] palos = { "Corazones", "Diamantes", "Tréboles", "Espadas" };

            paquete = new Carta[NUMERO_DE_CARTAS]; // crea un arreglo de objetos Carta
            cartaActual = 0; // establece cartaACtual para que la primera Carta repartida sea paquete[0]
            numerosAleatorios = new Random(); // crea el generador de números aleatorios

            // llena el paquete con objetos Carta
            for (int cuenta = 0; cuenta < paquete.Length; cuenta++)
                paquete[cuenta] =
                new Carta(caras[cuenta % 13], palos[cuenta / 13]);
        } // fin del constructor PaqueteDeCartas

        // baraja el paquete de objetos Carta con un algoritmo de una pasada
        public void Barajar()
        {
            // después de barajar, la repartición debe empezar otra vez en paquete[ 0 ]
            cartaActual = 0; // reinicializa cartaActual

            // para cada Carta, selecciona otra Carta aleatoria y las intercambia
            for (int primera = 0; primera < paquete.Length; primera++)
            {
                // selecciona un número aleatorio entre 0 y 51
                int segunda = numerosAleatorios.Next(NUMERO_DE_CARTAS);

                // intercambia la Carta actual con la Carta seleccionada al azar
                Carta temp = paquete[primera];
                paquete[primera] = paquete[segunda];
                paquete[segunda] = temp;
            } // fin de for
        } // fin del método Barajar

        // reparte una Carta
        public Carta RepartirCarta()
        {
            // determina si hay objetos Carta por repartir
            if (cartaActual < paquete.Length)
                return paquete[cartaActual++]; // devuelve la Carta actual en el arreglo
            else
                return null; // devuelve null para indicar que se repartieron todos los objetos Carta
        } // fin del método RepartirCarta
    } // fin de la clase PaqueteDeCartas
}
