using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using TAD_Arbol.Modelos;
using System.Diagnostics;

namespace TAD_Arbol.Graficar
{
    public class Grafico
    {
        private Nodo Arbol;
        private string ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private string Comando = @"/c Batch.bat";
        private char i, j;

        public Grafico(Nodo Arbol)
        {
            this.Arbol = Arbol;
        }

        //Dibujando
        public void DibujarArbol()
        {
            CrearArchivo();
            EjecutarArchivo();
        }

        private string CrearArchivo()
        {
            string CadenaDot = "";
            IniciarArchivoDot(Arbol, ref CadenaDot);
            using (StreamWriter archivo = new StreamWriter(ruta + @"\Arbol.dot")) {
                archivo.WriteLine(CadenaDot);
                archivo.Close();
            }
            return CadenaDot;
        }

        private void IniciarArchivoDot(Nodo Arbol, ref string CadenaDot)
        {
            if (Arbol != null)
            {
                CadenaDot += "digraph Grafico {\nnode [style=bold, fillcolor=gray];\n";
                Recorrido(Arbol, ref CadenaDot);
                CadenaDot +="\n}";
            }
        }

        private void Recorrido(Nodo Arbol, ref string CadenaDot)
        {
            if (Arbol != null)
            {
                CadenaDot += $"{Arbol.Dato_Letra}\n";
                if (Arbol.Nodo_Izquierdo != null)
                {
                    i = Arbol.Dato_Letra;
                    j = Arbol.Nodo_Izquierdo.Dato_Letra;
                    CadenaDot += $"{i}->{j};\n";
                }

                if (Arbol.Nodo_Derecho != null)
                {
                    i = Arbol.Dato_Letra;
                    j = Arbol.Nodo_Derecho.Dato_Letra;
                    CadenaDot += $"{i}->{j};\n";
                }
                Recorrido(Arbol.Nodo_Izquierdo, ref CadenaDot);
                Recorrido(Arbol.Nodo_Derecho, ref CadenaDot);
            }
        }

        private void EjecutarArchivo()
        {
            Directory.SetCurrentDirectory(ruta);
            using (Process proceso = new Process())
            {
                ProcessStartInfo Info = new ProcessStartInfo("cmd", Comando);
                Info.CreateNoWindow = true;
                proceso.StartInfo = Info;
                proceso.Start();
                proceso.WaitForExit();
                proceso.Close();
            }


        }

    }
}
