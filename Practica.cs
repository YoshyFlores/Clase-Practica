using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBiblioteca
{
    public class Practica
    {
        public static void SortedListCollection()
        {
            //definir el tamaño de la lista.
            Console.WriteLine("Cuantos elementos agregara a la lista:");
            var elements = Convert.ToInt32(Console.ReadLine());

            //declarar arrays vacios.
            object[] key = new object[elements];
            object[] value = new object[elements];

            //declarar la lista.
            SortedList<object, object> srtList = new SortedList<object, object>();
            int i = 0;

            while (i < elements)
            {
                Console.WriteLine("Escriba el elemento a agregar {0}", i);

                //llenar los arrays.
                Console.WriteLine("Key:");
                key[i] = Console.ReadLine();
                Console.WriteLine("Value:");
                value[i] = Console.ReadLine();

                //llenar la lista vacia.
                srtList.Add(key[i], value[i]);
                i++;
            }
            //mostrar elementos en la lista.
            Console.WriteLine("****ELEMENTOS DE LA LISTA****");
            foreach (KeyValuePair<object, object> element in srtList)
            {
                Console.WriteLine("{0}: {1}", element.Key, element.Value);
            }
        }

    }
}
