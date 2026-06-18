using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Schema;

namespace ejerciciosBucles
{
    public class Ejercicios 
    {
        public static void Ejercicio1()
        {
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Ejercicio2()
        {
            Console.WriteLine("================================");
            Console.WriteLine("--Suma de numeros del 1 al 100--");
            Console.WriteLine("================================");
            int i = 0;
            int suma = 0;
            while(i <= 100)
            {
                suma = suma + i;
                i++;
            }
            Console.WriteLine($"La suma total es: {suma}");
        }
        public static void Ejercicio3()
        {
            Console.Write("Ingresa el numero a multiplicar: ");
            int numero = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {i * numero}");
            }

        }
        public static void Ejercicio4()
        {
            for (int i = 1; i <= 50; i++)
            {
                if(i %2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Ejercicio5()
        {
            Console.Write("Ingrese cantidad de notas: ");
            int Cantidad = int.Parse(Console.ReadLine());
            double Promedio;
            double suma = 0;
            for (int i = 1; i <= Cantidad; i++)
            {
                Console.Write($"Ingrese la  nota numero {i}: ");
                double nota = double.Parse(Console.ReadLine());
                suma += nota;
            }
            Promedio = suma / Cantidad;
            Console.WriteLine($"El promedio de las notas es: {Promedio}");
        }
        public static void Ejercicio6()
        {
            int[] Numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingresa el numero {i + 1}: ");
                Numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int num = 0; num < 5; num++)
            {
                Console.WriteLine(Numeros[num]);
            }
        }
        public static void Ejercicio7()
        {

            
            int[] Numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingresa el numero {i + 1}: ");
                Numeros[i] = int.Parse(Console.ReadLine());
            }
            int Menor = Numeros[0];
            int Mayor = Numeros[0];
            foreach ( int Numero in Numeros)
            {
                if (Numero > Mayor)
                {
                    Mayor = Numero;
                }
                if (Numero < Menor)
                {
                    Menor = Numero;
                }
            }
            Console.WriteLine($"El numero menor es {Menor}");
            Console.WriteLine($"El numero mayor es {Mayor}");
        }
        public static void Ejercicio8()
        {
            int Positivos = 0;
            int Negativos = 0;
            int Ceros = 0;

            Console.Write("Cantidad de numeros a introducir: ");
            int Cantidad = int.Parse(Console.ReadLine());
            int[] Numeros = new int[Cantidad];
            for (int i = 0; i < Cantidad; i++)
            {
                Console.Write($"Ingresa el numero {i + 1}: ");
                Numeros[i] = int.Parse(Console.ReadLine());
            }
            foreach (int Numero in Numeros)
            {
                if (Numero > 0)
                {
                    Positivos++;
                }
                else if (Numero < 0)
                {
                    Negativos++;
                }
                else if (Numero == 0)
                {
                    Ceros++;
                }
            }
            Console.WriteLine("========================");
            Console.WriteLine("-------Resultado--------");
            Console.WriteLine("========================");
            Console.WriteLine($"Positivos: {Positivos}");
            Console.WriteLine($"Negativos: {Negativos}");
            Console.WriteLine($"Ceros:  {Ceros} ");
        }
        public static void Ejercicio9()
        {
            Console.Write("Ingresa el numero a buscar: ");
            int Busqueda = int.Parse(Console.ReadLine());
            bool Respuesta = false;
            int Posicion = 0;
            Random random = new Random();
            int[] Numeros = new int[15];
           for(int i = 0; i < Numeros.Length; i++ )
            {
                Numeros[i] = random.Next(1, 101);
            }

           Console.WriteLine("===========================");
           Console.WriteLine("---Numeros en el arreglo---");
            Console.WriteLine("==========================");
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] == Busqueda)
                {
                    Posicion = i;
                    Respuesta = true;
                    
                }
                Console.WriteLine(Numeros[i]);
            }
           Console.WriteLine("==========================");
           if (Respuesta)
            {
                Console.WriteLine($"Numero {Busqueda} Encontrado su posicion es la numero {Posicion}");
            }
           else
            {
                Console.WriteLine($" El numero {Busqueda} no esta  en el arreglo!");
            }



        }
        public static void Ejercicio10()
        {
            Console.Write("¿Cuántos números quieres ingresar? ");
            int cantidad = int.Parse(Console.ReadLine());

            int[] Numeros = new int[cantidad];

            
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingresa el numero {i + 1}: ");
                Numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("=============================");
            Console.WriteLine("--- Frecuencia de valores ---");
            Console.WriteLine("=============================");

            for (int i = 0; i < cantidad; i++)
            {
                int numero = Numeros[i];
                int frecuencia = 0;

                for (int j = 0; j < cantidad; j++)
                {
                    if (Numeros[j] == numero)
                    {
                        frecuencia++;
                    }
                }

                if (i == 0 || (i > 0 && Numeros[i] != Numeros[i - 1]))
                {
                    Console.WriteLine($"El número {numero} aparece {frecuencia} veces");
                }
            }
        }
    }
}
