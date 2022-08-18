using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD_Arbol.Modelos
{
    public class Nodo
    {
        public Char Dato_Letra { get; set; }
        public Nodo Nodo_Izquierdo { get; set; }
        public Nodo Nodo_Derecho { get; set; }

        public Nodo(Char Dato_Letra)
        {
            this.Dato_Letra = Dato_Letra;
            this.Nodo_Izquierdo = null;
            this.Nodo_Derecho = null;
        }

        public Nodo()
        {
            this.Dato_Letra = '_';
            this.Nodo_Izquierdo = null;
            this.Nodo_Derecho = null;
        }

    }
}
