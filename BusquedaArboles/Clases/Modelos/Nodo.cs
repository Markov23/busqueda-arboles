using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaArboles.Clases.Modelos
{
    public class Nodo
    {
        private string valor;
        private List<Nodo> hijos;

        public Nodo()
        {
            this.valor = "";
            this.hijos = new List<Nodo>();
        }

        public Nodo(string valor)
        {
            this.valor = valor;
            this.hijos = new List<Nodo>();
        }

        public Nodo(string valor, List<Nodo> hijos)
        {
            this.valor = valor;
            this.hijos = hijos;
        }

        public string getValor()
        {
            return this.valor;
        }

        public void setValor(string valor)
        {
            this.valor = valor;
        }

        public List<Nodo> getHijos()
        {
            return this.hijos;
        }

        public void setHijos(List<Nodo> hijos)
        {
            this.hijos = hijos;
        }

        public void addHijo(Nodo hijo)
        {
            this.hijos.Add(hijo);
        }

        public Nodo getHijo(int indice)
        {
            return this.hijos[indice];
        }

        public void removeHijo(int indice)
        {
            this.hijos.RemoveAt(indice);
        }
    }
}
