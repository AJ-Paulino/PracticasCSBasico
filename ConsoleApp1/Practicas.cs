﻿using Ejercicios;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Practicas
{
    private static void Main(string[] args)
    {
        //Ejercicios2 ejercicios2 = new Ejercicios2();
        //ejercicios2.ProcesarPiezas();


        //programación bucles for

        //1) Dado un conjunto de datos representando las dimensiones de triángulos,
        //calcular y contar aquellos cuya área excede un valor límite.
        //CalcularTriangulo();

        //2) Crear un programa que cuente cuántos números, de un conjunto de 10, son divisibles por 3 o por 5.
        //CalcularNumerosDivisibles();

        //3) Desarrollar un programa que permita ingresar 10 números y luego muestre la suma de los últimos 5 números ingresados.
        //SumarUltimos5();

        //Desarrollar programa que calcule la base, altura y área de un triangulo
        //    Diseñar un algoritmo que:
        //CalcularTriangulo2();

        //programación bucles while

        //Implementa una aplicación que solicite diez calificaciones numéricas
        //y calcule la cantidad de estudiantes que alcanzaron una calificación mínima de 7
        //y la cantidad que quedó por debajo de este límite.
        //CalcularNota();

        //Escribe un algoritmo que, para una empresa con 'n' empleados y un rango salarial de $100 a $500,
        //cuente cuántos empleados se encuentran en cada uno de los siguientes grupos: $100-$300 y mayor a $300.
        //Asimismo, calcula el gasto total en nómina.
        //CalcularNomina();

        //-----------------------------------------------------------------------------------------------------------

        //Prácticas de Arrays

        //Ejemplos del capítulo 8
        ArreglosEjemplos arreglosEjemplos = new ArreglosEjemplos();

        //Figura 8.2 Iniciar arreglo
        //arreglosEjemplos.Ejercicio1();

        //Figura 8.3
        //arreglosEjemplos.Ejercicio2();

        //Figura 8.4
        //arreglosEjemplos.Ejercicio3();

        //Figura 8.5 Sumar arreglo
        //arreglosEjemplos.Ejercicio3();

        //Figura 8.6 Gráfico barras
        //arreglosEjemplos.Ejercicio5();

        //Figura 8.7 Tirar dado
        //arreglosEjemplos.Ejercicio6();

        //Figura 8.8 Encuesta Estudiantil
        //arreglosEjemplos.Ejercicio7();

        //Figura 8.9 Carta
        Ejercicio8 ejercicio8 = new Ejercicio8();
        ejercicio8.Carta();
    }

    //programación bucles while

    //Implementa una aplicación que solicite diez calificaciones numéricas
    //y calcule la cantidad de estudiantes que alcanzaron una calificación mínima de 7
    //y la cantidad que quedó por debajo de este límite.
    public static void CalcularNota()
    {
        int calificacion = 0;
        const int calificaciones = 10;
        int entrada = 1;
        int calificacionMas7 = 0;
        int calificacionMenos7 = 0;
        int calificacionMinima = 7;

        try
        {
            Console.WriteLine("\n Ingrese 10 calificaciones:");

            while (entrada <= calificaciones)
            {
                Console.Write($"\n Ingrese la calificación {entrada}: ");
                calificacion = Convert.ToInt32(Console.ReadLine());

                if (calificacion >= calificacionMinima)
                {
                    calificacionMas7++;
                }
                if (calificacion < calificacionMinima)
                {
                    calificacionMenos7++;
                }

                entrada++;
            }

            Console.WriteLine($"\n {calificacionMas7} estudiantes obtuvieron una calificación mínima de {calificacionMinima}." +
                $"\n {calificacionMenos7} estudiantes obtuvieron una calificación menor a {calificacionMinima}.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nError al leer los datos ingresados. {e.Message}");
            return;
        }
    }

    //Escribe un algoritmo que, para una empresa con 'n' empleados y un rango salarial de $100 a $500,
    //cuente cuántos empleados se encuentran en cada uno de los siguientes grupos: $100-$300 y mayor a $300.
    //Asimismo, calcula el gasto total en nómina.
    private static void CalcularNomina()
    {
        int n = 0;
        int empleados = 1;
        int sueldo = 0;
        const int salarioMinimo = 100;
        const int salarioMedio = 300;
        const int salarioMaximo = 500;
        int grupo100y300 = 0;
        int grupoMas300 = 0;
        int gastoNomina = 0;

        try
        {
            Console.Write("\n Indique el número de empleados que tiene la empresa: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n >= empleados)
            {
                Console.Write($"\n Ingrese el salario del empleado #{empleados}: ");
                sueldo = int.Parse(Console.ReadLine());

                if (sueldo < salarioMinimo || sueldo > salarioMaximo)
                {
                    Console.WriteLine($"\n El sueldo de los empleados de esta empresa debe estar entre {salarioMinimo} y " +
                        $"{salarioMaximo}.");
                }

                if (sueldo >= salarioMinimo && sueldo <= salarioMedio)
                {
                    grupo100y300++;
                }

                if (sueldo > salarioMedio && sueldo <= salarioMaximo)
                {
                    grupoMas300++;
                }

                gastoNomina += sueldo;
                empleados++;
            }

            Console.WriteLine($"\n La cantidad de empleados con un rango salarial de entre 100 y 300 es: {grupo100y300}" +
                $"\n La cantidad de empleados con un rango salarial que supera los 300 es: {grupoMas300}" +
                $"\n El gasto total en nómina es: {gastoNomina}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"\n Error al leer los datos ingresados. {e.Message}");
            return;
        }
    }



    //Desarrollar programa que calcule la base, altura y área de un triangulo
    //    Diseñar un algoritmo que:

    //Solicite al usuario ingresar un número entero "n" que represente la cantidad de triángulos a procesar.
    //Para cada triángulo, capture los valores de la base y la altura.
    //Calcule el área de cada triángulo utilizando la fórmula correspondiente.
    //Muestre en pantalla los datos de cada triángulo (base, altura y área).
    //Determine y reporte la cantidad de triángulos con un área superior a 12 unidades cuadradas.
    public static void CalcularTriangulo2()
    {
        string n = string.Empty;
        double Base = 0;
        double altura = 0;
        double area = 0;
        const int areaLimite = 12;
        int trianguloLimiteExcedido = 0;
        int cantidad = 0;

        try
        {
            Console.Write("\nIngrese el número de triángilos que dese calcular: ");
            n = Console.ReadLine();

            if (int.TryParse(n, out cantidad))
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write("\nIngrese la medida de la base del triángulo: ");
                    Base = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese la medida de la altura del triángulo: ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    area = (Base * altura) / 2;

                    Console.WriteLine($"El área del triágulo es: {area}");

                    if (area > areaLimite)
                    {
                        trianguloLimiteExcedido++;
                    }
                }

                Console.WriteLine($"\nLa cantidad de triángulos que superan el área de ({areaLimite}) " +
                    $"es: {trianguloLimiteExcedido}");

            }
            else
            {
                Console.WriteLine("\nLa cantidad debe ser un número.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nError al calcular los datos ingresados. {e.Message}");
        }
    }

    //programación bucles for

    //1) Dado un conjunto de datos representando las dimensiones de triángulos,
    //calcular y contar aquellos cuya área excede un valor límite.
    public static void CalcularTriangulo()
    {
        string entrada = string.Empty;
        double Base = 0;
        double altura = 0;
        double area = 0;
        const int areaLimite = 25;
        int trianguloLimiteExcedido = 0;
        int cantidad = 0;

        try
        {
            Console.Write("\nIngrese el número de triángilos que dese calcular: ");
            entrada = Console.ReadLine();

            if (int.TryParse(entrada, out cantidad))
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write("\nIngrese la medida de la base del triángulo: ");
                    Base = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese la medida de la altura del triángulo: ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    area = (Base * altura) / 2;

                    Console.WriteLine($"El área del triágulo es: {area}");

                    if (area > 25)
                    {
                        trianguloLimiteExcedido++;
                    }
                }

                Console.WriteLine($"\nEl área límite de los triángulos es {areaLimite}. " +
                    $"\nEl total de triángulos que excedieron ese límite son: {trianguloLimiteExcedido}");

            }
            else
            {
                Console.WriteLine("\nLa cantidad debe ser un número.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nError al calcular los datos ingresados. {e.Message}");
        }
    }

    //2) Crear un programa que cuente cuántos números, de un conjunto de 10, son divisibles por 3 o por 5.
    public static void CalcularNumerosDivisibles()
    {
        const int cantidad = 10;
        int nums = 0;
        double d3 = 0;
        double d5 = 0;

        try
        {
            Console.WriteLine("\nIngrese 10 números: ");
            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"\nIngrese el número {i}: ");
                nums = Convert.ToInt32(Console.ReadLine());

                if (nums % 3 == 0)
                {
                    d3++;
                }

                if (nums % 5 == 0)
                {
                    d5++;
                }
            }

            Console.WriteLine($"\nEn esta lista hay {d3} números divisibles por 3; y {d5} números divisibles por 5.");

        }
        catch (Exception e)
        {
            Console.WriteLine($"\nError al leer los datos ingresados. {e.Message}");
        }
    }

    //3) Desarrollar un programa que permita ingresar 10 números y luego muestre la suma de los últimos 5 números ingresados.
    public static void SumarUltimos5()
    {
        int nums = 0;
        int contadorSuma = 0;
        const int numeros = 10;

        try
        {
            Console.WriteLine("\nIngrese 10 números: ");
            for (int i = 1; i <= numeros; i++)
            {
                Console.Write($"\nIngrese el número {i}: ");
                nums = Convert.ToInt32(Console.ReadLine());

                if (i + 4 >= numeros)
                {
                    contadorSuma += nums;
                }
            }

            Console.WriteLine($"\nLa suma de los últimos 5 dígitos ingresados es: {contadorSuma}");

        }
        catch (Exception e)
        {
            Console.WriteLine($"\nError a leer los datos ingresados. {e.Message}");
        }
    }

    static void CalcularNotas()
    {
        int aprobados = 0;
        int reprobados = 0;
        int cantidadNota = 0;
        int nota = 0;
        string valor = string.Empty;

        Console.Write("\nIngrese la cantidad de notas: ");
        valor = Console.ReadLine();

        try
        {
            if (int.TryParse(valor, out cantidadNota))
            {
                for (int i = 1; i <= cantidadNota; i++)
                {
                    Console.Write($"\nIngrese la nota {i}: ");
                    valor = Console.ReadLine();

                    if (int.TryParse(valor, out nota))
                    {
                        if (nota >= 7)
                        {
                            aprobados++;
                        }
                        else
                        {
                            reprobados++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nEl formato de la nota es inválido.");
                        continue;
                    }
                }
                Console.WriteLine($"\nAprobados: {aprobados}.\nReprobados: {reprobados}");
            }
            else
            {
                Console.WriteLine("\nEl formato de la cantidad de notas es inválido.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError calculando las notas. {ex.Message}");
        }
    }

    //3) Desarrollar un programa que calcule el nivel de un postulante a partir de los resultados de un test.
    // El programa recibirá como entrada el número total de preguntas y las respuestas correctas,
    // y devolverá un nivel según el porcentaje de aciertos.

    //    Nivel máximo: Porcentaje>=90%.
    //Nivel medio: Porcentaje>=75% y<90%.
    //Nivel regular: Porcentaje>=50% y<75%.
    //Fuera de nivel: Porcentaje<50%.
    static void Tarea3C()
    {
        double preguntas = 0;
        double respuestasC = 0;
        double porcentaje = 0;

        Console.Write("\nIngrese el número de preguntas que tiene el test: ");
        preguntas = Convert.ToDouble(Console.ReadLine());

        Console.Write("\nIngrese el número de preguntas contestadas correctamente: ");
        respuestasC = Convert.ToDouble(Console.ReadLine());

        porcentaje = (respuestasC / preguntas) * 100;
        porcentaje = Math.Round(porcentaje, 1);

        if (porcentaje >= 90)
        {
            Console.Write($"\nEl porcentaje de acierto es de nivel máximo: {porcentaje}%\n\n");
        }

        if (porcentaje >= 75 && porcentaje < 90)
        {
            Console.Write($"\nEl porcentaje de acierto es de nivel medio: {porcentaje}%\n\n");
        }

        if (porcentaje >= 50 && porcentaje < 75)
        {
            Console.Write($"\nEl porcentaje de acierto es de nivel regular: {porcentaje}%\n\n");
        }

        if (porcentaje < 50)
        {
            Console.Write($"\nEl porcentaje de acierto está fuera de nivel: {porcentaje}%\n\n");
        }
    }

    // 2) Leer tres calificaciones y calcular el promedio.
    // Si el promedio es igual o superior a siete, imprimir un mensaje indicando que el alumno ha aprobado.
    static void Tarea3B()
    {
        int nota1 = 0;
        int nota2 = 0;
        int nota3 = 0;
        int promedio = 0;

        Console.WriteLine("\nIngrese sus calificaciones:\n");

        Console.Write("\nIngrese la nota 1: ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nIngrese la nota 2: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nIngrese la nota 3: ");
        nota3 = Convert.ToInt32(Console.ReadLine());

        promedio = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"\n\nEl promedio de las calificaciones es: {promedio}\n");

        if (promedio >= 7)
        {
            Console.WriteLine("\nEl alumno ha aprobado");
        }
        else
        {
            Console.WriteLine("\nEl alumno no ha aprovado");
        }
    }

    //1) Diseñar un programa que solicite al usuario dos números y, si el primer número es más grande, 
    // calcule y muestre su suma y resta. De lo contrario, calculará y mostrará su producto y cociente.
    static void Tarea3A()
    {
        double num1 = 0;
        double num2 = 0;
        double suma = 0;
        double resta = 0;
        double producto = 0;
        double cociente = 0;

        Console.Write("\nIngrese el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nIngrese el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            suma = num1 + num2;
            resta = num1 - num2;

            Console.WriteLine($"\nLa suma de esos números es: {suma}\nLa resta de esos números es: {resta}");
        }
        else
        {
            producto = num1 * num2;
            cociente = num1 / num2;

            Console.WriteLine($"\nEl producto de esos números es: {producto}\nEl cociente entre esos número es: {cociente}");
        }
    }

    static void PromedioNota()
    {
        int nota1 = 0;
        int nota2 = 0;
        int nota3 = 0;
        int promedio = 0;

        Console.WriteLine("\nIngrese sus calificaciones:\n");

        Console.Write("\nIngrese la nota 1: ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nIngrese la nota 2: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nIngrese la nota 3: ");
        nota3 = Convert.ToInt32(Console.ReadLine());

        if (nota1 > 10 || nota1 < 0 || nota2 > 10 || nota2 < 0 || nota3 > 10 || nota3 < 0)
        {
            Console.WriteLine("\nLa nota debe estar entre 0 y 10 puntos");
        }
        else
        {
            promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"\n\nEl promedio de las calificaciones es: {promedio}\n");

            if (promedio >= 7 && promedio <= 10)
            {
                Console.WriteLine("\nPromocionado");
            }

            if (promedio >= 4 && promedio <= 6)
            {
                Console.WriteLine("\nRegular");
            }

            if (promedio < 4 && promedio >= 0)
            {
                Console.WriteLine("\nReprobado");
            }
        }
    }

    //Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo
    //(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).
    static void tarea2()
    {
        int lado = 0;
        int perimetro = 0;

        Console.Write("\nIngrese la longitud del lado de un cuadrado: ");
        lado = Convert.ToInt32(Console.ReadLine());

        perimetro = lado * 4;
        Console.WriteLine($"\nUn cuadrado cuyo 4 lados posean una longitud de {lado} su perímetro es {perimetro}.");
    }

    //Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente.
    //Mostrar lo que debe abonar el comprador.

    static void tarea1()
    {
        string articulo;
        int precioArticulo = 0;
        int cantidad = 0;
        int totalAbonar = 0;

        Console.Write("\nIngrese el nombre del artículo: ");
        articulo = Console.ReadLine();

        Console.Write("\nIngrese el precio del artículo: RD$");
        precioArticulo = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nIngrese la cantidad de este artículo: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        totalAbonar = precioArticulo * cantidad;
        Console.Write($"\nEl total a abonar es RD${totalAbonar}.\n");
    }

    static void practica1()
    {
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int suma = 0;
        int producto = 0;

        Console.WriteLine("\nIngrese el número 1:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nIngrese el número 2:");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nIngrese el número 3:");
        num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nIngrese el número 4:");
        num4 = Convert.ToInt32(Console.ReadLine());

        suma = num1 + num2;
        producto = num3 * num4;

        Console.WriteLine($"\nLa suma de los dos primeros números es: {suma} \n\nEl producto de los números 3 y 4 es: {producto}");
    }
}