using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDeOpciones
{
    public class Categoria2
    {
        public static void Menu()
        {
            int validacion = 0;
            do
            {
                Console.WriteLine("============================================================================================================================================");
                Console.WriteLine("-------------------------------------------------------Ejercicios Categoria 2-----------------------------------------------------------------");
                Console.WriteLine("============================================================================================================================================");
                Console.WriteLine("1. Sumatoria matemática de los primeros $N$ números naturales consecutivos.");
                Console.WriteLine("2. Descomposición aritmética de un número entero para calcular la suma de sus dígitos individuales.");
                Console.WriteLine("3. Operación matemática para obtener el factorial de un número.");
                Console.WriteLine("4. Cálculo combinado (suma y producto) dentro de un rango específico de números pares.");
                Console.WriteLine("5. Análisis numérico para comprobar si un número real tiene o no parte fraccionaria.");
                Console.WriteLine("6. Álgebra elemental: Resolución de ecuaciones de segundo grado ($aX^2 + bX + c = 0$) mediante la fórmula cuadrática y análisis de raíces.");
                Console.WriteLine("7. Operaciones de potenciación (calcular el cubo) y radicación (calcular la raíz cuadrada) de entradas numéricas.");
                Console.WriteLine("8. Ejecución repetitiva de operaciones aritméticas básicas (suma, resta, multiplicación, división)");
                Console.WriteLine("9. Geometría plana: Cálculo del área de cualquier triángulo mediante la fórmula de Herón a partir de sus tres lados.");
                Console.WriteLine("10. Geometría fundamental: Obtención de la hipotenusa de un triángulo rectángulo aplicando el Teorema de Pitágoras.");
                Console.WriteLine("11. Geometría espacial y analítica: Cálculo de la longitud de una circunferencia, área de un círculo y volumen de una esfera según su radio.");
                Console.WriteLine("12. Sumatorias algebraicas de series numéricas que comienzan obligatoriamente en un valor base fijo (el número 8).");
                Console.WriteLine("0. Salir.");
                Console.WriteLine("==============================================================================================================================================");
                Console.Write("Selecciona una categoria del (1 al  12) y 0 para salir: ");
                int Opcion = int.Parse(Console.ReadLine());


                switch (Opcion)
                {
                    case 1:

                        EjercicioCategoria2.Ejercicio1();
                        break;

                    case 2:

                        EjercicioCategoria2.Ejercicio2();
                        break;

                    case 3:

                        EjercicioCategoria2.Ejercicio3();
                        break;

                    case 4:

                        EjercicioCategoria2.Ejercicio4();
                        break;

                    case 5:
                        EjercicioCategoria2.Ejercicio5();
                        break;

                    case 6:
                        EjercicioCategoria2.Ejercicio6();
                        break;

                    case 7:
                        EjercicioCategoria2.Ejercicio7();
                        break;


                    case 8:
                        EjercicioCategoria2.Ejercicio8();
                        break;

                    case 9:
                        EjercicioCategoria2.Ejercicio9();
                        break;

                    case 10:
                        EjercicioCategoria2.Ejercicio10();
                        break;

                    case 11:
                        EjercicioCategoria2.Ejercicio11();
                        break;

                    case 12:
                        EjercicioCategoria2.Ejercicio12();
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
public class EjercicioCategoria2
{
    public static void Ejercicio1()
    {
        int x, numero, suma;
        Console.Write("ingrese el numero N : ");
        numero = int.Parse(Console.ReadLine());
        suma = 0;
        for (x = 1; x <= numero; x = x + 1)
        {
            suma = suma + x;
            Console.WriteLine("n{0}: {1}", x, x);
        }
        Console.WriteLine("");
        Console.WriteLine("La suma de la serie es: {0}", suma);
        Console.ReadLine();
    }
    public static void Ejercicio2()
    {
        int numero, suma, residuo;
        suma = 0;
        Console.WriteLine("ingresar un numero");
        numero = int.Parse(Console.ReadLine());
        do
        {
            residuo = numero % 10;
            suma = suma + residuo;
            numero = (numero - (numero % 10)) / 10;
        }
        while (numero != 0);
        {
            Console.WriteLine("");
            Console.WriteLine("la suma es de los digitos es: {0} ", suma);
        }
        Console.ReadLine();
    }
    public static void Ejercicio3()
    {
        int numero, factorial, i;
        Console.Write("ingresar numero: ");
        numero = int.Parse(Console.ReadLine());
        factorial = 1;
        for (i = 1; i <= numero; i++)
            factorial = factorial * i; 
        Console.WriteLine("");
        Console.WriteLine("Factorial: ");
        Console.WriteLine(" {0}! = {1} ", numero, factorial);
        Console.ReadLine();
    }
    public static void Ejercicio4()
    {
        int suma, producto, x;
        suma = 0;
        producto = 1;
        for (x = 20; x <= 30; x = x + 2)
        {
            suma = suma + x;
            producto = producto * x;
        }
        Console.WriteLine("Rango : numeros pares del 20 al 30");
        Console.WriteLine("");
        Console.WriteLine("La suma es: " + suma);
        Console.WriteLine("El producto es: " + producto);
        Console.ReadLine();

    }
    public static void Ejercicio5()
    {
        double numero, pf;
        Console.WriteLine("ingrese un numero");
        numero = double.Parse(Console.ReadLine());
        pf = Math.Truncate(numero);
        if (numero == pf)
            Console.WriteLine("no tiene parte fraccionaria");
        else
            Console.WriteLine("tiene parte fraccionaria");
        Console.ReadLine();

    }
    public static void Ejercicio6()
    {
        double a, b, c, discriminante, x1, x2, partereal, parteimaginaria;

        Console.WriteLine("soluciones de la ecuacion cuadratica");
        Console.WriteLine("dada la ecuacion aX2 + bx + c = 0 ingresar los coeficientes a,b,c para calcular");
        Console.WriteLine("las posibles valores de X");
        Console.WriteLine("");

        Console.Write("ingrese el coeficiente a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("ingrese el coeficiente b: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("ingrese el coeficiente c: ");
        c = double.Parse(Console.ReadLine());

        discriminante = (b * b) - (4 * a * c);

        if (discriminante > 0)
        {
            x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            Console.WriteLine("");
            Console.WriteLine("La ecuacion tiene dos soluciones reales:");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
        else if (discriminante == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("");
            Console.WriteLine("La ecuacion tiene una solucion real:");
            Console.WriteLine("x = " + x1);
        }
        else
        {
            partereal = -b / (2 * a);
            parteimaginaria = Math.Sqrt(Math.Abs(discriminante)) / (2 * a);
            Console.WriteLine("");
            Console.WriteLine("discriminante es " + discriminante + " se obtienen las siguientes raices imaginarias:");
            Console.WriteLine("x1 = " + partereal + "+i(" + parteimaginaria + ")");
            Console.WriteLine("x2 = " + partereal + "-i(" + parteimaginaria + ")");
        }

        Console.ReadLine();

    }
    public static void Ejercicio7()
    {
        double numero, c, cubo, raizcuadrada;
        c = 0;
        do
        {
            c = c + 1;
            Console.WriteLine("PROCESO Nº{0}:", c);
            Console.Write("ingrese un numero: ");
            numero = double.Parse(Console.ReadLine());
            if (numero != 0)
            {
                cubo = Math.Pow(numero, 3);
                raizcuadrada = Math.Round(Math.Pow(numero, 0.5), 2);
                Console.WriteLine("El cubo es: " + cubo);
                Console.WriteLine("La raiz cuadrada es: " + raizcuadrada);
                Console.WriteLine("");
            }
        }
        while (numero != 0);
        Console.WriteLine("");
        Console.WriteLine("FINAL DEL PROCESO");
        Console.ReadLine();

    }
    public static void Ejercicio8()
    {
        double num1, num2, c, suma, resta, multiplicacion, division;
        c = 0;
        do
        {
            c = c + 1;
            Console.WriteLine("PROCESO Nº{0}:", c);
            Console.Write("ingrese primer numero: ");
            num1 = double.Parse(Console.ReadLine());
            if (num1 != 0)
            {
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
        }
        while (num1 != 0);
        Console.WriteLine(" ");
        Console.WriteLine("FINAL DEL PROCESO");
        Console.ReadLine();
    }
    public static void Ejercicio9()
    {
        double ladoa, ladob, ladoc, sm, areatriangulo;
        Console.Write("ingrese lado A: ");
        ladoa = double.Parse(Console.ReadLine());
        Console.Write("ingrese lado B: ");
        ladob = double.Parse(Console.ReadLine());
        Console.Write("ingrese lado C: ");
        ladoc = double.Parse(Console.ReadLine());
        sm = (ladoa + ladob + ladoc) / 2;
        areatriangulo = Math.Round(Math.Pow(sm * (sm - ladoa) * sm * (sm - ladob) * sm
        * (sm - ladoc), 0.5), 2);
        Console.WriteLine("El area del triangulo es: " + areatriangulo);
        Console.ReadLine();
    }
    public static void Ejercicio10()
    {
        double cateoa, catetob, hipotenusa;
        Console.Write("Ingrese primer cateto: ");
        cateoa = double.Parse(Console.ReadLine());
        Console.Write("Ingrese segundo cateto: ");
        catetob = double.Parse(Console.ReadLine());
        hipotenusa = Math.Round(Math.Pow(Math.Pow(cateoa, 2) +
        Math.Pow(catetob, 2), 0.5), 2);
        Console.WriteLine("");
        Console.WriteLine("La hipotenusa es: {0}", hipotenusa);
        Console.ReadLine();
    }
    public static void Ejercicio11()
    {
        double pi, radio, área, volumen, longitud;
        pi = 3.14;
        Console.Write("Ingrese el radio de la circunferencia: ");
        radio = int.Parse(Console.ReadLine());
        longitud = 2 * pi * radio;
        área = Math.Round(pi * Math.Pow(radio, 2), 2);
        volumen = Math.Round((4 / 3) * pi * Math.Pow(radio, 3), 2);
        Console.WriteLine("");
        Console.WriteLine("Longitud de la circunferencia: " +
        longitud);
        Console.WriteLine("Area de la circunferencia: " + área);
        Console.WriteLine("Volumen de la circunferencia: " + volumen);
        Console.ReadLine();
    }
    public static void Ejercicio12()
    {
        int numero, suma, x;
        suma = 0;
        Console.Write("Ingrese el numero enesimo: ");
        numero = int.Parse(Console.ReadLine());
        if (numero < 8)
        {
            Console.WriteLine("");
            Console.WriteLine("Error el numero ingresado es menor a8");
        }
        else
        {
            for (x = 8; x <= numero; x = x + 1)
            {
                suma = suma + x;
            }
            Console.WriteLine("");
            Console.WriteLine("La suma de la serie de rango 8 hasta {0}, con un incremento de 1 es: {1}", numero, suma);
        }
        Console.ReadLine();
    }

}