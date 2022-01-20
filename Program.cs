using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program 
    {

        static void Main(string[] args)
        {
            Componente<string> arbol = new Compuesto<string>("root");
            Componente<string> trabajo = arbol;

            String opcion = " ";
            string dato = " ";

            while (opcion != "6")
            {
                Console.WriteLine("Estoy en {0}", trabajo.Nombre);
                Console.WriteLine("1-Adicionar Compuesto 2-Adicionar Componente 3-Borrar 4-Buscar 5-Mostrar 6-Salir ");
                opcion = Console.ReadLine();
                Console.WriteLine("--------------");

                if (opcion == "1")
                {
                    Console.WriteLine("Dame el nombre del compuesto: ");
                    dato = Console.ReadLine();

                    Componente<string> c = new Compuesto<string>(dato);
                    trabajo.Adicionar(c);
                    trabajo = c;
                }

                if (opcion == "2")
                {
                    Console.WriteLine("Dame el nombre del Componente: ");
                    dato = Console.ReadLine();

                    trabajo.Adicionar(new ComponenteEjemplo<string>(dato));
                }

                if (opcion == "3")
                {
                    Console.WriteLine("Dame el elemento a borrar: ");
                    dato = Console.ReadLine();

                    trabajo = trabajo.Borrar(dato);
                }

                if (opcion == "4")
                {
                    Console.WriteLine("Dame el elemento a encontrar: ");
                    dato = Console.ReadLine();
                    trabajo = arbol.Buscar(dato);
                }

                if (opcion == "5")
                {
                    Console.WriteLine(arbol.Mostrar(0));
                }
            }
        }

    }
}
