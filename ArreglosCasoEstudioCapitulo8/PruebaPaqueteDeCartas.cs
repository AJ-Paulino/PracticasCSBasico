namespace ArreglosCasoEstudioCapitulo8
{
    // Fig. 8.11: PruebaPaqueteDeCartas.cs
    // Aplicación para barajar y repartir cartas.
    public class PruebaPaqueteDeCartas
    {
        // ejecuta la aplicación
        public static void Main(string[] args)
        {
            PaqueteDeCartas miPaqueteDeCartas = new PaqueteDeCartas();
            miPaqueteDeCartas.Barajar(); // coloca las cartas en orden aleatorio

            // imprime las 52 cartas en el orden en el que se reparten
            for (int i = 0; i < 13; i++)
            {
                // reparte e imprime 4 objetos Carta
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}",
                miPaqueteDeCartas.RepartirCarta(), miPaqueteDeCartas.RepartirCarta(),
                miPaqueteDeCartas.RepartirCarta(), miPaqueteDeCartas.RepartirCarta());
            } // fin de for
        } // fin de Main
    } // fin de la clase PruebaPaqueteDeCartas
}

