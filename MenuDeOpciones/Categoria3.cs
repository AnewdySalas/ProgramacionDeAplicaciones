using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDeOpciones
{
    public class Categoria3
    {
        
        public static void Menu()
        {
            int validacion = 0;
            do
            {


                Console.WriteLine("================================================================================================================================");
                Console.WriteLine("-------------------------------------------------------Ejercicios Categoria 3---------------------------------------------------");
                Console.WriteLine("================================================================================================================================");
                Console.WriteLine("1. Cálculo de los segundos que le faltan a una cantidad dada para completar un minuto exacto.");
                Console.WriteLine("2. Conversión jerárquica de una cantidad grande de minutos a su equivalente exacto expresado en días, horas y minutos restantes.");
                Console.WriteLine("0. Salir.");
                Console.WriteLine("===============================================================================================================================================");
                Console.Write("Selecciona una categoria del (1 al 2) y 0 para salir: ");
                int Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:

                        EjercicioCategoria3.Ejercicio1();
                        break;

                    case 2:


                        EjercicioCategoria3.Ejercicio2();
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

public class EjercicioCategoria3
{
    public static void Ejercicio1()
    {
        int tiemposegundos, minutos, segundosrestantes;
        Console.WriteLine("ingrese el tiempo en segundos");
        tiemposegundos = int.Parse(Console.ReadLine());
        if (tiemposegundos < 60 && tiemposegundos > 0)
        {
            segundosrestantes = 60 - tiemposegundos;
            Console.WriteLine("Le falta {0} segundos para convertirse en minuto",
        segundosrestantes);
        }
        else if (tiemposegundos >= 60)
        {
            minutos = (tiemposegundos - (tiemposegundos % 60)) / 60;
            segundosrestantes = tiemposegundos % 60;
            Console.WriteLine("equivale a {0} minutos y le faltan {1} segundos para convertirse en minuto", minutos, segundosrestantes);
        }
        else
        {
            Console.WriteLine("la cantidad de segundos debe ser un numero positivo");
        }
        Console.ReadLine();
    }
    public static void Ejercicio2()
    {
        int tiempo, dias, horas, minutos, x;
        Console.WriteLine("ingrese un tiempo en minutos");
        tiempo = int.Parse(Console.ReadLine());
        if (tiempo >= 0)
        {
            dias = (tiempo - (tiempo % 60)) / 1440;
            x = tiempo % 1440;
            horas = (x - (x % 60)) / 60;
            minutos = x % 60;
            Console.WriteLine("equivale a {0} dias con {1} horas y {2} minutos", dias,
        horas, minutos);
        }
        else
        {
            Console.WriteLine("el tiempo no puede ser negativo");
        }
        Console.ReadLine();
    }
}