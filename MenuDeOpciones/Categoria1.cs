using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDeOpciones
{
    public class Categoria1
    {

        public static void Menu()
        {
            int validacion = 0;
            do
            {
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("------------------------------------------------Ejercicios Categoria 1---------------------------------------------------");
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("1. Cálculo del salario de un empleado incluyendo el recargo por horas extras");
                Console.WriteLine("2. Deducción de descuentos por tramos sobre el sueldo bruto de un trabajador para obtener su sueldo neto.");
                Console.WriteLine("3. Aplicación de porcentajes de descuento comercial en compras dependiendo de si el monto supera un límite establecido.");
                Console.WriteLine("4. Gestión de nómina mediante la suma acumulada de los salarios de múltiples empleados");
                Console.WriteLine("5. Emisión de facturas comerciales calculando el precio de venta, el Impuesto al Valor Añadido (IVA) y descuentos adicionales.");
                Console.WriteLine("6. Control financiero en un restaurante para procesar cuentas de clientes y aplicar promociones automáticas.");
                Console.WriteLine("7. Contabilidad de caja chica mediante el registro y resta diaria de egresos hasta agotar un saldo inicial.");
                Console.WriteLine("8. Cálculo directo y básico de salarios (multiplicación de horas por tarifa horaria).");
                Console.WriteLine("0. Salir");
                Console.WriteLine("=======================================================");
                Console.Write("Selecciona una categoria del (1 al  5) y 0 para salir: ");
                int Opcion = int.Parse(Console.ReadLine());
                

                switch (Opcion)
                {
                    case 1:

                        EjercicioCategoria1.Ejercicio1();
                        break;

                    case 2:

                        EjercicioCategoria1.Ejercicio2();
                        break;

                    case 3:

                        EjercicioCategoria1.Ejercicio3();
                        break;

                    case 4:

                        EjercicioCategoria1.Ejercicio4();
                        break;

                    case 5:
                        EjercicioCategoria1.Ejercicio5();
                        break;

                    case 6:
                        EjercicioCategoria1.Ejercicio6();
                        break;

                    case 7:
                        EjercicioCategoria1.Ejercicio7();
                        break;


                    case 8:
                        EjercicioCategoria1.Ejercicio8();
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

public class EjercicioCategoria1
{
    public static void Ejercicio1()
    {
        double tarifa, horastrabajadas, horasextra, salario, tarifaextra;

        Console.WriteLine("ingrese horas trabajadas");
        horastrabajadas = double.Parse(Console.ReadLine());

        Console.WriteLine("ingrese tarifa");
        tarifa = double.Parse(Console.ReadLine());

        if (horastrabajadas <= 40 && horastrabajadas >= 0)
        {
            salario = horastrabajadas * tarifa;
            Console.WriteLine("el salario es: " + salario);
        }
        else if (horastrabajadas > 40)
        {
            horasextra = horastrabajadas - 40;
            tarifaextra = tarifa + (tarifa * 0.5);
            salario = (40 * tarifa) + (horasextra * tarifaextra);
            Console.WriteLine("el salario es: " + salario);
        }
        else
        {
            Console.WriteLine("las horas trabajadas no pueden ser negativas");
        }

        Console.ReadLine();
    }
    public static void Ejercicio2()
    {
        double sueldo, sueldoneto, descuento;

        Console.WriteLine("ingrese el sueldo");
        sueldo = double.Parse(Console.ReadLine());

        if (sueldo <= 1000 && sueldo >= 0)
        {
            descuento = sueldo * 0.10;
            sueldoneto = sueldo - descuento;
            Console.WriteLine("el descuento es: {0} y el sueldo neto es: {1}", descuento, sueldoneto);
        }
        else if (sueldo <= 2000 && sueldo > 1000)
        {

            descuento = (1000 * 0.10) + ((sueldo - 1000) * 0.05);
            sueldoneto = sueldo - descuento;
            Console.WriteLine("el descuento es: {0} y el sueldo neto es: {1}", descuento, sueldoneto);
        }
        else if (sueldo > 2000)
        {
            descuento = (1000 * 0.10) + (1000 * 0.05) + ((sueldo - 2000) * 0.03);
            sueldoneto = sueldo - descuento;
            Console.WriteLine("el descuento es: {0} y el sueldo neto es: {1}", descuento, sueldoneto);
        }
        else
        {
            Console.WriteLine("error el sueldo no puede ser negativo");
        }

        Console.ReadLine();
    }
    public static void Ejercicio3()
    {
        double monto, descuento;

        Console.WriteLine("ingrese monto");
        monto = double.Parse(Console.ReadLine());

        if (monto > 100)
        {
            descuento = monto * 0.10;
            Console.WriteLine("el monto {0} tiene un descuento del {1}", monto, descuento);
        }
        else if (monto <= 100 && monto > 0)
        {
            descuento = monto * 0.02;
            Console.WriteLine("el monto {0} tiene un descuento del {1}", monto, descuento);
        }
        else
        {
            Console.WriteLine("error el monto no puede ser negativo");
        }

        Console.ReadLine();
    }
    public static void Ejercicio4()
    {
        double x, salario, horastrabajadas, tarifa, suma, numerotrabajadores;
        suma = 0;

        Console.Write("ingrese la cantidad de trabajadores: ");
        numerotrabajadores = double.Parse(Console.ReadLine());

        for (x = 1; x <= numerotrabajadores; x++)
        {
            Console.WriteLine("\ntrabajador {0}: ", x);
            Console.Write(" horas trabajadas: ");
            horastrabajadas = double.Parse(Console.ReadLine());
            Console.Write(" tarifa: ");
            tarifa = double.Parse(Console.ReadLine());

            salario = horastrabajadas * tarifa;
            suma = suma + salario;
        }

        Console.WriteLine("\nla suma de los salarios es: {0}", suma);
        Console.ReadLine();

    }
    public static void Ejercicio5()
    {
        double horastrabajadas, tarifa, salario;

        Console.Write("ingrese horas trabajadas: ");
        horastrabajadas = double.Parse(Console.ReadLine());

        Console.Write("ingrese tarifa: ");
        tarifa = double.Parse(Console.ReadLine());

        salario = horastrabajadas * tarifa;
        Console.WriteLine("El salario del trabajador es: " + salario);

        Console.ReadLine();

    }
    public static void Ejercicio6()
    {
        double precio, numeroarticulos, precioventa, descuento, preciobruto,
iva, totalpagar;
        Console.Write("ingrese el precio: ");
        precio = double.Parse(Console.ReadLine());
        Console.Write("ingrese numero de articulos: ");
        numeroarticulos = double.Parse(Console.ReadLine());
        precioventa = precio * numeroarticulos;
        iva = Math.Round(precioventa * 0.15, 2);
        preciobruto = precioventa + iva;
        if (preciobruto >= 50)
        {
            descuento = Math.Round((preciobruto * 5) / 100, 2);
        }
        else
        {
            descuento = 0;
        }
        totalpagar = preciobruto - descuento;
        Console.WriteLine(" ");
        Console.WriteLine(" Datos de la factura ");
        Console.WriteLine(" ");
        Console.WriteLine(" Precio de venta : " + precioventa);
        Console.WriteLine(" Impuesto sobre el valor añadido (IVA) es: " + iva);
        Console.WriteLine(" Precio bruto es : " + preciobruto);
        Console.WriteLine(" Descuento es : " + descuento);
        Console.WriteLine(" Total a pagar: " + totalpagar);
        Console.ReadLine();

    }
    public static void Ejercicio7()
    {
        double consumo, descuento, total, c;
        c = 1;
        total = 0;
        do
        {
            c = c + 1;
            Console.Write("Ingrese {0}° consumo:  ", c - 1);
            consumo = double.Parse(Console.ReadLine());
            if (consumo > 130)
            {
                descuento = consumo * 0.15;
            }
            else
            {
                descuento = 0;
            }
            consumo = consumo - descuento;
            total = total + consumo;
        }
        while (c <= 130);
        Console.WriteLine("");
        Console.WriteLine("El total de los consumos es: " + total);
        Console.WriteLine("FIN DEL PROCESO");
        Console.ReadLine();

    }
    public static void Ejercicio8()
    {
        double caja, egreso, cont, totalegresos, restocaja;
        totalegresos = 0;
        caja = 371;
        cont = 0;
        do
        {
            cont = cont + 1;
            Console.Write("Ingrese {0} egreso: ", cont);
            egreso = double.Parse(Console.ReadLine());
            totalegresos = totalegresos + egreso;
            restocaja = caja - totalegresos;
        }
        while (egreso != -1);
        {
            Console.WriteLine("");
            Console.WriteLine("El total de egresos es: {0}",
        totalegresos + 1);
            Console.WriteLine("Lo sobrante en caja es: {0}",
        restocaja - 1);
            Console.ReadLine();
        }

    }
}


