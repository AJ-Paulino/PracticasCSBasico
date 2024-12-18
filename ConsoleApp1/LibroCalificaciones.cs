﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    // Fig. 4.1: LibroCalificaciones.cs
    // Declaración de una clase con un método.
    //public class LibroCalificaciones
    //{
    //    // muestra un mensaje de bienvenida para el usuario de LibroCalificaciones
    //    public void MostrarMensaje()
    //    {
    //        Console.WriteLine("¡Bienvenido al Libro de calificaciones!");
    //    } // fin del método MostrarMensaje
    //} // fin de la clase LibroCalificaciones

    // Fig. 4.4: LibroCalificaciones.cs
    // Declaración de la clase con un método que tiene un parámetro.
    //public class LibroCalificaciones
    //{
    //    // muestra un mensaje de bienvenida para el usuario del LibroCalificaciones
    //    public void MostrarMensaje(string nombreCurso)
    //    {
    //        Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}!",
    //        nombreCurso);
    //    } // fin del método MostrarMensaje
    //} // fin de la clase LibroCalificaciones

    // Fig. 4.7: LibroCalificaciones.cs
    // Clase LibroCalificaciones que contiene una variable de instancia cursoNombre
    // y una propiedad para obtener (get) y establecer (set) su valor.
    //public class LibroCalificaciones
    //{
    //    private string nombreCurso; // nombre del curso para este LibroCalificaciones

    //    // propiedad para obtener (get) y establecer (set) el nombre del curso
    //    public string NombreCurso
    //    {
    //        get
    //        {
    //            return nombreCurso;
    //        } // fin de get
    //        set
    //        {
    //            nombreCurso = value;
    //        } // fin de set
    //    } // fin de la propiedad NombreCurso

    //    // muestra un mensaje de bienvenida para el usuario de LibroCalificaciones
    //    public void MostrarMensaje()
    //    {
    //        // usa la propiedad NombreCurso para obtener el
    //        // nombre del curso que representa este LibroCalificaciones
    //        Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}!",
    //        NombreCurso); // muestra la propiedad NombreCurso
    //    } // fin del método MostrarMensaje
    //} // fin de la clase LibroCalificaciones

    // Fig. 4.12: LibroCalificaciones.cs
    // La clase LibroCalificaciones con un constructor para inicializar el nombre del curso.
    //public class LibroCalificaciones
    //{
    //    private string nombreCurso; // nombre del curso para este LibroCalificaciones

    //    // el constructor inicializa nombreCurso con el objeto string suministrado como  argumento
    //    public LibroCalificaciones(string nombre)
    //    {
    //        NombreCurso = nombre; // inicializa nombreCurso usando la propiedad
    //    } // fin del constructor

    //    // propiedad para obtener (get) y establecer (set) el nombre del curso
    //    public string NombreCurso
    //    {
    //        get
    //        {
    //            return nombreCurso;
    //        } // fin de get
    //        set
    //        {
    //            nombreCurso = value;
    //        } // fin de set
    //    } // fin de la propiedad NombreCurso

    //    // muestra un mensaje de bienvenida para el usuario del LibroCalificaciones
    //    public void MostrarMensaje()
    //    {
    //        // usa la propiedad NombreCurso para obtener el
    //        // nombre del curso que representa este LibroCalificaciones
    //        Console.WriteLine("Bienvenido al libro de calificaciones para\n{0}!",
    //        NombreCurso);
    //    } // fin del método MostrarMensaje
    //} // fin de la clase LibroCalificaciones

    // Fig. 4.15: Cuenta.cs
    // La clase Cuenta con un constructor para 
    // inicializar la variable de instancia saldo.
    public class Cuenta
    {
        private decimal saldo; // variable de instancia que almacena el saldo

        // constructor
        public Cuenta(decimal saldoInicial)
        {
            Saldo = saldoInicial; // establece el saldo usando la propiedad
        } // fin del constructor de Cuenta

        // acredita (suma) un monto a la cuenta
        public void Acredita(decimal monto)
        {
            Saldo = Saldo + monto; // suma monto al saldo 
        } // fin del método Acredita

        // una propiedad para obtener (get) y establecer (set) el saldo de una cuenta
        public decimal Saldo
        {
            get
            {
                return saldo;
            } // end get
            set
            {
                // valida que el valor sea mayor o igual a 0; 
                // si no lo es, el saldo permanece sin cambios
                if (value >= 0)
                    saldo = value;
            } // fin de set
        } // fin de la propiedad Saldo
    } // fin de la clase Cuenta
}
