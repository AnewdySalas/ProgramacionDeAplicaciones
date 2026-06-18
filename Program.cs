using System;
using ejerciciosBucles;

class MenuEjercicios
{
    public static void Main()
    {
      
       
            Console.WriteLine("=========================================================================================================================================================================================================");
            Console.WriteLine("--------------------------------------------------------------------------Menu de ejercicios-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("=========================================================================================================================================================================================================");
            Console.WriteLine("1. Contador simple Escribe un programa que use un ciclo for para mostrar los números del 1 al 10 en pantalla.");
            Console.WriteLine("2. Suma de números Utiliza un ciclo while para calcular y mostrar la suma de los primeros 100 números naturales.");
            Console.WriteLine("3. Tabla de multiplicar Solicita al usuario un número y muestra su tabla de multiplicar del 1 al 10 usando un ciclo for.");
            Console.WriteLine("4. Números pares Usa un ciclo for para mostrar todos los números pares entre 1 y 50.");
            Console.WriteLine("5. Promedio de notas Pide al usuario la cantidad de notas a ingresar. Luego, usando un ciclo for, solicita cada nota y calcula el promedio final.");
            Console.WriteLine("6. Arreglo de números Declara un arreglo de 5 números enteros. Usa un ciclo for para cargar los valores y otro ciclo para mostrarlos en pantalla.");
            Console.WriteLine("7. Mayor y menor en un arreglo Crea un programa que solicite al usuario 10 números, los almacene en un arreglo y, usando un ciclo repetitivo, determine el número mayor y el menor.");
            Console.WriteLine("8. Contador de positivos, negativos y ceros Llena un arreglo con n números ingresados por el usuario. Recorre el arreglo con un ciclo y cuenta cuántos son positivos, negativos y cuántos son ceros.");
            Console.WriteLine("9. Búsqueda en un arreglo Crea un arreglo de números enteros y pide al usuario un valor a buscar. Utiliza un ciclo for o while para indicar si el número existe en el arreglo y en qué posición se encuentra.");
            Console.WriteLine("10. Frecuencia de valores Solicita al usuario una lista de números (almacenados en un arreglo). Luego, usando ciclos repetitivos, determina cuántas veces se repite cada número y muestra el resultado.");
            Console.WriteLine("0. Salir");
            Console.WriteLine("=========================================================================================================================================================================================================");
            Console.Write("Ingrese una opcion del (1 al 10 y 0 para salir): ");
             int Opcion = int.Parse(Console.ReadLine());

            switch (Opcion)
            {
                case 1:
                    Ejercicios.Ejercicio1();
                    break;
                case 2:
                    Ejercicios.Ejercicio2();
                    break;
                case 3:
                    Ejercicios.Ejercicio3();
                    break;
                case 4:
                    Ejercicios.Ejercicio4();
                    break;
                case 5:
                    Ejercicios.Ejercicio5();
                    break;
                case 6:
                    Ejercicios.Ejercicio6();
                    break;
                case 7:
                    Ejercicios.Ejercicio7();
                    break;
                case 8:
                    Ejercicios.Ejercicio8();
                    break;
                case 9:
                    Ejercicios.Ejercicio9();
                    break;
                case 10:
                    Ejercicios.Ejercicio10();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

            }

        

    }
}


