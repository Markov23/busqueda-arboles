using BusquedaArboles.Clases.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaArboles
{
    public partial class Form1 : Form
    {
        //Nodos del arbol
        Nodo raiz = new Nodo("8");
        Nodo nodo3 = new Nodo("3");
        Nodo nodo10 = new Nodo("10");
        Nodo nodo1 = new Nodo("1");
        Nodo nodo6 = new Nodo("6");
        Nodo nodo14 = new Nodo("14");
        Nodo nodo4 = new Nodo("4");
        Nodo nodo7 = new Nodo("7");
        Nodo nodo13 = new Nodo("13");

        //Variables auxiliares
        Queue<Nodo> colaAnchura = new Queue<Nodo>();
        bool resultado;
        int contador;

        public Form1()
        {
            InitializeComponent();
            cbBusqueda.SelectedIndex = 0;
            cbNodo.SelectedIndex = 0;

            //Creación del arbol
            raiz.addHijo(nodo3);
            raiz.addHijo(nodo10);

            nodo3.addHijo(nodo1);
            nodo3.addHijo(nodo6);

            nodo6.addHijo(nodo4);
            nodo6.addHijo(nodo7);

            nodo10.addHijo(nodo14);
            nodo14.addHijo(nodo13);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lbNodos.Items.Clear();
            colaAnchura.Clear();
            resultado = false;
            contador = 0;

            if(cbBusqueda.SelectedIndex == 0)
            {
                busquedaAnchura(raiz);
            }
            else
            {
                busquedaProfundidad(raiz);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbNodos.Items.Clear();
        }

        public void busquedaAnchura(Nodo raiz)
        {
            contador++;
            lbNodos.Items.Add(contador + "- " + raiz.getValor());

            if (raiz.getValor().Equals(cbNodo.SelectedItem))
            {
                resultado = true;
                return;
            }

            for (int i = 0; i < raiz.getHijos().Count; i++)
            {
                colaAnchura.Enqueue(raiz.getHijo(i));
            }

            while (resultado == false && colaAnchura.Count > 0)
            {
                busquedaAnchura(colaAnchura.Dequeue());
            }
        }

        public void busquedaProfundidad(Nodo raiz)
        {
            Queue<Nodo> colaProfundidad = new Queue<Nodo>();

            contador++;
            lbNodos.Items.Add(contador + "- " + raiz.getValor());

            if(raiz.getValor().Equals(cbNodo.SelectedItem))
            {
                resultado = true;
                return;
            }

            for(int i = 0; i < raiz.getHijos().Count; i++)
            {
                colaProfundidad.Enqueue(raiz.getHijo(i));
            }

            while(resultado == false && colaProfundidad.Count > 0)
            {
                busquedaProfundidad(colaProfundidad.Dequeue());
            }
        }
    }
}
