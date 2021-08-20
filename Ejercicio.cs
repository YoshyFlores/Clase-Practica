using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Practica
{
    public class Ejercicio
    {
        //Librería que imprima el dia de la semana a partir de un numero.
        public static void Semana()
        {
            int datos;
            Console.WriteLine("Ingrese un número comprendido entre 1-7");
            datos = int.Parse(Console.ReadLine());

            switch (datos)

            {
                case 1:
                    Console.WriteLine("El número ingresado corresponde al día lunes.");
                    break;
                case 2:
                    Console.WriteLine("El número ingresado corresponde al día martes.");
                    break;
                case 3:
                    Console.WriteLine("El número ingresado corresponde al día miercoles.");
                    break;
                case 4:
                    Console.WriteLine("El número ingresado corresponde al día jueves.");
                    break;
                case 5:
                    Console.WriteLine("El número ingresado corresponde al día viernes.");
                    break;
                case 6:
                    Console.WriteLine("El número ingresado corresponde al día sabado.");
                    break;
                case 7:
                    Console.WriteLine("El número ingresado corresponde al día domingo.");
                    break;
                default:
                    Console.WriteLine("El numero ingresado no corresponde a un dia de la semana.");
                    break;
            }
        }
    }
}
