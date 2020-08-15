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

        public void VaciarLista()
        {
            nodoInicial.Siguiente = null;
        }

        public bool ValidaVacia()
        {
            return (nodoInicial.Siguiente == null);
        }

        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }

            Nodo nodoNuevo = new Nodo();
            nodoNuevo.Dato = dato;

            nodoNuevo.Siguiente = null;
            nodoNuevo.Anterior = nodoActual;
            nodoActual.Siguiente = nodoNuevo;
        }

        public void AgregarNodoInicio(string dato)
        {
            nodoActual = nodoInicial;

            Nodo nodoNuevo = new Nodo();
            nodoNuevo.Dato = dato;

            nodoNuevo.Anterior = nodoInicial;
            nodoNuevo.Siguiente = nodoInicial.Siguiente;
            nodoInicial.Siguiente = nodoNuevo;
            nodoNuevo.Siguiente.Anterior = nodoNuevo;
        }

        public Nodo Buscar(string dato)
        {
            if (ValidaVacia())
            {
                return null;
            }

            Nodo nodoBusqueda = nodoInicial;

            while (nodoBusqueda.Siguiente != null)
            {
                nodoBusqueda = nodoBusqueda.Siguiente;

                if (nodoBusqueda.Dato == dato)
                {
                    return nodoBusqueda;
                }
            }

            return null;
        }

        public Nodo BuscarIndice(int indice)
        {
            int Indice = -1;

            if (ValidaVacia())
            {
                return null;
            }

            nodoActual = nodoInicial;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                Indice++;

                if (Indice == indice)
                {
                    return nodoActual;
                }
            }

            return null;
        }

        public Nodo BuscarAnterior(string dato)
        {
            if (ValidaVacia())
            {
                return null;
            }

            Nodo nodoBusqueda = nodoInicial;
            while (nodoBusqueda.Siguiente != null)   
            {
                nodoBusqueda = nodoBusqueda.Siguiente;

                if (nodoBusqueda.Dato == dato)
                {
                    return nodoBusqueda.Anterior;
                }
            }

            return null;
        }

    }

}
