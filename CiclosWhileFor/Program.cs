using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclosWhileFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //For
            //Parte 1: Valor de la iteracion
            //Parte 2: Condicion 
            //Parte 3: Aumento o decremento

            int tabla;



            // int i = 1; parte 1
            Console.WriteLine(" Ingrese un numero de la tabla que quiere calcular");
            tabla = int.Parse(Console.ReadLine());
                //Inicio de Ciclo While
                        //parte 2
                        // while (i<= 10)
                        //{
                        //   Console.WriteLine(" " + tabla * i);
                        //parte 3
                        //  i++; 
                        //}

                        //Console.ReadKey();
                //Fin de Ciclo While

            //Inicio de ciclo For
            for (int i=1; i <= 10; i++)
            {
                Console.WriteLine(" " + tabla * i);
            }
            Console.ReadKey();

        }
    }
}
