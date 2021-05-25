using System;

namespace Taller2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer 4 notas, calcular el promedio e imprimir un mensaje indicando que reprobó en caso que la nota sea menor a 3.5

            double Nota1, Nota2, Nota3, Nota4, Promedio;
            sbyte Menu;
            while (true)
            {
                try
                {
                    Console.WriteLine("1) Calcular Nota\n2) Salir");
                    Menu = sbyte.Parse(Console.ReadLine());
                    if (Menu == 1)
                    {
                        Console.WriteLine("               Bienvenidos a tu Nota 2.0\n");

                        Console.WriteLine("Ingresa  tu Primera Nota");
                        Nota1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa  tu Segunda Nota");
                        Nota2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa  tu Tercera Nota");
                        Nota3 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa  tu Cuarta Nota");
                        Nota4 = double.Parse(Console.ReadLine());

                        Promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

                        if (Promedio >= 80 && Promedio <= 100 || Promedio >= 4 && Promedio <= 5) Console.WriteLine("\nAprobaste, tienes una calificacion de {0} puntos, Puntaje Excelente \n", Promedio);

                        else if (Promedio >= 65 && Promedio < 80 || Promedio >= 3.5 && Promedio < 4) Console.WriteLine("Aprobaste, tienes una calificacion de {0} puntos, Puntaje Bueno \n", Promedio);

                        else if (Promedio >= 30 && Promedio < 65 || Promedio >= 2 && Promedio < 3.5) Console.WriteLine("Reprobaste, tienes una calificacion de {0} puntos, Puntaje malo \n", Promedio);

                        else if (Promedio >= 0) Console.WriteLine("\nReprobaste, tienes una calificacion de {0} puntos, Puntaje Muy bajo \n", Promedio);
                    }

                    else if (Menu == 2)
                    {
                        Console.WriteLine("Feliz Dia...Hasta luego");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Error... Selecione una opcion correcta del 1 hasta el 2");
                    }
                }
                catch (System.FormatException) { Console.WriteLine("Por favor... Ingrese un numero correcto"); }

                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
