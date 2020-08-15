using System;

namespace LIstasDoblementeLigadas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListasDoblementeLigadas lista = new ListasDoblementeLigadas();
            Console.WriteLine(lista.RecorrerLista());

            lista.AgregarNodo("Uno");
            lista.AgregarNodo("Dos");
            lista.AgregarNodo("Tres");

            Console.WriteLine(lista.RecorrerLista());

            lista.AgregarNodoInicio("Cero");
            Console.WriteLine(lista.RecorrerLista());
        }
    }
}
