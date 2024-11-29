using ArreglosCasoEstudioCapitulo8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosCasoEstudioCapitulo8
{
    // Fig. 8.9: Carta.cs
    // La clase Carta representa una carta de juego.
    public class Carta
    {
        private string cara; // cara de la carta ("As", "Dos", ...)
        private string palo; // palo de la carta ("Corazones", "Diamantes", ...)

        // el constructor con dos parámetros inicializa la cara y el palo de la carta
        public Carta(string caraCarta, string paloCarta)
        {
            cara = caraCarta; // inicializa la cara de la carta
            palo = paloCarta; // inicializa el palo de la carta
        } // fin del constructor de Carta con dos parámetros

        // devuelve representación de cadena del objeto Carta
        public override string ToString()
        {
            return cara + " de " + palo;
        } // fin del método ToString
    } // fin de la clase Carta
}
