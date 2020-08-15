using System;
using System.Collections.Generic;
using System.Text;

namespace LIstasDoblementeLigadas
{
    public class ListasDoblementeLigadas
    {
        private Nodo nodoInicial;
        private Nodo nodoActual;

        public ListasDoblementeLigadas()
        {
            nodoInicial = new Nodo();

            nodoInicial.Anterior = null;
            nodoInicial.Siguiente = null;
            
        }

        public string RecorrerLista()
        {
            string datos = string.Empty;

            nodoActual = nodoInicial;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                datos += $"{nodoActual.Dato}\n";
            }

            return datos;
        }

    }

}
