using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Compuesto<T> : Componente<T>
    {
        //Lista donde guardamos los elementos que va a guardar
        List<Componente<T>> elementos;

        //Identificador 
        public T Nombre { get; set; }

        public Compuesto(T pNombre)
        {
            Nombre = pNombre;

            //Instanciamos la Lista
            elementos = new List<Componente<T>>();
        }
        public void Adicionar(Componente<T> pElemento)
        {
            elementos.Add(pElemento);
        }
        public Componente<T> Borrar(T pElemento)
        {
            //Buscamos el elemento Borrar
            Componente<T> elemento = this.Buscar(pElemento);

            //Si la encontramos, la eliminamos de la lista
            if (elemento != null)
            {
                (this as Compuesto<T>).elementos.Remove(elemento);
            }
            return this;
        }
        public Componente<T> Buscar(T pElemento)
        {
            //si somos quien se busca nos regresamos
            if (Nombre.Equals(pElemento))
                return this;

            Componente<T> encontrado = null;

            //Recorremos la lista y buscamos en nuestros elementos 
            foreach (Componente<T> elemento in elementos)
            {
                encontrado = elemento.Buscar(pElemento);
                if (encontrado != null)
                    break;
            }
            return encontrado;
        }
        public string Mostrar(int pProfundidad)
        {
            //construimos la cadena con una cantidad de - igual a la profundidad

            StringBuilder infoElemento = new StringBuilder(new string( '-',  pProfundidad));
           
            //Adicionamos la informacion del compuesto 
            infoElemento.Append("Compuesto: " + Nombre + "elementos : " + elementos.Count + "\r\n");
           
            //Adicionamos los elementos 
            foreach (Componente<T> elemento in elementos)
                infoElemento.Append(elemento.Mostrar(pProfundidad + 1));

            return infoElemento.ToString();
        }
    }
}
