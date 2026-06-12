using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDeOpciones
{
    public class Categoria5
    {
        public static void Menu()
        {
            int validacion = 0;
            do
            {


                Console.WriteLine("==============================================================================================================================================================================");
                Console.WriteLine("------------------------------------------------------------------------------Ejercicios Cagoria 5----------------------------------------------------------------------------");
                Console.WriteLine("==============================================================================================================================================================================");
                Console.WriteLine("1. Clasificación estadística de datos analizando propiedades numéricas (separar y contar cuántos números de un grupo son pares, impares, positivos o negativos).");
                Console.WriteLine("2. Control de flujo por lectura de caracteres (un bucle interactivo que detiene su ejecución inmediatamente cuando el usuario introduce la primera vocal).");
                Console.WriteLine("3. Simulación de la interfaz interactiva de una calculadora multioperaciones en consola con un límite de intentos.");
                Console.WriteLine("4. Ciberseguridad básica: Un sistema de control de acceso que realiza validaciones anidadas para comprobar una secuencia exacta de 5 claves secretas.");
                Console.WriteLine("0. Salir.");
                Console.WriteLine("=======================================================");
                Console.Write("Selecciona una categoria del (1 al 4 ) y 0 para salir: ");
                int Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:

                        EjercicioCategoria5.Ejercicio1();
                        break;

                    case 2:


                        EjercicioCategoria5.Ejercicio2();
                        break;


                    case 3:


                        EjercicioCategoria5.Ejercicio3();
                        break;

                    case 4:


                        EjercicioCategoria5.Ejercicio4();
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
public class EjercicioCategoria5
{
    public static void Ejercicio1()
    {
        double nota, sumaaprobadas, sumadesaprobadas, promedionotasaprobadas,
promedionotasdesaprobadas, promediofinal;
        int cantidadaprobadas, cantidaddesaprobadas;
        string respuesta;

        sumaaprobadas = 0;
        sumadesaprobadas = 0;
        cantidadaprobadas = 0;
        cantidaddesaprobadas = 0;

        do
        {
            Console.Write("Introduce la nota: ");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 10.5)
            {
                sumaaprobadas = sumaaprobadas + nota;
                cantidadaprobadas = cantidadaprobadas + 1;
            }
            else
            {
                sumadesaprobadas = sumadesaprobadas + nota;
                cantidaddesaprobadas = cantidaddesaprobadas + 1;
            }

            Console.Write("¿deseas ingresar otra nota?: ");
            respuesta = Console.ReadLine();
        }
        while (respuesta == "si");

        promedionotasaprobadas = sumaaprobadas / cantidadaprobadas;
        promedionotasdesaprobadas = sumadesaprobadas / cantidaddesaprobadas;
        promediofinal = (sumaaprobadas + sumadesaprobadas) / (cantidadaprobadas + cantidaddesaprobadas);

        Console.WriteLine("");
        Console.WriteLine("la cantidad de notas aprobadas es: " + cantidadaprobadas);
        Console.WriteLine("el promedio de las notas aprobadas es: " + promedionotasaprobadas);
        Console.WriteLine("el promedio de las notas desaprobadas es: " + promedionotasdesaprobadas);
        Console.WriteLine("el promedio final es: " + promediofinal);

        Console.ReadLine();
    }
    public static void Ejercicio2()
    {
        string caracter;
        int x;
        x = 1;
        do
        {
            Console.WriteLine("ingrese caracter");
            caracter = Console.ReadLine();
            if (caracter.Equals("a") || (caracter.Equals("e")) ||
            (caracter.Equals("i")) || (caracter.Equals("o")) || (caracter.Equals("u")))
                x = 0;
        }
        while (x == 1);
        Console.WriteLine("");
        Console.WriteLine("La primera vocal ingresada fue: " + caracter);
        Console.ReadLine();
    }
    public static void Ejercicio3()
    {
        double num1, num2, c, suma, resta, multiplicacion, division;
        c = 0;
        do
        {
            c = c + 1;
            Console.WriteLine("PROCESO Nº{0}:", c);
            Console.Write("ingrese primer numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("ingrese segundo numero: ");
            num2 = double.Parse(Console.ReadLine());
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = Math.Round(num1 / num2, 2);
            Console.WriteLine("");
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La resta es : " + resta);
            Console.WriteLine("La multiplicacion es: " + multiplicacion);
            Console.WriteLine("La division es: " + division);
            Console.WriteLine(" ");
        }
        while (c <= 9);
        Console.WriteLine("final del proceso");
        Console.ReadLine();
    }
    public static void Ejercicio4()
    {
        string c1, c2, c3, c4, c5;
        Console.Write("ingrese primera clave:  ");
        c1 = Console.ReadLine();
        if (c1 != "tienes")
            Console.WriteLine("TE EQUIVOCASTE DE FIESTA");
        else
        {
            Console.Write("ingrese segunda clave:  ");
            c2 = Console.ReadLine();
            if (c2 != "que ser")
                Console.WriteLine("TE EQUIVOCASTE DE FIESTA");
            else
            {
                Console.Write("ingrese tercera clave:  ");
                c3 = Console.ReadLine();
                if (c3 != "invitado")
                    Console.WriteLine("TE EQUIVOCASTE DE FIESTA");
                else
                {
                    Console.Write("ingrese cuarta clave:  ");
                    c4 = Console.ReadLine();
                    if (c4 != "para")
                        Console.WriteLine("TE EQUIVOCASTE DE FIESTA");
                    else
                    {
                        Console.Write("ingrese quinta clave:  ");
                        c5 = Console.ReadLine();
                        if (c5 != "ingresar")
                            Console.WriteLine("TE EQUIVOCASTE DE FIESTA");
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("BIENVENIDO A LA FIESTA");
                        }
                    }
                }
            }
        }
        Console.ReadLine();

    }

}