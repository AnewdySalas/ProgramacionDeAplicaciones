using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDeOpciones
{
    public class Categoria4
    {
        public static void Menu()
        {
            int validacion = 0;
            do
            {
                Console.WriteLine("===========================================================================================================================================");
                Console.WriteLine("----------------------------------------------------------Ejercicios Categoria 4-----------------------------------------------------------");
                Console.WriteLine("===========================================================================================================================================");
                Console.WriteLine("1. Control escolar: Registro de calificaciones para calcular la cantidad de aprobados, desaprobados y los promedios globales y segmentados.");
                Console.WriteLine("2. Estadística descriptiva: Obtención de la media aritmética (promedio) de una muestra grande (exactamente 100 números).");
                Console.WriteLine("3. Evaluación educativa: Promedio ponderado de dos notas con un sistema de validación estricto bajo la escala vigesimal (0 a 20).");
                Console.WriteLine("4. Estadística escolar: Tabulación y clasificación de alumnos de acuerdo a sus preferencias en cuatro disciplinas deportivas.");
                Console.WriteLine("0. Salir.");
                Console.WriteLine("============================================================================================================================================");
                Console.Write("Selecciona una categoria del (1 al 4 ) y 0 para salir: ");
                int Opcion = int.Parse(Console.ReadLine());


                switch (Opcion)
                {
                    case 1:

                        EjercicioCategoria4.Ejercicio1();
                        break;

                    case 2:


                        EjercicioCategoria4.Ejercicio2();
                        break;


                    case 3:


                        EjercicioCategoria4.Ejercicio3();
                        break;

                    case 4:


                        EjercicioCategoria4.Ejercicio4();
                        break;


                    case 0:
                        validacion = 1;
                        Console.WriteLine("Saliendo...");
                        break;
                }
            } while (validacion != 1);
        }

    }
}

public class EjercicioCategoria4
{
    public static void Ejercicio1()
    {
        double promedio, ca, cd, x, nota, acumuladasdesapro, acumuladasapro, acumuladas,
promedioaprobadas, promediodesaprobadas;
        string resp;
        x = 1;
        ca = 0;
        cd = 0;
        acumuladas = 0;
        acumuladasapro = 0;
        acumuladasdesapro = 0;
        do
        {
            Console.Write(" Introduce la nota: ");
            nota = int.Parse(Console.ReadLine());
            Console.Write(" ¿deseas ingresar otra nota?: ");
            resp = Console.ReadLine();
            Console.WriteLine("");
            if (nota <= 10.5 && nota >= 0)
            {
                cd = cd + 1;
                acumuladasdesapro = acumuladasdesapro + nota;
            }
            else if (nota > 10.5 && nota <= 20)
            {
                ca = ca + 1;
                acumuladasapro = acumuladasapro + nota;
            }
            acumuladas = acumuladas + nota;
            x = cd + ca;
        }
        while (resp == "si");
        promedioaprobadas = Math.Round(acumuladasapro / ca, 1);
        promediodesaprobadas = Math.Round(acumuladasdesapro / cd, 1);
        promedio = Math.Round(acumuladas / x, 1);
        Console.Clear();
        Console.WriteLine("la cantidad de notas desaprobadas es: " + cd);
        Console.WriteLine("la cantidad de notas aprobadas es: " + ca);
        Console.WriteLine("el promedio de las notas aprobadas es: " + promedioaprobadas);
        Console.WriteLine("el promedio de las notas desaprobadas es: " + promediodesaprobadas);
        Console.WriteLine("el promedio final es: " + promedio);
        Console.ReadLine();
    }
    public static void Ejercicio2()
    {
        double suma, media, x, numero;
        suma = 0;
        for (x = 1; x <= 100; x = x + 1)
        {
            Console.Write("ingrese  {0}° numero:  ", x);
            numero = double.Parse(Console.ReadLine());
            suma = suma + numero;
        }
        media = Math.Round(suma / 100, 2);
        Console.WriteLine("");
        Console.WriteLine("la media de los 100 numero ingresados es: " + media);
        Console.ReadLine();
    }
    public static void Ejercicio3()
    {
        double nota1, nota2, promedio;
        Console.Write("ingrese primera nota: ");
        nota1 = double.Parse(Console.ReadLine());
        Console.Write("ingrese seunda nota: ");
        nota2 = double.Parse(Console.ReadLine());
        promedio = (nota1 + nota2) / 2;
        if (nota1 >= 0 && nota1 <= 20 && nota2 >= 0 && nota2 <= 20)
        {
            if (promedio >= 10.5 && promedio <= 20)
            {
                Console.WriteLine("");
                Console.WriteLine("Promedio: " + promedio);
                Console.WriteLine("aprobado");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Promedio: " + promedio);
                Console.WriteLine("desaprobado");
            }
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("EROR... Las notas ingresadas no se encuentran en la escala vigesimal(0 - 20)");
        }
        Console.ReadLine();
    }
    public static void Ejercicio4()
    {
        string deporte;
        int vole, fut, aje, basq, c;
        vole = 0;
        fut = 0;
        aje = 0;
        basq = 0;
        c = 1;
        Console.WriteLine("LOS DEPORTES A INGRESAR PUEDEN SER FUTBOL, BASQUET, VOLEY Y AJEDREZ");
        do
        {
            c = c + 1;
            Console.Write("Ingrese deporte del {0}° alumno : ", c - 1);
            deporte = (Console.ReadLine());
            if (deporte == "voley")
            {
                vole = vole + 1;
            }
            else if (deporte == "futbol")
            {
                fut = fut + 1;
            }
            else if (deporte == "basquet")
            {
                basq = basq + 1;
            }
            else if (deporte == "ajedrez")
            {
                aje = aje + 1;
            }
            else
            {
                Console.WriteLine("error deporte no valido");
            }
        }
        while (c <= 10);
        Console.WriteLine("");
        Console.WriteLine("cantidad de voley: " + vole);
        Console.WriteLine("cantidad de futbol: " + fut);
        Console.WriteLine("cantidad de basquet: " + basq);
        Console.WriteLine("cantidad de ajedrez: " + aje);
        Console.ReadLine();

    }
}