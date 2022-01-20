using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Composite
{
    interface Componente<T>
    {
        T Nombre { get; set; }
        void Adicionar(Componente<T> pElemento);
        Componente<T> Borrar(T pElemento);
        Componente<T> Buscar(T pElemento);
        string Mostrar(int pProfundidad);
    }
}
