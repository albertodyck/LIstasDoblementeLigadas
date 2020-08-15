namespace LIstasDoblementeLigadas
{
    public class Nodo
    {
        private Nodo anterior;
        private string dato;
        private Nodo siguiente;

        public Nodo Anterior { get => anterior; set => anterior = value; }
        public string Dato { get => dato; set => dato = value; }
        public Nodo Siguiente { get => siguiente; set => siguiente = value; }

        public Nodo()
        {
            anterior = null;
            siguiente = null;
        }

    }
}
