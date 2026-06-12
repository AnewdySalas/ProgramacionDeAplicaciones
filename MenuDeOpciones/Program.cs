using System;
namespace MenuDeOpciones 
{ 
    public class Programs
    {
        static void Main()
        {
            int validacion = 0;
            do
            {
                Console.WriteLine("=======================================================");
                Console.WriteLine("------------------Menu de categorias-------------------");
                Console.WriteLine("=======================================================");
                Console.WriteLine("1. Finanzas, Cormecio y Gestion Laoral (Area Economica)");
                Console.WriteLine("2. Matemtica Puras, Algebras y Geometria");
                Console.WriteLine("3. Gestion y Conversion de Unidades de tiempo");
                Console.WriteLine("4. Educacion, calificacion y estadisticas");
                Console.WriteLine("5. Logica General, Interaccion de teclado y seguridad");
                Console.WriteLine("0. Salir.");
                Console.WriteLine("=======================================================");
                Console.Write("Selecciona una categoria del (1 al  5) y 0 para salir: ");
                int Opcion = int.Parse(Console.ReadLine());

                switch(Opcion)
                {
                    case 1:
                        Categoria1.Menu();
                        break;

                    case 2:
                        Categoria2.Menu();
                        break;

                    case 3:
                        Categoria3.Menu();
                        break;

                    case 4:
                        Categoria4.Menu();
                        break;

                    case 5:
                        Categoria5.Menu();
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