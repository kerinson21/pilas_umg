using pilasUmg.listasimple;
using System;
using System.Collections.Generic;
using System.Text;

namespace pilasUmg.pilas
{
    class PilaListaEnlazada
    {
        private int cima;
        private MyListaSimple listaPila;

        public PilaListaEnlazada()
        {
            cima = -1; // condicion de pila vacia.
            listaPila = new MyListaSimple();
        }

        public void insertar(Object elemento)
        {
            cima++;
            listaPila.Adicionar(elemento);
        }

        public Object quitar()
        {
            Object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            aux = listaPila.obtenerNodo(cima).getDato();
            listaPila.removerElemento(cima);
            cima--;
            return aux;
        }

        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            return listaPila.obtenerNodo(cima).getDato();
        }

        public bool pilaVacia()
        {
            return cima == -1;
        }

        public Object quitarChar()
        {
            char aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            aux = (char)listaPila.obtenerNodo(cima).getDato();
            cima--;
            return aux;
        }

        public void limpiarPila()
        {
            while (!pilaVacia())
            {
                quitar();
            }
        }
    }
}
