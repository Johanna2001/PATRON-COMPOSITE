using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class ComponenteEjemplo<T> : Componente<T>
    {
        //IDENTIFICADOR DEL COMPONENTE 
        public T Nombre { get; set; }
        public ComponenteEjemplo(T pNombre)
        {
            Nombre = pNombre;
        }
        public void Adicionar(Componente<T> pElemento)
        {
            Console.WriteLine("Solo se adiciona  los compuestos, no a los componentes");
        }
        public Componente<T> Borrar(T pElemento)
        {
            Console.WriteLine("No se puede eliminar directamente");
            return this;
        }
        public Componente<T> Buscar(T pElemento)
        {
            if (pElemento.Equals(Nombre))
                return this;
            else
                return null;
        }
        public string Mostrar(int pProfundidad)
        {
            //colocamos la cantidad - segun la profundidad
           return new string( '-', pProfundidad) +  Nombre  +  "\n\r";
        }
    }

}