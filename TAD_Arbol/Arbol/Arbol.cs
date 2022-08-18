using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAD_Arbol.Abstraccion;
using TAD_Arbol.Modelos;

namespace TAD_Arbol.EstructuraArbol
{
    public class Arbol : IArbol
    {
        public Nodo Raiz { get; set; }

        public Arbol()
        {
            Raiz = null;
        }

        public void AgregarNodo(Nodo Padre, Nodo NuevoElemento)
        {
            if (Raiz == null)
            {
                Raiz = NuevoElemento;
                return;
            }

            if (NuevoElemento.Dato_Letra.CompareTo(Padre.Dato_Letra) < 0) // Menor
            {
                if (Padre.Nodo_Izquierdo == null)
                {
                    Padre.Nodo_Izquierdo = NuevoElemento;
                }
                else
                {
                    AgregarNodo(Padre.Nodo_Izquierdo, NuevoElemento);
                }
            }
            else if (NuevoElemento.Dato_Letra.CompareTo(Padre.Dato_Letra) > 0) // Mayor
            {
                if (Padre.Nodo_Derecho == null)
                {
                    Padre.Nodo_Derecho = NuevoElemento;
                }
                else
                {
                    AgregarNodo(Padre.Nodo_Derecho, NuevoElemento);
                }
            }
        }

        public string Recorrido_PreOrden(Nodo ElementoRaiz)
        {
            string resultadoDelRecorrido = "";
            if (ElementoRaiz != null)
            {
                resultadoDelRecorrido += ElementoRaiz.Dato_Letra;
                resultadoDelRecorrido += Recorrido_PreOrden(ElementoRaiz.Nodo_Izquierdo);
                resultadoDelRecorrido += Recorrido_PreOrden(ElementoRaiz.Nodo_Derecho);
            }
            return resultadoDelRecorrido;
        }

        public string Recorrido_EnOrden(Nodo ElementoRaiz)
        {
            string resultadoDelRecorrido = "";
            if (ElementoRaiz != null)
            {
                resultadoDelRecorrido += Recorrido_EnOrden(ElementoRaiz.Nodo_Izquierdo);
                resultadoDelRecorrido += ElementoRaiz.Dato_Letra;
                resultadoDelRecorrido += Recorrido_EnOrden(ElementoRaiz.Nodo_Derecho);
            }
            return resultadoDelRecorrido;
        }

        public string Recorrido_PostOrden(Nodo ElementoRaiz)
        {
            string resultadoDelRecorrido = "";
            if (ElementoRaiz != null)
            {
                resultadoDelRecorrido += Recorrido_PostOrden(ElementoRaiz.Nodo_Izquierdo);
                resultadoDelRecorrido += Recorrido_PostOrden(ElementoRaiz.Nodo_Derecho);
                resultadoDelRecorrido += ElementoRaiz.Dato_Letra;
            }
            return resultadoDelRecorrido;
        }



    }
}
