﻿using System;
using System.Collections;

namespace RepasoColecciones.Stack_LIFO_
{

    class Program
    {
        static void Main(string[] args)
        {

            //Variables que vamos a utilizar
            int opcion = 0;
            string valor = "";
            int numero = 0;
            bool encontrado = false;

            //Creamos el Stack
            Stack miTorre = new Stack();

            do
            {
                //Mostramos el menú
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Clear");
                Console.WriteLine("4. Contains");
                Console.WriteLine("5. Salir");

                Console.Write("Dame la opción: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if (opcion == 1)
                {
                    //Pedimos el valor que se va a introducir
                    Console.Write("Dame el valor a introducir: ");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    //Agregamos el valor al Stack
                    miTorre.Push(numero);
                }

                if (opcion == 2)
                {
                    //Obtenemos el elemento
                    numero = (int)miTorre.Pop();

                    //Mostramos el elemento
                    Console.WriteLine("El valor obtenido es: {0}", numero);
                }

                if (opcion == 3)
                {
                    //Limpiamos todo el contenido del Stack
                    miTorre.Clear();
                }

                if (opcion == 4)
                {
                    //Pedimos el valor que queremos encontrar
                    Console.Write("Dame el valor a encontrar: ");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    //Verificamos que este el elemento
                    encontrado = miTorre.Contains(numero);

                    //Mostramos el resultado
                    Console.WriteLine("Encontrado - {0}", encontrado);
                }

                //Mostramos la información del Stack
                Console.WriteLine("El Stack tiene {0} elemento", miTorre.Count);
                foreach (int n in miTorre)
                    Console.Write(" {0}, ", n);

                Console.WriteLine("");
                Console.WriteLine("....");



            } while (opcion != 5);



        }//Cierre de Main
    }
}
