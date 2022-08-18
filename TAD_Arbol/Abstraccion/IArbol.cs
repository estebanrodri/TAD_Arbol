using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAD_Arbol.Modelos;

namespace TAD_Arbol.Abstraccion
{
    public interface IArbol
    {
        void AgregarNodo(Nodo Padre, Nodo NuevoElemento);
        string Recorrido_PreOrden(Nodo ElementoRaiz);
        string Recorrido_EnOrden(Nodo ElementoRaiz);
        string Recorrido_PostOrden(Nodo ElementoRaiz);
    }
}
