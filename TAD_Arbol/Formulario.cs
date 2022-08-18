using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAD_Arbol.Graficar;
using TAD_Arbol.Modelos;
using TAD_Arbol.EstructuraArbol;
using System.IO;
using TAD_Arbol.Abstraccion;

namespace TAD_Arbol
{
    public partial class Formulario : Form
    {
        private Nodo Raiz;
        private Arbol Arbol;
        private Grafico Grafico;

        public Formulario()
        {
            InitializeComponent();
            Arbol = new Arbol();
        }


        private void btnGraficar_Click(object sender, EventArgs e)
        {
            Grafico = new Grafico(Arbol.Raiz);
            Grafico.DibujarArbol();
            MostrarArbol();
            
        }

        private void MostrarArbol()
        {
            if (File.Exists(@"C:\Users\kiuri\Imagen.png"))
            {
                using (FileStream img = new FileStream(@"C:\Users\kiuri\Imagen.png", FileMode.Open, FileAccess.Read))
                {
                    pbImagen.Image = Bitmap.FromStream(img);
                }
            }
            else
            {
                MessageBox.Show("No se ha podido abrir el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pbImagen.Refresh();
        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            if (txtExpresion.Text != "")
            {
                Nodo NuevoNodo = new Nodo();
                NuevoNodo.Dato_Letra = txtExpresion.Text.ToCharArray()[0];

                Nodo Padre = Arbol.Raiz;
                
                Arbol.AgregarNodo(Padre, NuevoNodo);
                Padre = Arbol.Raiz;


                txtPreOrden.Text = Arbol.Recorrido_PreOrden(Padre);
                txtEnOrden.Text = Arbol.Recorrido_EnOrden(Padre);
                txtPostOrden.Text = Arbol.Recorrido_PostOrden(Padre);

            }
            else
            {
                MessageBox.Show("Debes Agregar una letra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
