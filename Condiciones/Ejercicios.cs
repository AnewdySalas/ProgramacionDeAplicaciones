using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Condiciones
{
    public static class Ejercicios
    {
        public static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1: Número positivo, negativo o cero");
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }
        }
        public static void Ejercicio2()
        {
            Console.WriteLine("Ejercicio 2: Número par o impar");
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 0)
            {
                Console.WriteLine("El numero es cero");
            }
            else if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }
        }
        public static void Ejercicio3()
        {
            Console.WriteLine("Ejercicio 3: Mayor de edad");
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 0 || edad > 100)
            {
                Console.WriteLine("Edad inválida. Por favor ingrese una edad entre 0 y 100.");
                return;
            }

            else if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad.");
            }
        }
        public static void Ejercicio4()
        {
            Console.WriteLine("Ejercicio 4: Múltiplo de 5");
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 5 == 0)
            {
                Console.WriteLine("El número es múltiplo de 5.");
            }
            else
            {
                Console.WriteLine("El número no es múltiplo de 5.");
            }
        }
        public static void Ejercicio5()
        {
            Console.WriteLine("Ejercicio 5: Descuento por edad");
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            double PrecioTarifa = 300.00;
            double PrecioFinal;
            double PorcientoDeDescuento = 0.50;
            double Descuento;
            if (edad < 0 || edad > 100)
            {
                Console.WriteLine("Edad inválida. Por favor ingrese una edad entre 0 y 100.");
            }
            else if (edad >= 60)
            {
                Descuento = PorcientoDeDescuento * PrecioTarifa;
                PrecioFinal = PrecioTarifa - Descuento;
                Console.WriteLine("=======================");
                Console.WriteLine("--------Factura--------");
                Console.WriteLine("=======================");
                Console.WriteLine($"Tarifa:  ${PrecioTarifa}");
                Console.WriteLine($"Descuento: -${Descuento}");
                Console.WriteLine($"Total a pagar: {PrecioFinal}");

            }
            else
            {
                PrecioFinal = PrecioTarifa;
                Console.WriteLine("=======================");
                Console.WriteLine("--------Factura--------");
                Console.WriteLine("=======================");
                Console.WriteLine($"Tarifa:  ${PrecioTarifa}");
                Console.WriteLine($"Total a pagar: {PrecioFinal}");
            }

        }
        public static void Ejercicio6()
        {
            Console.WriteLine("Ejercicio 6: Calificación aprobatoria");
            Console.Write("Ingrese su calificación (0-100): ");
            int calificacion = int.Parse(Console.ReadLine());
            if (calificacion < 0 || calificacion > 100)
            {
                Console.WriteLine("Calificación inválida. Por favor ingrese una calificación entre 0 y 100.");
            }
            else if (calificacion >= 60)
            {
                Console.WriteLine("¡Felicidades! Has aprobado.");
            }
            else
            {
                Console.WriteLine("Lo siento, has reprobado.");
            }
        }
        public static void Ejercicio7()
        {
            Console.WriteLine("Ejercicio 7: Día de la semana");
            Console.Write("Ingrese un número del 1 al 7: ");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Lunes");
                    break;
                case 3:
                    Console.WriteLine("Martes");
                    break;
                case 4:
                    Console.WriteLine("Miercoles");
                    break;
                case 5:
                    Console.WriteLine("Jueves");
                    break;
                case 6:
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Número inválido. Por favor ingrese un número entre 1 y 7.");
                    break;
            }
        }
        public static void Ejercicio8()
        {
            Console.WriteLine("Ejercicio 8: Número mayor entre dos");
            Console.Write("Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine($"El número mayor es: {numero1}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"El número mayor es: {numero2}");
            }
            else
            {
                Console.WriteLine("Ambos números son iguales.");
            }
        }
        public static void Ejercicio9()
        {
            Console.WriteLine("Ejercicio 9: Mayor entre tres números");
            Console.Write("Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            int numero3 = int.Parse(Console.ReadLine());
            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine($"El número mayor es: {numero1}");
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                Console.WriteLine($"El número mayor es: {numero2}");
            }
            else if (numero3 > numero1 && numero3 > numero2)
            {
                Console.WriteLine($"El número mayor es: {numero3}");
            }
            else
            {
                Console.WriteLine("Hay numeros iguales.");
            }

        }
        public static void Ejercicio10()
        {
            Console.WriteLine("Ejercicio 10: Clasificación de ángulos");
            Console.Write("Ingrese el valor del ángulo en grados: ");
            int angulo = int.Parse(Console.ReadLine());
            if (angulo < 0 || angulo > 360)
            {
                Console.WriteLine("Ángulo inválido. Por favor ingrese un ángulo entre 0 y 360 grados.");
            }
            else if (angulo < 90)
            {
                Console.WriteLine("El ángulo es agudo.");
            }
            else if (angulo == 90)
            {
                Console.WriteLine("El ángulo es recto.");
            }
            else if (angulo < 180)
            {
                Console.WriteLine("El ángulo es obtuso.");
            }
            else if (angulo == 180)
            {
                Console.WriteLine("El ángulo es llano.");
            }
            else
            {
                Console.WriteLine("El ángulo es cóncavo.");
            }
        }
        public static void Ejercicio11()
        {
            Console.WriteLine("Ejercicio 11: Cálculo de impuestos");
            Console.Write("Ingrese el monto de la compra: ");
            double Salario = double.Parse(Console.ReadLine());
            double Impuesto;
            if (Salario < 10000)
            {
                Console.WriteLine("El total de impuesto a pagar es de 0$");
            }
            else if (Salario <= 30000.00)
            {
                Impuesto = Salario * 0.10;
                Console.WriteLine($"El total de impuestos a pagar es de {Impuesto}");
            }
            else
            {
                Impuesto = Salario * 0.20;
                Console.WriteLine($"El total de impuestos a pagar es de {Impuesto}");
            }
        }
        public static void Ejercicio12()
        {
            Console.WriteLine("Ejercicio 12: Clasificación de números");
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else if (numero == 0)
            {
                Console.WriteLine("El número es cero.");
            }
            else
            {
                Console.WriteLine("El número es positivo.");
            }
        }
        public static void Ejercicio13()
        {
            Console.WriteLine("Ejercicio 13: Verificación de año bisiesto");
            Console.Write("Ingrese un año: ");
            int Anio = int.Parse(Console.ReadLine());
            if (Anio < 0)
            {
                Console.WriteLine("Año inválido. Por favor ingrese un año positivo.");
            }
            else if ((Anio % 4 == 0 && Anio % 100 != 0) || (Anio % 400 == 0))
            {
                Console.WriteLine($"El año {Anio} es bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {Anio} no es bisiesto.");
            }
        }
        public static void Ejercicio14()
        {
            Console.WriteLine("Ejercicio 14: Conversión de calificaciones");
            Console.Write("Ingrese su calificación (0-100): ");
            int calificacion = int.Parse(Console.ReadLine());
            if (calificacion < 0 || calificacion > 100)
            {
                Console.WriteLine("Calificación inválida. Por favor ingrese una calificación entre 0 y 100.");
            }
            else if (calificacion >= 90)
            {
                Console.WriteLine("Su calificación es A.");
            }
            else if (calificacion >= 80)
            {
                Console.WriteLine("Su calificación es B.");
            }
            else if (calificacion >= 70)
            {
                Console.WriteLine("Su calificación es C.");
            }
            else if (calificacion >= 60)
            {
                Console.WriteLine("Su calificación es D.");
            }
            else
            {
                Console.WriteLine("Su calificación es F.");
            }
        }
        public static void Ejercicio15()
        {
            Console.WriteLine("Ejercicio 15: Comparación de tres longitudes");
            Console.Write("Ingrese la primera longitud: ");
            double longitud1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda longitud: ");
            double longitud2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la tercera longitud: ");
            double longitud3 = double.Parse(Console.ReadLine());
            if (longitud1 == longitud2 && longitud2 == longitud3)
            {
                Console.WriteLine("Las tres longitudes son iguales.");
            }
            else if (longitud1 == longitud2 || longitud1 == longitud3 || longitud2 == longitud3)
            {
                Console.WriteLine("Dos longitudes son iguales.");
            }
            else
            {
                Console.WriteLine("Todas las longitudes son diferentes.");
            }
        }
        public static void Ejercicio16()
        {
            Console.WriteLine("Ejercicio 16: Calculadora de descuentos");
            Console.Write("Ingrese el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el porcentaje de descuento (0-100): ");
            double descuento = double.Parse(Console.ReadLine());
            if (descuento < 0 || descuento > 100)
            {
                Console.WriteLine("Porcentaje de descuento inválido. Por favor ingrese un valor entre 0 y 100.");
            }
            else
            {
                double precioFinal = precio - (precio * (descuento / 100));
                Console.WriteLine($"El precio final después del descuento es: {precioFinal}");
            }
        }
        public static void Ejercicio17()
        {
            Console.WriteLine("Ejercicio 17: Tipo de triángulo");
            Console.Write("Ingrese el primer lado del triángulo: ");
            double lado1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo lado del triángulo: ");
            double lado2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer lado del triángulo: ");
            double lado3 = double.Parse(Console.ReadLine());
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
            {
                Console.WriteLine("Lados inválidos. Por favor ingrese longitudes positivas.");
                return;
            }
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
        public static void Ejercicio18()
        {
            Console.WriteLine("Ejercicio 18: Evaluación de temperatura");
            Console.Write("Ingrese la temperatura en grados Celsius: ");
            double temperatura = double.Parse(Console.ReadLine());
            if (temperatura < 0)
            {
                Console.WriteLine("Hace mucho frio.");
            }
            else if (temperatura <= 20)
            {
                Console.WriteLine("Clima fresco.");
            }
            else if (temperatura <= 30)
            {
                Console.WriteLine("Clima agradable.");
            }
            else
            {
                Console.WriteLine("Hace mucho calor.");
            }
        }
        public static void Ejercicio19()
        {
            Console.WriteLine("Ejercicio 19: Conversión de horas a turnos");
            Console.Write("Ingrese la hora (0-23): ");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 0 || hora > 23)
            {
                Console.WriteLine("Hora inválida. Por favor ingrese una hora entre 0 y 23.");
            }
            else if (hora >= 6 && hora <= 11)
            {
                Console.WriteLine("Turno de la mañana.");
            }
            else if (hora >= 12 && hora <= 17)
            {
                Console.WriteLine("Turno de la tarde.");
            }
            else
            {
                Console.WriteLine("Turno de la noche.");
            }
        }
        public static void Ejercicio20()
        {
            Console.WriteLine("Ejercicio 20: Clasificación de IMC");
            Console.Write("Ingrese su peso en kilogramos: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su altura en metros: ");
            double altura = double.Parse(Console.ReadLine());
            if (altura <= 0)
            {
                Console.WriteLine("Altura inválida. Por favor ingrese una altura positiva.");
                return;
            }
            double imc = peso / (altura * altura);
            if (imc < 18.5)
            {
                Console.WriteLine($"Su IMC es {imc:F2}. Usted está bajo de peso.");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine($"Su IMC es {imc:F2}. Usted tiene un peso normal.");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine($"Su IMC es {imc:F2}. Usted tiene sobrepeso.");
            }
            else
            {
                Console.WriteLine($"Su IMC es {imc:F2}. Usted tiene obesidad.");
            }
        }
    }
}



